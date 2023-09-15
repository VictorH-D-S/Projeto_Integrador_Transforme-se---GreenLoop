using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_serasa_greenloop
{
    public partial class DarPontos : Form
    {

        void verificaCampo()
        {
            string CPF = txtCPF.Texts;
            int Pontuacao;

            if (string.IsNullOrWhiteSpace(CPF) || !int.TryParse(txtPontuacao.Texts, out Pontuacao) || CPF.Length != 11 || !CPF.All(char.IsDigit) || Pontuacao > 10)
            {
                lblErro.Visible = true;
                txtCPF.BorderColor = Color.Red;
                txtPontuacao.BorderColor = Color.Red;
                return;
            }


            if (Conexao.CPFExisteNaTabela(CPF))
            {
                txtCPF.BorderColor = Color.Black;
                txtPontuacao.BorderColor = Color.Black;
                lblErro.Visible = false;
                txtCPF.Texts = "";
                txtPontuacao.Texts = "";
                txtCPF.Focus();
                lblTudoCerto.BringToFront();
                lblTudoCerto.Visible = true; lblTudoCerto.Enabled = true;
                iconPictureBox1.Visible = true; iconPictureBox1.Enabled = true;
                Conexao.AdicionarPontos(CPF, Pontuacao);
                return;
            }

            lblErro.Visible = true;
            txtCPF.BorderColor = Color.Red;
            txtPontuacao.BorderColor = Color.Red;
            return;
        }

        public DarPontos()
        {
            InitializeComponent();
        }

        void darPontos()
        {
            string cpf = txtCPF.Texts;

            int pontuacao = int.Parse(txtPontuacao.Texts);

            Polos polos = new Polos();
            polos.darPontos(cpf, pontuacao);
        }

        private void PainelResponsivo_DarPontos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DarPontos_Load(object sender, EventArgs e)
        {
            PainelResponsivo_DarPontos.Location = new Point((this.Width - PainelResponsivo_DarPontos.Width) / 2, (this.Height - PainelResponsivo_DarPontos.Height) / 2);
            this.WindowState = FormWindowState.Maximized;
            Form1.Voltar.Enabled = false;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            verificaCampo();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = false; iconPictureBox1.Enabled = false;
            lblTudoCerto.Visible = false; lblTudoCerto.Enabled = false;
        }

        private void lblTudoCerto_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = false; iconPictureBox1.Enabled = false;
            lblTudoCerto.Visible = false; lblTudoCerto.Enabled = false;
        }
    }
}

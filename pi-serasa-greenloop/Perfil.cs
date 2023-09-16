using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }
        public void carregaForm(Form form)
        {
            form.TopLevel = false;
            Form1.painel.Controls.Clear();
            Form1.painel.Controls.Add(form);
            form.Size = Form1.painel.Size;
            form.Location = new Point(Form1.painel.Width - form.Width, Form1.painel.Height - form.Height);
            form.Show();

        }

        void atualizaInterface()
        {
            int newY = (this.ClientSize.Height - pnlPerfil.Height - 100) / 2;
            pnlPerfil.Location = new Point(pnlPerfil.Location.X, newY);
            this.WindowState = FormWindowState.Maximized;
        }
        void atualizaPerfil()
        {
            lblEmail.Text = Program.pessoa.email;
            lblPontos.Text = Program.pessoa.pontos.ToString();
            string nome = Program.pessoa.nome;
            if (!string.IsNullOrEmpty(nome))
            {
                nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
            }
            lblNome.Text = nome;
            lblNasciemnto.Text = Program.pessoa.idade.ToString();
            lblCpf.Text = FormatarCpf(Program.pessoa.cpf);
        }


        string FormatarCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            {
                return "CPF inválido";
            }

            string parte1 = cpf.Substring(0, 9);
            string parte2 = cpf.Substring(9, 2);

            return $"{parte1.Substring(0, 3)}.{parte1.Substring(3, 3)}.{parte1.Substring(6, 3)}-{parte2}";
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load_1(object sender, EventArgs e)
        {
            atualizaPerfil();
            atualizaInterface();
        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblPontos_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirConta_Usuário_Click_1(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            DialogResult result = MessageBox.Show("Deseja sair?", "Sair de sua Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                carregaForm(new Login());
            }
            else
            {
            }
        }
    }
}

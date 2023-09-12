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

        void atualizaInterface()
        {
            pnlResponsivo_Perfil.Location = new Point((this.ClientSize.Width - pnlResponsivo_Perfil.Width) / 2, (this.ClientSize.Height - pnlResponsivo_Perfil.Height - 100) / 2);
            this.WindowState = FormWindowState.Maximized;
        }

        void atualizaPerfil()
        {
            lblEmail.Text = Program.pessoa.email;
            lblCpf.Text = Program.pessoa.cpf;
            lblNasciemnto.Text = Program.pessoa.idade.ToString();
            lblNome.Text = Program.pessoa.nome;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            atualizaPerfil();
            atualizaInterface();
        }

        private void pnlResponsivo_Perfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcluirConta_Usuário_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            pessoas.deletarPerfil();
            MessageBox.Show("Conta deletada com sucesso!");
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void pnlResponsivo_Perfil_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Perfil_Load_1(object sender, EventArgs e)
        {
            atualizaPerfil();
            atualizaInterface();
        }
    }
}

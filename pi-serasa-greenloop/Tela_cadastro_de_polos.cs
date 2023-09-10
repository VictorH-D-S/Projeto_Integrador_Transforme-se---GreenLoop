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
    public partial class Tela_cadastro_de_polos : Form
    {
        public Tela_cadastro_de_polos()
        {
            InitializeComponent();
        }

        void iniciar()
        {
            btnAdicionar.BackColor = Color.Blue;
            btnRemover.BackColor = Color.Red;
        }

        public void operacaoPolos()
        {
            string nome = txtNome.Texts;
            string endereco = txtEndereco.Texts;
            string email = txtEmail.Texts;
            string senha = txtSenha.Texts;

            Polos polos = new Polos(nome, email, senha, endereco);

            if (btnAdicionar.BackColor == Color.Blue)
            {
                polos.inserePolo();
            }
            if (btnRemover.BackColor == Color.Blue)
            {
                polos.removePolo();
            }
        }

        private void Tela_cadastro_de_polos_Load(object sender, EventArgs e)
        {

        }

        private void wilBitButton3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_cadastro_de_polos_Load_1(object sender, EventArgs e)
        {
            iniciar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionar.BackColor = Color.Blue;
            btnRemover.BackColor = Color.Red;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            btnRemover.BackColor = Color.Blue;
            btnAdicionar.BackColor = Color.Red;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            operacaoPolos();
            MessageBox.Show("Operação realizada com sucesso!!");
        }
    }
}

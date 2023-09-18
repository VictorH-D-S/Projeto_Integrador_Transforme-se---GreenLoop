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

        void limpaCampo()
        {
            txtEmail.Texts = "";
            txtEndereco.Texts = "";
            txtNome.Texts = "";
            txtSenha.Texts = "";
            txtEnderecoGoogleMaps.Texts = "";
            txtNome.Focus();
        }

        void iniciar()
        {
            btnAdicionar.BackColor = Color.Blue;
            btnRemover.BackColor = Color.Red;
            pnlResponsivo_CadastroPollos.Location = new Point((this.ClientSize.Width - pnlResponsivo_CadastroPollos.Width) / 2, (this.ClientSize.Height - pnlResponsivo_CadastroPollos.Height - 100) / 2);
            this.WindowState = FormWindowState.Maximized;
        }

        public void operacaoPolos()
        {
            string nome = txtNome.Texts;
            string endereco = txtEndereco.Texts;
            string email = txtEmail.Texts;
            string senha = txtSenha.Texts;
            string googlemaps = txtEnderecoGoogleMaps.Texts;

            Polos polos = new Polos(nome, email, senha, endereco, googlemaps);

            if (btnAdicionar.BackColor == Color.Blue)
            {
                polos.inserePolo();
            }
            if (btnRemover.BackColor == Color.Blue)
            {
                polos.removePolo();
            }
        }

        void verificaCampo()
        {
            bool camposVazios = false;

            if (string.IsNullOrEmpty(txtNome.Texts))
            {
                camposVazios = true;
            }

            if (string.IsNullOrEmpty(txtEndereco.Texts))
            {
                camposVazios = true;
            }

            if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                camposVazios = true;
            }

            if (string.IsNullOrEmpty(txtSenha.Texts))
            {
                camposVazios = true;
            }

            if (camposVazios)
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Conexao.EmailExisteNaTabelaPolos(txtEmail.Texts))
            {
                if (btnAdicionar.BackColor == Color.Blue)
                {
                    MessageBox.Show("O email já está em uso. Escolha outro email.", "Email Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Texts = "";
                    txtEmail.Focus();
                    return;

                }
            }

            if (Conexao.EmailExisteNaTabelaPolos(txtEmail.Texts))
            {
                if (btnRemover.BackColor == Color.Blue)
                {
                    MessageBox.Show("Polo de Reciclagem Removido.");
                    operacaoPolos();
                    limpaCampo();
                    return;
                }
            }

            if (Conexao.EmailExisteNaTabela(txtEmail.Texts) == false)
            {
                if (btnAdicionar.BackColor == Color.Blue)
                {
                    MessageBox.Show("Polo de Reciclagem Adicionado.");
                    operacaoPolos();
                    limpaCampo();
                    return;
                }
            }

            MessageBox.Show("Ocorreu um erro :(", "Falha na operação");
            limpaCampo();
            return;
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
            verificaCampo();
        }

        private void txt_ponto_de_coleta__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostraSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = false;
            btnEscondeSenha.Visible = true;
            btnMostraSenha.Visible = false;
        }

        private void btnEscondeSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = true;
            btnEscondeSenha.Visible = false;
            btnMostraSenha.Visible = true;
        }
    }
}

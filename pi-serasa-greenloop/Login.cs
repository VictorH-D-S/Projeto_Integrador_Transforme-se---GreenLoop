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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void adicionarUsuario()
        {
            string nome = txtCadastroNome.Texts;
            string senha = txtCadastroSenha.Texts;
            string cpf = txtCadastroCPF.Texts;
            string email = txtCadastroEmail.Texts;
            string idade = txtIdade.Texts;

            Pessoas pessoas = new Pessoas(nome, idade, email, senha, cpf);

            pessoas.adicionarUsuario();

        }

        void verificaCampoCadastro()
        {
            bool camposVazios = false;

            switch (txtCadastroNome.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }

            switch (txtCadastroSenha.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }

            switch (txtCadastroCPF.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }

            switch (txtCadastroEmail.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }

            switch (txtIdade.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }


            if (camposVazios)
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                adicionarUsuario();
                MessageBox.Show("Usuario Cadastrado!");
            }

        }

        void login()
        {
            btnLoginn.BackColor = Color.Black;
            btnCadastroo.BackColor = Color.White;

            btnLoginn.ForeColor = Color.White;
            btnCadastroo.ForeColor = Color.Black;

            wilBitPanel2.Visible = false;
            wilBitPanel1.Visible = true;
        }

        void cadastro()
        {
            btnCadastroo.BackColor = Color.Black;
            btnLoginn.BackColor = Color.White;

            btnCadastroo.ForeColor = Color.White;
            btnLoginn.ForeColor = Color.Black;

            wilBitPanel1.Visible = false;
            wilBitPanel2.Visible = true;
        }

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //CADASTRO

        /*
        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            adicionarUsuario();
            MessageBox.Show("Usuario Cadastrado!!!!");
        }
        */

        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
            int centerY = (this.ClientSize.Height - wilBitPanel1.Height) / 2;
            wilBitPanel1.Location = new Point(centerX, centerY);
            wilBitPanel2.Location = new Point(centerX + wilBitPanel1.Width, centerY);
        }

        private void txtCadastroNome__TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
            int centerY = (this.ClientSize.Height - wilBitPanel1.Height) / 2;
            wilBitPanel1.Location = new Point(centerX, centerY);
            wilBitPanel2.Location = new Point(centerX + wilBitPanel1.Width, centerY);

            login();
        }

        private void wilBitButton1_Click_1(object sender, EventArgs e)
        {   
            verificaCampoCadastro();
        }

        private void btnLoginn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnCadastroo_Click(object sender, EventArgs e)
        {
 
            cadastro();
        }
    }
}

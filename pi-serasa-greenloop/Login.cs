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

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //CADASTRO
        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            adicionarUsuario();
            MessageBox.Show("Usuario Cadastrado!!!!");
        }

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
    }
}

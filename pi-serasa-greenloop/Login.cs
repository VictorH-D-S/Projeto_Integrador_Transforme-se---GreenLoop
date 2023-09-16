using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string idade = dateTimePicker1.Text.ToString();
            Pessoas pessoas = new Pessoas(nome, idade, email, senha, cpf, 0, 0);
            pessoas.adicionarUsuario();
        }
        void VerificaCamposCadastro()
        {
            string nome = txtCadastroNome.Texts.Trim();
            string senha = txtCadastroSenha.Texts;
            string cpf = txtCadastroCPF.Texts;
            string email = txtCadastroEmail.Texts.Trim();
            lblVerifiqueNome.Visible = lblVerifiqueSenha.Visible = lblVerifiqueCPF.Visible = lblVerifiqueEmail.Visible = lblVerifiqueData.Visible = lblMensagemErro.Visible = false; ;

            bool camposVazios = string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(email);

            if (camposVazios)
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ----------------------- Verificações de CPF --------------------------
            if (!cpf.All(char.IsDigit) || cpf.Length != 11 || Conexao.CPFExisteNaTabela(cpf))
            {
                lblVerifiqueCPF.Visible = true;
                txtCadastroCPF.BorderColor = Color.Blue;
                return;
            }

            // ----------------------- Verificações de E-mail --------------------------
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase) || email.Length > 255 || Conexao.EmailExisteNaTabela(email))
            {
                lblVerifiqueEmail.Visible = true;
                txtCadastroEmail.BorderColor = Color.Blue;
                return;
            }

            // ----------------------- Verificações de Nome --------------------------
            if (!Regex.IsMatch(nome, @"^[a-zA-Z0-9\s]+$") || nome.Length > 45 || nome.Length < 3)
            {
                lblVerifiqueNome.Visible = true;
                txtCadastroNome.BorderColor = Color.Blue;
                return;
            }

            // ----------------------- Verificações de Data --------------------------
            DateTime dataNascimento;
            if (!DateTime.TryParse(dateTimePicker1.Text, out dataNascimento) || dataNascimento > DateTime.Now.AddYears(-16) || dataNascimento < DateTime.Now.AddYears(-99))
            {
                lblVerifiqueData.Visible = true;
                return;
            }

            // ----------------------- Verificações de Senha --------------------------
            if (senha.Length < 8 || senha.Length > 16)
            {
                lblVerifiqueSenha.Visible = true;
                txtCadastroSenha.BorderColor = Color.Blue;
                return;
            }

            // ----------------------- FIM DAS VERIFICAÇÕES --------------------------

            txtCadastroSenha.BorderColor = Color.Green;
            txtCadastroEmail.BorderColor = Color.Green;
            txtCadastroCPF.BorderColor = Color.Green;
            txtCadastroNome.BorderColor = Color.Green;
            adicionarUsuario();
            MessageBox.Show("Usuário Cadastrado!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login();
            carregaForm(new Login());
        }

        void verificaCampoLogin()
        {
            bool camposVazios = false;

            switch (txtLoginEmail.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }

            switch (txtLoginSenha.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
            }

            if (camposVazios)
            {
                lblMensagemErro.Visible = true;
                return;
            }

            if (!camposVazios)
            {
                string email = txtLoginEmail.Texts;
                string senha = txtLoginSenha.Texts;

                Pessoas pessoas = new Pessoas();
                pessoas = pessoas.login(email, senha);

                if (pessoas == null)
                {
                    lblMensagemErro.Visible = true;
                }
                else
                {
                    if (pessoas.adm == 1)
                    {
                        lblMensagemErro.Visible = false;
                        MessageBox.Show("Login realizado como Admin");
                        carregaForm(new tela_Admir());
                    }
                    else
                    {
                        lblMensagemErro.Visible = false;
                        MessageBox.Show("Login realizado com sucesso");
                        Program.pessoa = pessoas;
                        carregaForm(new Principal());
                        Form1.Voltar.Enabled = true;
                    }
                }
            }

            if (!camposVazios && checkBox1.Checked)
            {
                string email = txtLoginEmail.Texts;
                string senha = txtLoginSenha.Texts;

                Polos polos = new Polos();
                polos = polos.logarPolos(email, senha);

                if (polos == null)
                {
                    lblMensagemErro.Visible = true;
                    return;
                }
                else
                {
                    lblMensagemErro.Visible = false;
                    MessageBox.Show("Login realizado como Polo de Reciclagem");
                    carregaForm(new DarPontos());
                }
            }
        }
        void login()
        {
            btnLoginn.BackColor = Color.Lime;
            btnCadastroo.BackColor = Color.Gray;

            btnLoginn.ForeColor = Color.Black;
            btnCadastroo.ForeColor = Color.White;

            wilBitPanel2.Visible = false;
            wilBitPanel1.Visible = true;

            int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
            int centerY = (this.ClientSize.Height - wilBitPanel1.Height - 115) / 2;

            int centerXx = (this.ClientSize.Width + 666 + 30) / 2;
            int centerYy = (this.ClientSize.Height - wilBitPanel2.Height - 115) / 2;
        }


        void cadastro()
        {
            btnCadastroo.BackColor = Color.Lime;
            btnLoginn.BackColor = Color.Gray;

            btnCadastroo.ForeColor = Color.Black;
            btnLoginn.ForeColor = Color.White;

            wilBitPanel1.Visible = false;
            wilBitPanel2.Visible = true;

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

        private void Login_Load(object sender, EventArgs e)
        {
            int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
            int centerY = (this.ClientSize.Height - wilBitPanel1.Height) / 2;
            wilBitPanel1.Location = new Point(centerX, centerY);
            wilBitPanel2.Location = new Point(centerX + wilBitPanel1.Width, centerY);
        }

        private void txtCadastroSenha__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginn_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void btnCadastroo_Click_1(object sender, EventArgs e)
        {
            cadastro();
        }

        private void Login_Load_2(object sender, EventArgs e)
        {
            int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
            int centerY = (this.ClientSize.Height - wilBitPanel1.Height) / 2;
            wilBitPanel1.Location = new Point(centerX, centerY);
            wilBitPanel2.Location = new Point(centerX + wilBitPanel1.Width, centerY);
            WindowState = FormWindowState.Maximized;
            wilBitPanel1.Location = new Point((ClientSize.Width - wilBitPanel1.Width) / 2, (ClientSize.Height - wilBitPanel1.Height) / 2);
            wilBitPanel2.Location = new Point((ClientSize.Width - wilBitPanel2.Width) / 2, (ClientSize.Height - wilBitPanel2.Height) / 2);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            Form1.Voltar.Enabled = false;
            txtCadastroNome.TabIndex = 0;
            dateTimePicker1.TabIndex = 1;
            txtCadastroEmail.TabIndex = 2;
            txtCadastroCPF.TabIndex = 3;
            txtCadastroSenha.TabIndex = 4;
            login();
        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            VerificaCamposCadastro();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            verificaCampoLogin();
            //Já está sendo feito o login caso todos os requisitos sejam alcançados, não adicionar a função que realiza loin novamente (caso seja adicionado, terão que passar 5 noites com o isaque)
        }

        private void wilBitPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Cadastro_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnCadastro_Login_Click(object sender, EventArgs e)
        {
            cadastro();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginEmail__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginSenha__TextChanged(object sender, EventArgs e)
        {
        }

        private void wilBitPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void wilBitPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtCadastroNome__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {
            txtCadastroSenha.PasswordChar = false;
            btnEsconderSenhaCadastro.Visible = true;
            btnVisualizarSenha.Visible = false;
        }

        private void btnEsconderSenhaCadastro_Click(object sender, EventArgs e)
        {
            txtCadastroSenha.PasswordChar = true;
            btnVisualizarSenha.Visible = true;
            btnEsconderSenhaCadastro.Visible = false;
        }

        private void btnVisualizarSenhaLogin_Click(object sender, EventArgs e)
        {
            txtLoginSenha.PasswordChar = false;
            btnEsconderSenhaLogin.Visible = true;
            btnVisualizarSenhaLogin.Visible = false;
        }

        private void btnEsconderSenhaLogin_Click(object sender, EventArgs e)
        {
            txtLoginSenha.PasswordChar = true;
            btnVisualizarSenhaLogin.Visible = true;
            btnEsconderSenhaLogin.Visible = false;
        }
    }
}

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
            string nome = txtCadastroNome.Text;
            string senha = txtCadastroSenha.Text;
            string cpf = txtCadastroCPF.Text;
            string email = txtCadastroEmail.Text;
            string idade = dateTimePicker1.Text.ToString();

            // Recupere o valor de pontos da fonte de dados
            int pontos = Conexao.RecuperarPontuacaoAtual(cpf);

            Pessoas pessoas = new Pessoas(nome, idade, email, senha, cpf, pontos);

            pessoas.adicionarUsuario();
        }
        void VerificaCamposCadastro()
        {
            bool camposVazios = false;

            string nome = txtCadastroNome.Texts.Trim();
            string senha = txtCadastroSenha.Texts;
            string cpf = txtCadastroCPF.Texts;
            string email = txtCadastroEmail.Texts.Trim();

            // Verifica se há campos vazios
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(email))
            {
                camposVazios = true;
            }

            if (camposVazios)
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o CPF contém apenas números
            if (!cpf.All(char.IsDigit))
            {
                MessageBox.Show("O CPF deve conter apenas números.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o CPF tem exatamente 11 dígitos
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email.Length > 45)
            {
                MessageBox.Show("O email deve conter no máximo 32 caracteres.", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o email possui caracteres especiais (exceto na senha)
            if (!string.Equals(email, senha) && !Regex.IsMatch(email, @"^[a-zA-Z0-9._\-+@]+$"))
            {
                MessageBox.Show("O email não é válido. Certifique-se de que ele contenha apenas caracteres permitidos.", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o nome contém apenas letras, dígitos e espaços em branco
            if (!Regex.IsMatch(nome, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("O nome não pode conter caracteres especiais.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nome.Length > 45)
            {
                MessageBox.Show("O nome deve conter no máximo 32 caracteres.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataNascimento;
            if (DateTime.TryParse(dateTimePicker1.Text, out dataNascimento))
            {
                DateTime dataMinima = DateTime.Now.AddYears(-16); // 16 anos atrás a partir da data atual
                DateTime dataMaxima = DateTime.Now.AddYears(-99); // 99 anos atrás a partir da data atual

                if (dataNascimento > dataMinima)
                {
                    MessageBox.Show("Você deve ter pelo menos 16 anos para se cadastrar.", "Idade Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (dataNascimento < dataMaxima)
                {
                    MessageBox.Show("Você deve ter no máximo 99 anos para se cadastrar.", "Idade Excedida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Data de nascimento inválida.", "Data de Nascimento Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Conexao.EmailExisteNaTabela(txtCadastroEmail.Texts))
            {
                    MessageBox.Show("E-mail em uso.");
                    return;
            }

            if (Conexao.CPFExisteNaTabela(cpf))
            {
                MessageBox.Show("CPF em uso.");
                return;
            }


            adicionarUsuario();
            MessageBox.Show("Usuário Cadastrado!");
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

            if (camposVazios == false && checkBox1.Checked == false)
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
                    MessageBox.Show("Login realizado com sucesso");
                    Program.pessoa = pessoas;
                    carregaForm(new Principal());
                    Form1.Voltar.Enabled = true;
                }
            }

            if (camposVazios == false && checkBox1.Checked == true)
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
                    MessageBox.Show("Polo encontrado");
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

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

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
            VerificaCamposCadastro();
            carregaForm(new Principal());
        }

        private void btnLoginn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnCadastroo_Click(object sender, EventArgs e)
        {
            cadastro();
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

        private void wilBitDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
    }
}

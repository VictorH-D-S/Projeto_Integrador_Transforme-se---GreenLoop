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

			Pessoas pessoas = new Pessoas( nome, idade, email, senha, cpf);

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
			btnLoginn.BackColor = Color.Lime;
			btnCadastroo.BackColor = Color.Gray;

			btnLoginn.ForeColor = Color.Black;
			btnCadastroo.ForeColor = Color.White;

			wilBitPanel2.Visible = false;
			wilBitPanel1.Visible = true;

			int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
			int centerY = (this.ClientSize.Height - wilBitPanel1.Height - 115) / 2;
			btnLoginn.Location = new Point(centerX, centerY);

			int centerXx = (this.ClientSize.Width + 666 + 30) / 2;
			int centerYy = (this.ClientSize.Height - wilBitPanel2.Height - 115) / 2;
			btnCadastroo.Location = new Point(centerXx, centerYy);
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

			login();
		}

		private void wilBitButton1_Click(object sender, EventArgs e)
		{
			verificaCampoCadastro();
			adicionarUsuario();
			carregaForm(new Principal());
			Form1.btnVoltar.Visible = true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string email = txtLoginEmail.Texts;
			string senha = txtLoginSenha.Texts;

			Pessoas pessoas = new Pessoas();
			pessoas = pessoas.login(email, senha);
			if (pessoas == null)
			{
				MessageBox.Show("Usuário ou senha incorreto");
			}
			else
			{
				MessageBox.Show("Usuário encontrado");
			}

			carregaForm(new Principal());
		}
	}
}

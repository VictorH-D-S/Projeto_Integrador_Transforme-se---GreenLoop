using MySql.Data.MySqlClient;
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
			Pessoas pessoa = new Pessoas();

			string query = $"SELECT nome FROM pessoas WHERE cpf = '{pessoa.cpf}';";
			Conexao.executaQuery(query);

			/*MySqlConnection conexao = new MySqlConnection();
			conexao.ConnectionString = ("server=localhost; user id=root; pwd=root ;database=semi");
			conexao.Open();
			MySqlCommand command = new MySqlCommand();
			command.Connection = conexao;
			command.CommandText = $"SELECT nome FROM pessoas WHERE cpf = '{cpf}';";
			string valor = (string)command.ExecuteScalar();
			lblNome.Text = valor; */

			/*string nome = "Socorroo Coringa";
			string cpf = "777777";
			string email = "PumpedUpKicks@gmail.com";

			lblNome.Text = nome;
			lblEmail.Text = email;
			lblCpf.Text = cpf;
			*/
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Perfil_Load(object sender, EventArgs e)
		{

			atualizaInterface();
		}

		private void pnlResponsivo_Perfil_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnExcluirConta_Usuário_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Troquem de sexo. Pênis Pênis.");
		}
	}
}

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
            /*const string host = "Localhost", banco = "bd_greenloop", usuario = "root", senha = "",
			  dadosConexao = $"Server={host};Database={banco};Uid={usuario};PwD={senha};";

		    MySqlConnection conexao = new MySqlConnection(dadosConexao);

			Pessoas pessoa = new Pessoas();

			string query = $"SELECT nome FROM pessoas WHERE cpf = '{pessoa.cpf}';";
			Conexao.executaQuery(query);
			MySqlCommand cmd = new MySqlCommand(query, pessoa.conexao());
			MySqlDataReader reader;

			conexao.Open(); */


            Pessoas pessoa = new Pessoas();

            const string host = "Localhost", banco = "bd_greenloop", usuario = "root", senha = "",
            dadosConexao = $"Server={host};Database={banco};Uid={usuario};PwD={senha};";

            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conexao;
            command.CommandText = $"SELECT nome FROM pessoas WHERE cpf = '{pessoa.cpf}';";
            string valor = (string)command.ExecuteScalar();
            lblNome.Text = valor;

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

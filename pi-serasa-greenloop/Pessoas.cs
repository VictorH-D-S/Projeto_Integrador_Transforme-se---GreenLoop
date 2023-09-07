using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Pessoas
    {
        public int Id;
        public string nome;
        public string idade;
        public string email;
        public string senha;
        public string cpf;

        public Pessoas(string nome, string idade, string email, string senha, string cpf) 
        {
            
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.senha = senha;
            this.cpf = cpf; 
        }
        public Pessoas() 
        {

        }

        public void adicionarUsuario()
        {
            string query = $"INSERT INTO pessoas(nome, idade, email, senha, cpf) VALUES ('{nome}', '{idade}', '{email}', '{senha}', {cpf})";
            Conexao.executaQuery(query);
        }

        public Pessoas login(string email, string senha)
        {
			string query = $"SELECT * FROM pessoas WHERE email = '{email}' AND senha = '{senha}'";

            DataTable resultados = Conexao.executaQuery(query);
            if(resultados.Rows.Count == 0)
            {
                return null;
            }

            Pessoas pessoa = carregaDados(resultados.Rows[0]);
            return pessoa;
		}

        private Pessoas carregaDados(DataRow row)
        {
            
			string nome = row["id"].ToString();
            string idade = row["idade"].ToString();
            string email = row["email"].ToString();
			string senha = row["senha"].ToString();
			string cpf = row["cpf"].ToString();

            Pessoas pessoas = new Pessoas(nome, idade, email, senha, cpf);
            return pessoas;
		}
    }
}

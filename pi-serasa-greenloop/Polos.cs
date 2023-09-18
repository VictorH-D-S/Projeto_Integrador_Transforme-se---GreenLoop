using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Polos
    {
        string nome, email, senha, endereco, googlemaps;

        public Polos(string nome, string email, string senha, string endereco, string googlemaps)
        {
            this.nome = nome; this.email = email; this.senha = senha; this.endereco = endereco; this.googlemaps = googlemaps;
        }

        public Polos() 
        {
            
        }

        private Polos carregaDados(DataRow row)
        {
            string nome = row["id"].ToString();
            string email = row["email"].ToString();
            string senha = row["senha"].ToString();
            string endereco = row["endereco"].ToString();

            Polos polos = new Polos(nome, email, senha, endereco, googlemaps);
            return polos;
        }

        public Polos logarPolos(string email, string senha)
        {
            string query = $"SELECT * FROM polos WHERE email = '{email}' AND senha = '{senha}'";

            DataTable resultados = Conexao.executaQuery(query);
            if (resultados.Rows.Count == 0)
            {
                return null;
            }

            Polos polos = carregaDados(resultados.Rows[0]);
            return polos;
        }

        public void inserePolo()
        {
            string query = $"INSERT INTO `polos`(`nome`, `email`, `senha`, `endereco`, `googlemaps`) VALUES ('{nome}','{email}','{senha}','{endereco}','{googlemaps}');";
            Conexao.executaQuery(query);
        }

        public void removePolo()
        {
            string query = $"DELETE FROM polos WHERE email = '{email}';";
            Conexao.executaQuery(query);
        }

        public void chamarPontos(string cpf)
        {
            string query = $"SELECT pontos FROM pessoas WHERE cpf = '{cpf}';";
            Conexao.executaQuery(query);
        }

        public void darPontos(string cpf, int pontos)
        {
            string query = $"SET pontos = {pontos} WHERE cpf = '{cpf}';";
            Conexao.executaQuery(query);
        }

    }
}

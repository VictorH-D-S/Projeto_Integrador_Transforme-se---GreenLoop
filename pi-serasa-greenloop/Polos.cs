using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Polos
    {
        string nome, email, senha, endereco;

        public Polos(string nome, string email, string senha, string endereco)
        {
            this.nome = nome; this.email = email; this.senha = senha; this.endereco = endereco;
        }

        public Polos() 
        {
            
        }

        public void inserePolo()
        {
            string query = $"INSERT INTO polos(nome, email, senha, endereco) VALUES ('{nome}', '{email}', '{senha}', '{endereco}');";
            Conexao.executaQuery(query);
        }

        public void removePolo()
        {
            string query = $"DELETE FROM polos WHERE email = '{email}';";
            Conexao.executaQuery(query);
        }

    }
}

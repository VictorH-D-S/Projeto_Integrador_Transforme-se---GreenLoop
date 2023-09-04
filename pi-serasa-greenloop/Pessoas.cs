using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Pessoas
    {
        string nome;
        int idade;
        string email;
        string senha;
        string cpf;

        public Pessoas(string nome, int idade, string email, string senha, string cpf) 
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
            string query = $"INSERT INTO pessoas(nome, idade, email, senha, cpf) VALUES ('{nome}', {idade}, '{email}', '{senha}', {cpf})";
            Conexao.executaQuery(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Premios
    {

        string premio, nome, descricao;
        int valor;
        

        public Premios(string premio, string nome, string descricao, int valor)
        {
            this.premio = premio;
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        }   

        public Premios()
        {

        }

        public void adicionarPremios()
        {
            try
            {
                string query = $"INSERT INTO premios (codigo, nome, descricao, valor) VALUES ('{premio}', '{nome}', '{descricao}', '{valor}')";
                Conexao.executaQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

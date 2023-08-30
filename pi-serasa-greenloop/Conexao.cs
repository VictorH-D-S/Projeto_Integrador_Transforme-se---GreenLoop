using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Conexao
    {
        const string host = "Localhost", banco = "08_listas_tarefas", usuario = "root", senha = "",
             dadosConexao = $"Server={host};Database={banco};Uid={usuario};PwD={senha};";

        static MySqlConnection conexao = new MySqlConnection(dadosConexao);

        public static DataTable executaQuery(string query)
        {

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader dados = comando.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(dados);
                return tabela;
            }
            catch (Exception erro)
            {
                Console.WriteLine("BAH PIÁ DEU ERRO TCHÊ");
                Console.WriteLine(erro.Message);
                return null;
                throw;
            }
            finally { conexao.Close(); }
        }
    }
}

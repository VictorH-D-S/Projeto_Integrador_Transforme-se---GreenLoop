using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pi_serasa_greenloop
{
    internal class Registro
    {
        string historico_reclicagem, cpf;
        int pontos;
        
        public Registro()
        {

        }

        public Registro(string historico_reclicagem,string cpf)
        {
            this.historico_reclicagem = historico_reclicagem; this.cpf = cpf;
        }

        void insereHistorico()
        {
            string query = $"INSERT INTO registros(historico_reciclagem, cpf) VALUES ('{historico_reclicagem}', {cpf};)";
            Conexao.executaQuery(query);
        }

    }
}

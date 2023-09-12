using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Premios
    {

        string premio;

        public Premios(string premio)
        {
            this.premio = premio;
        }   

        public Premios()
        {

        }

        public void adicionarPremios()
        {
            string query = $"INSERT INTO premios(premios) VALUES ('{premio}');";
            Conexao.executaQuery(query);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_greenloop
{
    internal class Premios
    {

        string premios;
        bool resgatado = false;

        public Premios(string premios, bool resgatado)
        {
            this.premios = premios;
            this.resgatado = resgatado;
        }   

        public Premios()
        {

        }


    }
}

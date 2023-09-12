using System;
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
    public partial class Cadastrar_Premios : Form
    {
        public Cadastrar_Premios()
        {
            InitializeComponent();
        }

        void cadastrarPremios()
        {
            string premio = textBoxPremios.Texts;

            Premios premios = new Premios(premio);
            premios.adicionarPremios();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cadastrarPremios();
            MessageBox.Show("Premio cadastrado com sucesso!!");
        }
    }
}

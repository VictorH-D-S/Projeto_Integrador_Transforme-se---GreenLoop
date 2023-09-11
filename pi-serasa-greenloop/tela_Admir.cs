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
    public partial class tela_Admir : Form
    {
        public tela_Admir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPolos_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void tela_Admir_Load(object sender, EventArgs e)
        {
            pnlResponsivo_TelaAdemir.Location = new Point((this.ClientSize.Width - pnlResponsivo_TelaAdemir.Width) / 2, (this.ClientSize.Height - pnlResponsivo_TelaAdemir.Height - 100) / 2);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

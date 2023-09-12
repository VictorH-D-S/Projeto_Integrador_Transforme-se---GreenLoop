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
    public partial class recompensas : Form
    {
        public recompensas()
        {
            InitializeComponent();
        }

        private void recompensas_Load(object sender, EventArgs e)
        {
            painelConteudo.Location = new Point((this.ClientSize.Width - painelConteudo.Width) / 2, (this.ClientSize.Height - painelConteudo.Height + 140) / 2);
            this.WindowState = FormWindowState.Maximized;
            
            
            pnlMenuCima.Location = new Point(0, 0);

        }

        private void wilBitProgressBar21_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenuCima_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recompensas_Load_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            painelConteudo.Location = new Point((this.ClientSize.Width - painelConteudo.Width) / 2, (this.ClientSize.Height - painelConteudo.Height + 140) / 2);
            this.WindowState = FormWindowState.Maximized;


            pnlMenuCima.Location = new Point(0, 0);
            form.responsivo();
        }
    }
}

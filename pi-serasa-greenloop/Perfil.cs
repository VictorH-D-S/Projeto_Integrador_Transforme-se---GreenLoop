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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        void atualizaInterface ()
        {
           // wilBitPanel1.Location = new Point(wilBitPanel1.Width / 2 - ClientSize.Width/2, wilBitPanel1.Height / 2 - ClientSize.Height/2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            atualizaInterface();
        }
    }
}

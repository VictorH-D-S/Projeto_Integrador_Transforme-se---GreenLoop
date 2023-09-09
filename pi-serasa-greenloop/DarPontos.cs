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
    public partial class DarPontos : Form
    {
        public DarPontos()
        {
            InitializeComponent();
        }

        private void PainelResponsivo_DarPontos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DarPontos_Load(object sender, EventArgs e)
        {
            PainelResponsivo_DarPontos.Location = new Point((this.Width - PainelResponsivo_DarPontos.Width) / 2, (this.Height - PainelResponsivo_DarPontos.Height) / 2);
        }
    }
}

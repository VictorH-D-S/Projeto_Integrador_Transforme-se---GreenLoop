using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace pi_serasa_greenloop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void renderizaInterface()
        {
            int menuEsquerdo_Largura = 200, menuEsquerdo_Altura = wilBitPanel1.Height;
            int menuCima_Largura = wilBitPanel1.Width, menuCima_Altura = 200;


            WindowState = FormWindowState.Maximized;

            //Painel no meio da tela

            //Configuração menu esquerdo

            wilBitPanel1.Location = new Point(menuEsquerdo_Largura / 4 + ClientSize.Width / 4 - wilBitPanel1.Size.Width / 4, ClientSize.Height / 4 - wilBitPanel1.Size.Height / 4);

        }

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Login_Load(object sender, EventArgs e)
        {
            int centerX = (this.ClientSize.Width - wilBitPanel1.Width - wilBitPanel2.Width) / 2;
            int centerY = (this.ClientSize.Height - wilBitPanel1.Height) / 2;
            wilBitPanel1.Location = new Point(centerX, centerY);
            wilBitPanel2.Location = new Point(centerX + wilBitPanel1.Width, centerY);
        }
    }
}

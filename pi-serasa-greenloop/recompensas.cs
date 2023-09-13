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
            AtualizarPosicionamento();

            // Registre o evento SizeChanged para ajustar o layout quando o tamanho da janela for alterado.
            this.SizeChanged += new EventHandler(recompensas_SizeChanged);
        }

        private void AtualizarPosicionamento()
        {
            int centerX = (this.ClientSize.Width - painelConteudo.Width) / 2;
            int centerY = (this.ClientSize.Height - painelConteudo.Height + 140) / 2;

            // Posicione o painel de conteúdo no centro da janela
            painelConteudo.Location = new Point(centerX, centerY);

            // Centralize o painel de menu superior no topo da janela horizontalmente
            int menuTopX = (this.ClientSize.Width - pnlMenuCima.Width) / 2;
            pnlMenuCima.Location = new Point(menuTopX, 0);
        }

        private void recompensas_SizeChanged(object sender, EventArgs e)
        {
            // Quando o tamanho da janela for alterado, atualize o posicionamento.
            AtualizarPosicionamento();
        }

        private void lblPontos_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

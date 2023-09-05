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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Label lblPrincipal = new Label();
        

        public void carregaForm(Form form)
        {
            form.TopLevel = false;
            painel.Controls.Clear();
            painel.Controls.Add(form);
            form.Size = painel.Size;
            form.Location = new Point(painel.Width - form.Width, painel.Height - form.Height);
            form.Show();

        }

        public void btnRecompensas_Click(object sender, EventArgs e)
        {
            

            recompensas recompensas = new recompensas();
            recompensas.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPontosColeta_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAprender_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRecompensas_Click_1(object sender, EventArgs e)
        {
            
            carregaForm(new recompensas());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

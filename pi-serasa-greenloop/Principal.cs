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
            painel.Location = new Point((this.ClientSize.Width - painel.Width) / 2, (this.ClientSize.Height - painel.Height) / 2);
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
            carregaForm(new Perfil());
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

        private void btnReciclagem_Click(object sender, EventArgs e)
        {

        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitRoundedPictureBox22_Click(object sender, EventArgs e)
        {
            carregaForm(new Perfil());
        }

        private void wilBitRoundedPictureBox21_Click(object sender, EventArgs e)
        {
            carregaForm(new recompensas());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void btnPontos_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
        }

        private void btnPontos_Click_1(object sender, EventArgs e)
        {
            carregaForm(new Local());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            carregaForm(new Local());
        }

        private void btnRecompensas_Click_2(object sender, EventArgs e)
        {
            carregaForm(new recompensas());
        }
    }
}

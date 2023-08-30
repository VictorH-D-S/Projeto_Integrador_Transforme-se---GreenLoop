namespace pi_serasa_greenloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void carregaForm(Form form)
        {
            form.TopLevel = false;
            painel.Controls.Clear();
            painel.Controls.Add(form);
            form.Location = new Point(painel.Width / 2 - form.Width / 2, painel.Height / 2 - form.Height / 2);
            form.Show();
        }

        private void wilBitButton21_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  PERFIL  |";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton2_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  HOME  |";
        }

        private void btnRecompensas_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  RECOMPENSAS  |";
            carregaForm(new recompensas());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  APRENDER  |";
        }

        private void btnPontosColeta_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  PONTOS DE COLETA  |";
        }
    }
}
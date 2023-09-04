namespace pi_serasa_greenloop
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        

        public void carregaForm(Form form)
        {
            form.TopLevel = false;
            painel.Controls.Clear();
            painel.Controls.Add(form);
            form.Size = painel.Size;
            form.Location = new Point(painel.Width - form.Width , painel.Height - form.Height);
            form.Show();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnRecompensas_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  RECOMPENSAS  |";
           
           
            
        }

        

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           btnVoltar.Visible = true;
            carregaForm(new Principal());
        }

        private void btnRecompensas_Click_1(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  RECOMPENSAS  |";

            carregaForm(new recompensas());
            btnVoltar.Visible = true;
            
        }

        private void btnReciclagem_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  APRENDER  |";
        }

        private void btnPontos_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  PONTOS DE COLETA  |";
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "|  PERFIL  |";
        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            carregaForm(new Principal());

        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
namespace pi_serasa_greenloop
{
    public partial class LoginCadastro : Form
    {

        public LoginCadastro()
        {
            InitializeComponent();
        }
        //funçoes
        void renderizaInterface()
        {
            WindowState = FormWindowState.Maximized;
            painelSuperior.Location = new Point(0, 0);
            painelSuperior.Size = new Size(ClientSize.Width, 100);

            lblLogin.Location = new Point(ClientSize.Width / 2 - lblLogin.Width / 2, 0);

            painelCentral.Location = new Point(ClientSize.Width / 2 - painelCentral.Width / 2, painelSuperior.Height + 20);

            btnLogin.Location = new Point(ClientSize.Width / 2 - btnLogin.Width / 2, 200);

        }

        private void LoginCadastro_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
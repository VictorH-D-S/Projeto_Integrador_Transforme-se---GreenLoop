namespace pi_serasa_greenloop
{
    public partial class Form1 : Form
    {
        void salvar()
        {
            string nome = textNome.Text;
            int idade = int.Parse(textIdade.Text);
            string email = textEmail.Text;
            string senha = textSenha.Text;
            string cpf = textCPF.Text;

            Pessoas teste = new Pessoas(nome, idade, email, senha, cpf);

            teste.adicionarUsuario();
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
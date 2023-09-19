using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;

namespace pi_serasa_greenloop
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public void carregaForm(Form form)
        {
            form.TopLevel = false;
            Form1.painel.Controls.Clear();
            Form1.painel.Controls.Add(form);
            form.Size = Form1.painel.Size;
            form.Location = new Point(Form1.painel.Width - form.Width, Form1.painel.Height - form.Height);
            form.Show();
        }

        private List<string> premiosJaAdicionados = new List<string>(); // Lista para controlar os prêmios já adicionados

        private void CarregarPremiosResgatados()
        {
            // Limpe os painéis existentes em pnlMeusPremios antes de adicionar os novos
            pnlMeusPremios.Controls.Clear();

            // Suponha que você tenha o Usuarioid do usuário logado
            string usuarioId = Program.pessoa.cpf;

            string queryPremiosResgatados = $"SELECT p.codigo, p.nome, p.descricao, p.valor " +
                                             $"FROM premios p " +
                                             $"INNER JOIN historico_resgates h ON p.codigo = h.PremioID " +
                                             $"WHERE h.UsuarioID = '{usuarioId}' AND p.resgatado = 1";

            DataTable premiosResgatados = Conexao.executaQuery(queryPremiosResgatados);

            if (premiosResgatados != null && premiosResgatados.Rows.Count > 0)
            {
                int paineisPorLinha = 2; // Quantidade de painéis por linha
                int paineisNaLinhaAtual = 0; // Contador de painéis na linha atual

                foreach (DataRow row in premiosResgatados.Rows)
                {
                    string codigoPremio = row["codigo"].ToString();

                    // Verifique se o prêmio já foi adicionado
                    if (!premiosJaAdicionados.Contains(codigoPremio))
                    {
                        premiosJaAdicionados.Add(codigoPremio); // Adicione o código do prêmio à lista de prêmios adicionados

                        string nomePremio = row["nome"].ToString();
                        string descricaoPremio = row["descricao"].ToString();
                        int valorPremio = Convert.ToInt32(row["valor"]);

                        // Crie um painel para exibir os detalhes do prêmio
                        Panel painelPremio = new Panel();
                        painelPremio.BorderStyle = BorderStyle.None;
                        painelPremio.Size = new Size(500, 180); // Aumente a altura para acomodar a data de resgate
                        painelPremio.BackColor = Color.Green; // Altere a cor de fundo para os prêmios resgatados
                        painelPremio.Padding = new Padding(10);

                        // Adicione bordas arredondadas ao painel
                        painelPremio.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, painelPremio.Width, painelPremio.Height, 10, 10));

                        // Crie rótulos para exibir os detalhes do prêmio
                        Label lblCodigo = new Label();
                        lblCodigo.Text = $"Código: {codigoPremio}";
                        lblCodigo.Location = new Point(10, 10);
                        lblCodigo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblCodigo.ForeColor = Color.White; // Cor do texto para destacar
                        lblCodigo.AutoSize = true; // Ajuste automático ao tamanho do texto

                        Label lblNome = new Label();
                        lblNome.Text = nomePremio;
                        lblNome.Location = new Point(10, 40);
                        lblNome.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblNome.ForeColor = Color.White;
                        lblNome.AutoSize = true; // Ajuste automático ao tamanho do texto

                        Label lblDescricao = new Label();
                        lblDescricao.Text = descricaoPremio;
                        lblDescricao.Location = new Point(10, 70);
                        lblDescricao.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                        lblDescricao.ForeColor = Color.White;
                        lblDescricao.AutoSize = true; // Ajuste automático ao tamanho do texto

                        // Adicione os rótulos ao painel
                        painelPremio.Controls.Add(lblCodigo);
                        painelPremio.Controls.Add(lblNome);
                        painelPremio.Controls.Add(lblDescricao);

                        // Determine a posição do painel na linha atual
                        int xPosition = (paineisNaLinhaAtual % paineisPorLinha) * (painelPremio.Width + 20);
                        int yPosition = (paineisNaLinhaAtual / paineisPorLinha) * (painelPremio.Height + 20);

                        // Defina a posição do painel
                        painelPremio.Location = new Point(xPosition, yPosition);

                        // Adicione o painel de prêmio ao pnlMeusPremios
                        pnlMeusPremios.Controls.Add(painelPremio);
                        lblNadaAinda.Visible = false;

                        // Atualize o contador de painéis na linha atual
                        paineisNaLinhaAtual++;
                    }
                }
            }
            else
            {
                lblNadaAinda.Visible = true;
            }
        }

        void atualizaInterface()
        {
            int newY = (this.ClientSize.Height - pnlPerfil.Height - 100) / 2;
            pnlPerfil.Location = new Point(pnlPerfil.Location.X, newY);
            this.WindowState = FormWindowState.Maximized;
        }
        void atualizaPerfil()
        {
            lblEmail.Text = Program.pessoa.email;
            lblPontos.Text = Program.pessoa.pontos.ToString();

            // Converter o nome para o formato de título
            string nome = Program.pessoa.nome;
            if (!string.IsNullOrEmpty(nome))
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                nome = textInfo.ToTitleCase(nome.ToLower());
            }

            lblNome.Text = nome;
            lblNasciemnto.Text = Program.pessoa.idade.ToString();
            lblCpf.Text = FormatarCpf(Program.pessoa.cpf);
        }

        string FormatarCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            {
                return "CPF inválido";
            }

            string parte1 = cpf.Substring(0, 9);
            string parte2 = cpf.Substring(9, 2);

            return $"{parte1.Substring(0, 3)}.{parte1.Substring(3, 3)}.{parte1.Substring(6, 3)}-{parte2}";
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load_1(object sender, EventArgs e)
        {
            CarregarPremiosResgatados();
            atualizaPerfil();
            atualizaInterface();
        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblPontos_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirConta_Usuário_Click_1(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            DialogResult result = MessageBox.Show("Deseja sair?", "Sair de sua Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                carregaForm(new Login());
            }
            else
            {
            }
        }

        private void pnlMeusPremios_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

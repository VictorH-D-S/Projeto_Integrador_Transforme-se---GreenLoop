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

        private void PreencherPaineisDePremios()
        {
            // Consulta SQL para recuperar os prêmios da tabela premios
            string query = "SELECT codigo, nome, descricao, valor FROM premios";

            DataTable premios = Conexao.executaQuery(query);

            if (premios != null && premios.Rows.Count > 0)
            {
                foreach (DataRow row in premios.Rows)
                {
                    // Recupere os dados do prêmio a partir da linha atual
                    string premio = row["codigo"].ToString();
                    string nome = row["nome"].ToString();
                    string descricao = row["descricao"].ToString();
                    int valor = Convert.ToInt32(row["valor"]);

                    // Crie um novo painel para o prêmio
                    Panel painelPremio = new Panel();
                    painelPremio.BorderStyle = BorderStyle.FixedSingle;
                    painelPremio.Size = new Size(200, 150); // Ajuste o tamanho conforme necessário
                    painelPremio.BackColor = Color.LightGray; // Escolha uma cor de fundo adequada

                    // Crie rótulos para exibir os detalhes do prêmio dentro do painel
                    Label lblPremio = new Label();
                    lblPremio.Text = premio;
                    lblPremio.Location = new Point(10, 10);

                    Label lblNome = new Label();
                    lblNome.Text = nome;
                    lblNome.Location = new Point(10, 30);

                    Label lblDescricao = new Label();
                    lblDescricao.Text = descricao;
                    lblDescricao.Location = new Point(10, 50);

                    Label lblValor = new Label();
                    lblValor.Text = $"Valor: {valor}";
                    lblValor.Location = new Point(10, 70);

                    // Adicione os rótulos ao painel
                    painelPremio.Controls.Add(lblPremio);
                    painelPremio.Controls.Add(lblNome);
                    painelPremio.Controls.Add(lblDescricao);
                    painelPremio.Controls.Add(lblValor);

                    // Adicione o painel de prêmio ao painel de conteúdo
                    painelConteudo.Controls.Add(painelPremio);
                }
            }
            else
            {
                MessageBox.Show("Não foram encontrados prêmios cadastrados.");
            }
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
            PreencherPaineisDePremios();
            AtualizarPosicionamento();
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

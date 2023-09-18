using System;
using System.Data;
using System.Drawing;
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
            string query = "SELECT codigo, nome, descricao, valor, resgatado FROM premios";

            DataTable premios = Conexao.executaQuery(query);

            if (premios != null && premios.Rows.Count > 0)
            {
                int colunaAtual = 0; // Rastreia a coluna atual
                int maxPaineisPorColuna = 3; // Máximo de painéis por coluna
                int espacamentoHorizontal = 20; // Espaçamento horizontal entre os painéis
                int espacamentoVertical = 20; // Espaçamento vertical entre os painéis

                foreach (DataRow row in premios.Rows)
                {
                    int estadoResgatado = Convert.ToInt32(row["resgatado"]);

                    // Verifique se o prêmio não foi resgatado (estadoResgatado = 0)
                    if (estadoResgatado == 0)
                    {
                        // Recupere os dados do prêmio a partir da linha atual
                        string premio = row["codigo"].ToString();
                        string nome = row["nome"].ToString();
                        string descricao = row["descricao"].ToString();
                        int valor = Convert.ToInt32(row["valor"]);

                        // Crie um novo painel para o prêmio
                        Panel painelPremio = new Panel();
                        painelPremio.BorderStyle = BorderStyle.None; // Remova a borda padrão
                        painelPremio.Size = new Size(300, 180); // Aumente a altura para acomodar o texto
                        painelPremio.BackColor = Color.WhiteSmoke; // Cor de fundo
                        painelPremio.Padding = new Padding(10); // Margem interna

                        // Adicione bordas arredondadas ao painel
                        painelPremio.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, painelPremio.Width, painelPremio.Height, 10, 10));

                        // Crie rótulos para exibir os detalhes do prêmio dentro do painel
                        Label lblNome = new Label();
                        lblNome.Text = nome;
                        lblNome.Location = new Point(10, 40);
                        lblNome.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Defina a fonte e o tamanho
                        lblNome.AutoSize = true; // Ajuste automático ao tamanho do texto

                        Label lblDescricao = new Label();
                        lblDescricao.Text = descricao;
                        lblDescricao.Location = new Point(10, 70);
                        lblDescricao.Font = new Font("Segoe UI", 10); // Defina a fonte e o tamanho
                        lblDescricao.AutoSize = true; // Ajuste automático ao tamanho do texto

                        Label lblValor = new Label();
                        lblValor.Text = $"Valor: {valor}";
                        lblValor.Location = new Point(10, 100);
                        lblValor.Font = new Font("Segoe UI", 10); // Defina a fonte e o tamanho
                        lblValor.AutoSize = true; // Ajuste automático ao tamanho do texto

                        // Crie um botão "Resgatar" estilizado
                        Button btnResgatar = new Button();
                        btnResgatar.Text = "Resgatar";
                        btnResgatar.Location = new Point(painelPremio.Width - 120, 130); // Aumente a largura do botão
                        btnResgatar.Size = new Size(100, 30); // Defina um tamanho apropriado para o botão
                        btnResgatar.BackColor = Color.FromArgb(0, 122, 204); // Cor de fundo
                        btnResgatar.ForeColor = Color.White; // Cor do texto
                        btnResgatar.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Fonte e tamanho do texto
                        btnResgatar.FlatStyle = FlatStyle.Flat; // Estilo de borda plano
                        btnResgatar.FlatAppearance.BorderSize = 0; // Largura da borda
                        btnResgatar.Cursor = Cursors.Hand; // Alterar o cursor ao passar o mouse

                        // Evento de clique do botão de resgate
                        btnResgatar.Click += (sender, e) => ResgatarPremio(premio);

                        // Adicione os rótulos e o botão ao painel
                        painelPremio.Controls.Add(lblNome);
                        painelPremio.Controls.Add(lblDescricao);
                        painelPremio.Controls.Add(lblValor);
                        painelPremio.Controls.Add(btnResgatar);

                        // Adicione o painel de prêmio ao painel de conteúdo
                        painelConteudo.Controls.Add(painelPremio);

                        // Adicione um evento de passar o mouse para fornecer feedback visual
                        painelPremio.MouseEnter += (sender, e) => painelPremio.BackColor = Color.LightGray;
                        painelPremio.MouseLeave += (sender, e) => painelPremio.BackColor = Color.WhiteSmoke;

                        // Atualize a coluna atual ou vá para a próxima coluna
                        colunaAtual = (colunaAtual + 1) % maxPaineisPorColuna;
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foram encontrados prêmios cadastrados.");
            }
        }

        private void ResgatarPremio(string premio)
        {
            // Consulta SQL para recuperar o valor do prêmio
            string queryValor = $"SELECT valor, resgatado FROM premios WHERE codigo = '{premio}'";
            DataTable valorPremio = Conexao.executaQuery(queryValor);

            if (valorPremio != null && valorPremio.Rows.Count > 0)
            {
                int valorDoPremio = Convert.ToInt32(valorPremio.Rows[0]["valor"]);
                bool foiResgatado = Convert.ToBoolean(valorPremio.Rows[0]["resgatado"]);

                if (!foiResgatado)
                {
                    // Consulta SQL para recuperar o saldo atual de pontos do usuário
                    string cpfDoUsuario = Program.pessoa.cpf; // Supondo que você tenha armazenado o CPF do usuário

                    // Consulta SQL para obter o saldo de pontos do usuário com base no CPF
                    string querySaldoPontos = $"SELECT pontos FROM pessoas WHERE cpf = '{cpfDoUsuario}'";
                    DataTable saldoPontos = Conexao.executaQuery(querySaldoPontos);

                    if (saldoPontos != null && saldoPontos.Rows.Count > 0)
                    {
                        int pontosDoUsuario = Convert.ToInt32(saldoPontos.Rows[0]["pontos"]);

                        if (pontosDoUsuario >= valorDoPremio)
                        {
                            // Janela de confirmação
                            DialogResult confirmResult = MessageBox.Show($"Deseja realmente resgatar este prêmio?", "Confirmação de Resgate", MessageBoxButtons.YesNo);

                            if (confirmResult == DialogResult.Yes)
                            {
                                // Atualize a tabela premios para marcar a recompensa como resgatada
                                string queryAtualizarPremio = $"UPDATE premios SET resgatado = 1 WHERE codigo = '{premio}'";
                                Conexao.executaQuery(queryAtualizarPremio);

                                // Atualize o saldo de pontos do usuário diretamente no banco de dados
                                int novoSaldoPontos = pontosDoUsuario - valorDoPremio;
                                string queryAtualizarPontos = $"UPDATE pessoas SET pontos = {novoSaldoPontos} WHERE cpf = '{cpfDoUsuario}'";
                                Conexao.executaQuery(queryAtualizarPontos);

                                // Insira um registro na tabela historico_resgates
                                string queryInserirHistorico = $"INSERT INTO historico_resgates (UsuarioID, PremioID, DataResgate) VALUES ('{cpfDoUsuario}', '{premio}', NOW())";
                                Conexao.executaQuery(queryInserirHistorico);

                                // Atualize os pontos do usuário na aplicação
                                Program.pessoa.pontos = novoSaldoPontos;
                                lblSeusPontos.Text = novoSaldoPontos.ToString();

                                // Mostrar o código do prêmio resgatado
                                MessageBox.Show($"Seu prêmio foi resgatado com sucesso!\nPara consultar seus prêmios resgatados, acesse seu Perfil. Aproveite ;)", "Prêmio Resgatado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Pontos insuficientes para resgatar este prêmio.", "Pontos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar o saldo de pontos do usuário.", "Erro ao Recuperar Pontos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Este prêmio já foi resgatado.", "Prêmio Já Resgatado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar o valor do prêmio.", "Erro ao Recuperar Valor do Prêmio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void recompensas_Load(object sender, EventArgs e)
        {
            painelConteudo.Location = new Point((this.ClientSize.Width - painelConteudo.Width) / 2, (this.ClientSize.Height - painelConteudo.Height + 140) / 2);
            this.WindowState = FormWindowState.Maximized;
            pnlMenuCima.Location = new Point(0, 0);
        }
        private void Centralizas()
        {
            // Calcule a posição horizontal para centralizar o pnlCarregaPolos
            int xPosition = (this.ClientSize.Width - painelConteudo.Width) / 2;

            // Defina a posição do pnlCarregaPolos
            painelConteudo.Location = new Point(xPosition, painelConteudo.Location.Y);
        }
        private void recompensas_Load_1(object sender, EventArgs e)
        {
            Centralizas();
            lblSeusPontos.Text = Program.pessoa.pontos.ToString();
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

        private void lblSeusPontos_Click(object sender, EventArgs e)
        {

        }
    }
}

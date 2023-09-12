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
    public partial class Deletar_usuario : Form
    {
        public Deletar_usuario()
        {
            InitializeComponent();
        }

        private void Deletar_usuario_Load(object sender, EventArgs e)
        {
            PainelResponsivo_DeletarUsuário.Location = new Point((this.Width - PainelResponsivo_DeletarUsuário.Width) / 2, (this.Height - PainelResponsivo_DeletarUsuário.Height) / 2);
        }

        void removeUsuario()
        {
            bool camposVazios = false;

            switch (txtCPF_Ademir.Texts)
            {
                case "":
                    camposVazios = true;
                    break;
                default:
                    // Verifica se o CPF contém apenas números
                    if (!txtCPF_Ademir.Texts.All(char.IsDigit))
                    {
                        MessageBox.Show("O CPF deve conter apenas números.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Verifica se o CPF tem exatamente 11 dígitos
                    if (txtCPF_Ademir.Texts.Length != 11)
                    {
                        MessageBox.Show("O CPF deve conter 11 dígitos.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
            }

            if (camposVazios)
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cpf = txtCPF_Ademir.Texts;
            if (Conexao.CPFExisteNaTabela(cpf))
            {
                MessageBox.Show("O usuário foi removido.", "Usuário Removido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Pessoas pessoas = new Pessoas();
                pessoas.admDeletarUsuario(cpf);
                txtCPF_Ademir.Texts = "";
                txtCPF_Ademir.Focus();
                return;
            }
            else
            {
                MessageBox.Show("O CPF não foi encontrado.", "CPF Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDeletar_usuario_Click(object sender, EventArgs e)
        {
            removeUsuario();
        }
    }
}

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
            string cpf = txtCPF_Ademir.Texts;
            Pessoas pessoas = new Pessoas();
            pessoas.admDeletarUsuario(cpf);
            MessageBox.Show("Usuario deletado com sucesso!!!");
        }

        private void btnDeletar_usuario_Click(object sender, EventArgs e)
        {
            removeUsuario();
        }
    }
}

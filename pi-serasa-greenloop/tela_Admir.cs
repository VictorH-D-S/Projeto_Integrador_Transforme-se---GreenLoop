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
    public partial class tela_Admir : Form
    {
        public tela_Admir()
        {
            InitializeComponent();
        }

        public void carregaForm(Form form)
        {

            form.TopLevel = false;
            Form1.painel.Controls.Clear();
            Form1.painel.Controls.Add(form);
            form.Size = Form1.painel.Size;
            form.Location = new Point(Form1.painel.Width - form.Width, Form1.painel.Height - form.Height);
            form.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            carregaForm(new Tela_cadastro_de_polos());
        }

        private void btnPolos_Click_1(object sender, EventArgs e)
        {
            carregaForm(new Tela_cadastro_de_polos());
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            carregaForm(new Deletar_usuario());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            carregaForm(new Deletar_usuario());
        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            carregaForm(new Cadastrar_Premios());
        }

        private void tela_Admir_Load_1(object sender, EventArgs e)
        {
            pnlResponsivo_TelaAdemir.Location = new Point((this.ClientSize.Width - pnlResponsivo_TelaAdemir.Width) / 2, (this.ClientSize.Height - pnlResponsivo_TelaAdemir.Height - 100) / 2);
            this.WindowState = FormWindowState.Maximized;
            Form1.btnVoltarADM.Visible = true;
            Form1.btnEncerrarADM.Visible = true;
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void carregaForm(Form form)
        {
            form.TopLevel = false;
            painel.Controls.Clear();
            painel.Controls.Add(form);
            form.Size = painel.Size;
            form.Location = new Point(painel.Width - form.Width, painel.Height - form.Height);
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaForm(new Principal());
            
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            painel.Controls.Clear();
            
            carregaForm(new Principal());
        }
    }
}

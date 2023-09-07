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

        void responsivo()
        {
            WindowState = FormWindowState.Maximized;
            wilBitGradientPanel1.Dock = DockStyle.Top;
            btnVoltar.Anchor = AnchorStyles.Left;
            label1.Anchor = AnchorStyles.None;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            btnVoltar.Visible = false;

            painel.Dock = DockStyle.Fill;


           // wilBitGradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //painel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            responsivo();
            carregaForm(new Login());  
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            painel.Controls.Clear();
            
            carregaForm(new Principal());
        }
    }
}

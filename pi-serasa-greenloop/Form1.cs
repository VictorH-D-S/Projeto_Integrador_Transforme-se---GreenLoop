using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace pi_serasa_greenloop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void responsivo()
		{
			//Centraliazdor de painel do governo do amor
			int formLARGURA = this.Width, formALTURA = this.Height, panelLARGURA = panel1.Width, panelALTURA = panel1.Height;
			int centralizaPainel = (formLARGURA - panel1.Width) / 2;
			panel1.Location = new Point(centralizaPainel, 0);

			//Centralizador de label termine minha vida
			int labelLargura = (panel1.Width - label2.Width) / 2;
			int LabelAltura = (panel1.Height - label2.Height) / 2;
			label2.Location = new Point(labelLargura, LabelAltura);

			//Centralizador de painéis do shadow o ouriço(este aqui deixa os painéis responsivos quando carregamos no form1 HAHAHAHAHAHA)
			int formX = (painel.Width - this.Width) / 2;
			int formY = (painel.Height - this.Height) / 2;
			this.Location = new Point(formX, formY);

			WindowState = FormWindowState.Maximized;
			panel1.Dock = DockStyle.Top;
			Voltar.Anchor = AnchorStyles.Left;
			label2.Anchor = AnchorStyles.None;
			label2.TextAlign = ContentAlignment.MiddleCenter;
			Voltar.Visible = true;

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
			//responsivo();
			//carregaForm(new Login());
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			painel.Controls.Clear();

			carregaForm(new Principal());
		}

		private void painel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			responsivo();
			carregaForm(new Principal());
		}

		private void Voltar_Click(object sender, EventArgs e)
		{
			carregaForm(new Principal());
		}

        private void Voltar_Click_1(object sender, EventArgs e)
        {
            carregaForm(new Principal());

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            responsivo();
            carregaForm(new Principal());
        }
    }
}

/*
 * Quero fazer um anúncio ☝️
 * . Shadow o ouriço é um filho da puta do caralho 🗣️
 * , ele mijou na porra da minha esposa 💦, isso mesmo ele pegou a porra do pinto espinhoso dele e mijou na porra da minha esposa 😡
 * e disse que o pau dele era desse tamanho 🤏 e eu disse credo que nojo 🤢, 
 * então estou fazendo um exposed no meu twitter.com ❌, shadow o ouriço tem um pau pequeno do tamanho dessa nós só que muito menor 🥜,
 * e adivinha olha o tamanho do meu pirocão 🍆, isso mesmo bebê 👶, pontas altas 😎, sem pelos 🚫🪶, sem espinhos 🚫🥀, olha só parecem duas bolas e um torpedo ⚽🚀⚽. 
 * Ele fodeu a minha esposa então adivinhe EU VOU FODER A TERRA 👉👌🌎, isso mesmo é isso que você ganha 🎰, meu super laser de mijo 🥒💦. 
 * Exceto que não vou mijar na terra 🚫🌎, eu vou mais longe, EU VOU MIJAR NA LUA 🥒💦🌚. 
 * Você gostou disso lula 🦑? Eu mijei na lua. Faz o L agora 👆.
 * Você tem 23 horas até que os perdigotos de mijo atingam a terra 🕐. Agora saiam da porra da minha frente antes que eu mije em vocês também 🥒💦.
*/


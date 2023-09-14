using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using WebBrowser = System.Windows.Controls.WebBrowser;
using Microsoft.Web.WebView2.Core;

namespace pi_serasa_greenloop
{
	public partial class Site : Form
	{
		public Site()
		{
			InitializeComponent();
		}

		private async void Site_LoadAsync(object sender, EventArgs e)
		{
			await webView.EnsureCoreWebView2Async(null);

			if (webView.CoreWebView2 != null)
			{
				// Defina a URL do site que você deseja exibir
				string url = "https://youtu.be/Whz4s5uOwUM";

				// Carregue a página da web no controle WebView2
				webView.CoreWebView2.Navigate(url);
			}
			else
			{
				// Lide com a situação em que o controle WebView2 não pode ser inicializado
				MessageBox.Show("Não foi possível inicializar o controle WebView2.");
			}
		}

	}

}

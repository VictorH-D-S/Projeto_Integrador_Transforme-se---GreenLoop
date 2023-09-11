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
    public partial class Site : Form
    {
        public Site()
        {
            InitializeComponent();
        }

        private void Site_Load(object sender, EventArgs e)
        {
            string pathToHtmlFile = "C:\\Users\\DELL\\Desktop\\site";
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.AllowWebBrowserDrop = false;
            webBrowser.Navigate(new Uri(pathToHtmlFile));
            //webBrowser.DocumentMode = webBrowser.DocumentMode.EmulateE11;
        }
    }
}

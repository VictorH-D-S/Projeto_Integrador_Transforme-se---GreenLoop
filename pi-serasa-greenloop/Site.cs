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
            string pathToHtmlFile = "C:\\Users\\DELL\\Desktop\\site\\site.html";
            string htmlContent = System.IO.File.ReadAllText(pathToHtmlFile);

            string pathToCssFile = "C:\\Users\\DELL\\Desktop\\site\\style.css";
            string cssContent = System.IO.File.ReadAllText(pathToCssFile);

            string styledHtml = $"<html><head><style>{cssContent}</style></head><body>{htmlContent}</body></html>";
            
            WebBrowser webBrowser1 = new WebBrowser();
        }
    }
}

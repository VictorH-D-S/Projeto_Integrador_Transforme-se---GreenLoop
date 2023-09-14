namespace pi_serasa_greenloop
{
	partial class Site
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			webView = new Microsoft.Web.WebView2.WinForms.WebView2();
			((System.ComponentModel.ISupportInitialize)webView).BeginInit();
			SuspendLayout();
			// 
			// webView
			// 
			webView.AllowExternalDrop = true;
			webView.CreationProperties = null;
			webView.DefaultBackgroundColor = Color.White;
			webView.Location = new Point(-3, 2);
			webView.Name = "webView";
			webView.Size = new Size(1356, 731);
			webView.TabIndex = 0;
			webView.ZoomFactor = 1D;
			// 
			// Site
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(1350, 729);
			Controls.Add(webView);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Site";
			Text = "Form2";
			Load += Site_LoadAsync;
			((System.ComponentModel.ISupportInitialize)webView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Microsoft.Web.WebView2.WinForms.WebView2 webView;
	}
}
namespace pi_serasa_greenloop
{
	partial class Form1
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
		public void InitializeComponent()
		{
			painel = new Panel();
			panel1 = new Panel();
			Voltar = new WiLBiT.WiLBiTRoundedPictureBox2();
			label2 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Voltar).BeginInit();
			SuspendLayout();
			// 
			// painel
			// 
			painel.Anchor = AnchorStyles.None;
			painel.Location = new Point(0, 84);
			painel.Name = "painel";
			painel.Size = new Size(1444, 796);
			painel.TabIndex = 1;
			// 
			// panel1
			// 
			panel1.BackColor = Color.LimeGreen;
			panel1.Controls.Add(Voltar);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.ForeColor = Color.LimeGreen;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1444, 89);
			panel1.TabIndex = 2;
			// 
			// Voltar
			// 
			Voltar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
			Voltar.BorderColor = Color.Lime;
			Voltar.BorderColor2 = Color.SpringGreen;
			Voltar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			Voltar.BorderSize = 2;
			Voltar.GradientAngle = 50F;
			Voltar.Image = Properties.Resources.logo_greenloop;
			Voltar.Location = new Point(71, 3);
			Voltar.Name = "Voltar";
			Voltar.Size = new Size(88, 88);
			Voltar.SizeMode = PictureBoxSizeMode.StretchImage;
			Voltar.TabIndex = 1;
			Voltar.TabStop = false;
			Voltar.Click += Voltar_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(1095, 30);
			label2.Name = "label2";
			label2.Size = new Size(180, 40);
			label2.TabIndex = 0;
			label2.Text = "GreenLoop";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 3, 21);
			ClientSize = new Size(1444, 881);
			Controls.Add(panel1);
			Controls.Add(painel);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load_1;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Voltar).EndInit();
			ResumeLayout(false);
		}

		#endregion

		public Label label2;
		public static WiLBiT.WiLBiTRoundedPictureBox2 Voltar;
		public static Panel painel;
		public static Panel panel1;
	}
}
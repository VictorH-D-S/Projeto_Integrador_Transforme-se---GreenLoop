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
		private void InitializeComponent()
		{
			wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
			btnVoltar = new WiLBiT.WiLBiTButton();
			label1 = new Label();
			painel = new Panel();
			panel1 = new Panel();
			label2 = new Label();
			wilBitGradientPanel1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// wilBitGradientPanel1
			// 
			wilBitGradientPanel1.Anchor = AnchorStyles.None;
			wilBitGradientPanel1.BackColor = SystemColors.Highlight;
			wilBitGradientPanel1.BackColor2 = Color.Transparent;
			wilBitGradientPanel1.BorderColor = Color.PaleVioletRed;
			wilBitGradientPanel1.BorderRadius = 6;
			wilBitGradientPanel1.BorderSize = 0;
			wilBitGradientPanel1.Controls.Add(btnVoltar);
			wilBitGradientPanel1.Controls.Add(label1);
			wilBitGradientPanel1.ForeColor = Color.Transparent;
			wilBitGradientPanel1.Location = new Point(-234, -84);
			wilBitGradientPanel1.Name = "wilBitGradientPanel1";
			wilBitGradientPanel1.Size = new Size(1919, 77);
			wilBitGradientPanel1.TabIndex = 0;
			// 
			// btnVoltar
			// 
			btnVoltar.BackColor = Color.FromArgb(0, 192, 0);
			btnVoltar.BorderColor = Color.FromArgb(72, 116, 245);
			btnVoltar.BorderRadius = 6;
			btnVoltar.BorderSize = 0;
			btnVoltar.FlatAppearance.BorderSize = 0;
			btnVoltar.FlatStyle = FlatStyle.Flat;
			btnVoltar.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnVoltar.ForeColor = Color.White;
			btnVoltar.Location = new Point(51, 24);
			btnVoltar.Name = "btnVoltar";
			btnVoltar.Size = new Size(105, 30);
			btnVoltar.TabIndex = 1;
			btnVoltar.Text = "Voltar";
			btnVoltar.UseVisualStyleBackColor = false;
			btnVoltar.Click += btnVoltar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(825, 13);
			label1.Name = "label1";
			label1.Size = new Size(180, 40);
			label1.TabIndex = 0;
			label1.Text = "GreenLoop";
			// 
			// painel
			// 
			painel.Anchor = AnchorStyles.None;
			painel.Location = new Point(0, 85);
			painel.Name = "painel";
			painel.Size = new Size(1443, 797);
			painel.TabIndex = 1;
			painel.Paint += painel_Paint;
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			panel1.BackColor = Color.LimeGreen;
			panel1.Controls.Add(label2);
			panel1.ForeColor = Color.LimeGreen;
			panel1.Location = new Point(0, -4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1450, 89);
			panel1.TabIndex = 2;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(566, 23);
			label2.Name = "label2";
			label2.Size = new Size(180, 40);
			label2.TabIndex = 0;
			label2.Text = "GreenLoop";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 3, 21);
			ClientSize = new Size(1444, 881);
			Controls.Add(panel1);
			Controls.Add(painel);
			Controls.Add(wilBitGradientPanel1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			wilBitGradientPanel1.ResumeLayout(false);
			wilBitGradientPanel1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion



		private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
		private Label label1;
		public WiLBiT.WiLBiTButton btnVoltar;
		private Panel panel1;
		private Label label2;
		public static Panel painel;
	}
}
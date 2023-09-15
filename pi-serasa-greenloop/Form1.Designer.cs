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
            painel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            Voltar = new WiLBiT.WiLBiTRoundedPictureBox2();
            this.label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(Voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            painel.Location = new System.Drawing.Point(0, 84);
            painel.Name = "painel";
            painel.Size = new System.Drawing.Size(1444, 796);
            painel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LimeGreen;
            panel1.Controls.Add(Voltar);
            panel1.Controls.Add(this.label2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.ForeColor = System.Drawing.Color.LimeGreen;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1444, 89);
            panel1.TabIndex = 2;
            // 
            // Voltar
            // 
            Voltar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            Voltar.BorderColor = System.Drawing.Color.Lime;
            Voltar.BorderColor2 = System.Drawing.Color.SpringGreen;
            Voltar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Voltar.BorderSize = 2;
            Voltar.GradientAngle = 50F;
            Voltar.Image = global::pi_serasa_greenloop.Properties.Resources.logo_greenloop;
            Voltar.Location = new System.Drawing.Point(71, 3);
            Voltar.Name = "Voltar";
            Voltar.Size = new System.Drawing.Size(88, 88);
            Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Voltar.TabIndex = 1;
            Voltar.TabStop = false;
            Voltar.Click += new System.EventHandler(this.Voltar_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1095, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "GreenLoop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(panel1);
            this.Controls.Add(painel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(Voltar)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public Label label2;
        public static WiLBiT.WiLBiTRoundedPictureBox2 Voltar;
        public static Panel painel;
        public static Panel panel1;
    }
}
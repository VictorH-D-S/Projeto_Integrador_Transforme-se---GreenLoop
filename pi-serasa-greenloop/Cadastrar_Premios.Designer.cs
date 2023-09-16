namespace pi_serasa_greenloop
{
	partial class Cadastrar_Premios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Premios));
			textBoxPremios = new WiLBiT.WiLBiTTextBox();
			label1 = new Label();
			label2 = new Label();
			btnConfirmar = new WiLBiT.WiLBiTButton();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// textBoxPremios
			// 
			textBoxPremios.BackColor = SystemColors.Window;
			textBoxPremios.BorderColor = Color.FromArgb(72, 116, 245);
			textBoxPremios.BorderFocusColor = Color.DeepSkyBlue;
			textBoxPremios.BorderRadius = 4;
			textBoxPremios.BorderSize = 2;
			textBoxPremios.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxPremios.ForeColor = Color.FromArgb(64, 64, 64);
			textBoxPremios.Location = new Point(350, 400);
			textBoxPremios.Margin = new Padding(4);
			textBoxPremios.Multiline = false;
			textBoxPremios.Name = "textBoxPremios";
			textBoxPremios.Padding = new Padding(10, 7, 10, 7);
			textBoxPremios.PasswordChar = false;
			textBoxPremios.PlaceholderColor = Color.DarkGray;
			textBoxPremios.PlaceholderText = "";
			textBoxPremios.Size = new Size(593, 29);
			textBoxPremios.TabIndex = 0;
			textBoxPremios.Texts = "";
			textBoxPremios.UnderlinedStyle = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(504, 367);
			label1.Name = "label1";
			label1.Size = new Size(266, 29);
			label1.TabIndex = 1;
			label1.Text = "Código da recompensa";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(524, 44);
			label2.Name = "label2";
			label2.Size = new Size(246, 35);
			label2.TabIndex = 2;
			label2.Text = "Cadastrar Premios";
			// 
			// btnConfirmar
			// 
			btnConfirmar.BackColor = Color.Gold;
			btnConfirmar.BorderColor = Color.FromArgb(72, 116, 245);
			btnConfirmar.BorderRadius = 20;
			btnConfirmar.BorderSize = 0;
			btnConfirmar.FlatAppearance.BorderSize = 0;
			btnConfirmar.FlatStyle = FlatStyle.Flat;
			btnConfirmar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnConfirmar.ForeColor = Color.Black;
			btnConfirmar.Location = new Point(538, 475);
			btnConfirmar.Name = "btnConfirmar";
			btnConfirmar.Size = new Size(212, 51);
			btnConfirmar.TabIndex = 3;
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.UseVisualStyleBackColor = false;
			btnConfirmar.Click += btnConfirmar_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(994, 141);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(327, 325);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 141);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(327, 325);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// Cadastrar_Premios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(39, 2, 40);
			ClientSize = new Size(1350, 729);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(btnConfirmar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxPremios);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Cadastrar_Premios";
			Text = "Form2";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private WiLBiT.WiLBiTTextBox textBoxPremios;
		private Label label1;
		private Label label2;
		private WiLBiT.WiLBiTButton btnConfirmar;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
	}
}
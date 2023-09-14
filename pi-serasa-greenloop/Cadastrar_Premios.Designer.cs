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
			textBoxPremios = new WiLBiT.WiLBiTTextBox();
			label1 = new Label();
			label2 = new Label();
			btnConfirmar = new WiLBiT.WiLBiTButton();
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
			textBoxPremios.Location = new Point(181, 82);
			textBoxPremios.Margin = new Padding(4);
			textBoxPremios.Multiline = false;
			textBoxPremios.Name = "textBoxPremios";
			textBoxPremios.Padding = new Padding(10, 7, 10, 7);
			textBoxPremios.PasswordChar = false;
			textBoxPremios.PlaceholderColor = Color.DarkGray;
			textBoxPremios.PlaceholderText = "";
			textBoxPremios.Size = new Size(250, 29);
			textBoxPremios.TabIndex = 0;
			textBoxPremios.Texts = "";
			textBoxPremios.UnderlinedStyle = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(181, 45);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 1;
			label1.Text = "Premio";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(324, 20);
			label2.Name = "label2";
			label2.Size = new Size(103, 15);
			label2.TabIndex = 2;
			label2.Text = "Cadastrar Premios";
			// 
			// btnConfirmar
			// 
			btnConfirmar.BackColor = Color.FromArgb(72, 116, 245);
			btnConfirmar.BorderColor = Color.FromArgb(72, 116, 245);
			btnConfirmar.BorderRadius = 6;
			btnConfirmar.BorderSize = 0;
			btnConfirmar.FlatAppearance.BorderSize = 0;
			btnConfirmar.FlatStyle = FlatStyle.Flat;
			btnConfirmar.ForeColor = Color.White;
			btnConfirmar.Location = new Point(281, 231);
			btnConfirmar.Name = "btnConfirmar";
			btnConfirmar.Size = new Size(150, 40);
			btnConfirmar.TabIndex = 3;
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.UseVisualStyleBackColor = false;
			btnConfirmar.Click += btnConfirmar_Click;
			// 
			// Cadastrar_Premios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnConfirmar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxPremios);
			Name = "Cadastrar_Premios";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private WiLBiT.WiLBiTTextBox textBoxPremios;
		private Label label1;
		private Label label2;
		private WiLBiT.WiLBiTButton btnConfirmar;
	}
}
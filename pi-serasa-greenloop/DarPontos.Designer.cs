namespace pi_serasa_greenloop
{
	partial class DarPontos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DarPontos));
			label3 = new Label();
			wilBitPanel1 = new WiLBiT.WiLBiTPanel();
			lblTudoCerto = new Label();
			iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			lblErro = new Label();
			pictureBox1 = new PictureBox();
			btnDepositar = new WiLBiT.WiLBiTButton();
			label2 = new Label();
			txtCPF = new WiLBiT.WiLBiTTextBox();
			txtPontuacao = new WiLBiT.WiLBiTTextBox();
			label1 = new Label();
			wilBitPanel2 = new WiLBiT.WiLBiTPanel();
			wilBitPanel3 = new WiLBiT.WiLBiTPanel();
			PainelResponsivo_DarPontos = new Panel();
			lblPontodeColeta = new Label();
			panel1 = new Panel();
			label4 = new Label();
			wilBitPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			PainelResponsivo_DarPontos.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(281, -46);
			label3.Name = "label3";
			label3.Size = new Size(157, 29);
			label3.TabIndex = 5;
			label3.Text = "Bem-Vindo, Ponto de Coleta";
			// 
			// wilBitPanel1
			// 
			wilBitPanel1.BackColor = Color.FromArgb(128, 255, 128);
			wilBitPanel1.BorderColor = Color.White;
			wilBitPanel1.BorderRadius = 40;
			wilBitPanel1.BorderSize = 0;
			wilBitPanel1.Controls.Add(iconPictureBox1);
			wilBitPanel1.Controls.Add(lblTudoCerto);
			wilBitPanel1.Controls.Add(lblErro);
			wilBitPanel1.Controls.Add(pictureBox1);
			wilBitPanel1.Controls.Add(btnDepositar);
			wilBitPanel1.Controls.Add(label2);
			wilBitPanel1.Controls.Add(txtCPF);
			wilBitPanel1.Controls.Add(txtPontuacao);
			wilBitPanel1.Controls.Add(label1);
			wilBitPanel1.Controls.Add(wilBitPanel2);
			wilBitPanel1.Controls.Add(wilBitPanel3);
			wilBitPanel1.Controls.Add(panel1);
			wilBitPanel1.ForeColor = Color.White;
			wilBitPanel1.Location = new Point(51, 38);
			wilBitPanel1.Name = "wilBitPanel1";
			wilBitPanel1.Size = new Size(816, 482);
			wilBitPanel1.TabIndex = 6;
			// 
			// lblTudoCerto
			// 
			lblTudoCerto.AutoSize = true;
			lblTudoCerto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblTudoCerto.ForeColor = Color.Green;
			lblTudoCerto.Location = new Point(46, 405);
			lblTudoCerto.Name = "lblTudoCerto";
			lblTudoCerto.Size = new Size(561, 64);
			lblTudoCerto.TabIndex = 9;
			lblTudoCerto.Text = "Tudo Certo!\r\nClique na Tela Para Fazer Uma Nova Operação ;)";
			lblTudoCerto.Visible = false;
			lblTudoCerto.Click += lblTudoCerto_Click;
			// 
			// iconPictureBox1
			// 
			iconPictureBox1.BackColor = Color.FromArgb(128, 255, 128);
			iconPictureBox1.Enabled = false;
			iconPictureBox1.ForeColor = Color.ForestGreen;
			iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
			iconPictureBox1.IconColor = Color.ForestGreen;
			iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconPictureBox1.IconSize = 482;
			iconPictureBox1.Location = new Point(46, 0);
			iconPictureBox1.Name = "iconPictureBox1";
			iconPictureBox1.Size = new Size(779, 482);
			iconPictureBox1.TabIndex = 9;
			iconPictureBox1.TabStop = false;
			iconPictureBox1.Visible = false;
			iconPictureBox1.WaitOnLoad = true;
			iconPictureBox1.Click += iconPictureBox1_Click;
			// 
			// lblErro
			// 
			lblErro.AutoSize = true;
			lblErro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblErro.ForeColor = Color.Red;
			lblErro.Location = new Point(102, 292);
			lblErro.Name = "lblErro";
			lblErro.Size = new Size(505, 42);
			lblErro.TabIndex = 8;
			lblErro.Text = "*Verifique o CPF e a Pontuação e tente novamente.\r\n*Lembre-se que só se pode adicionar até 10 pontos por operação.\r\n";
			lblErro.Visible = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(203, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(209, 117);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// btnDepositar
			// 
			btnDepositar.BackColor = Color.FromArgb(12, 92, 64);
			btnDepositar.BorderColor = Color.FromArgb(72, 116, 245);
			btnDepositar.BorderRadius = 20;
			btnDepositar.BorderSize = 0;
			btnDepositar.FlatAppearance.BorderSize = 0;
			btnDepositar.FlatStyle = FlatStyle.Flat;
			btnDepositar.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
			btnDepositar.ForeColor = Color.White;
			btnDepositar.Location = new Point(210, 385);
			btnDepositar.Name = "btnDepositar";
			btnDepositar.Size = new Size(229, 74);
			btnDepositar.TabIndex = 4;
			btnDepositar.Text = "Depositar";
			btnDepositar.UseVisualStyleBackColor = false;
			btnDepositar.Click += btnDepositar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(12, 92, 64);
			label2.Location = new Point(246, 216);
			label2.Name = "label2";
			label2.Size = new Size(130, 29);
			label2.TabIndex = 3;
			label2.Text = "Pontuação";
			// 
			// txtCPF
			// 
			txtCPF.BackColor = SystemColors.Window;
			txtCPF.BorderColor = Color.Black;
			txtCPF.BorderFocusColor = Color.Black;
			txtCPF.BorderRadius = 11;
			txtCPF.BorderSize = 2;
			txtCPF.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
			txtCPF.ForeColor = Color.FromArgb(64, 64, 64);
			txtCPF.Location = new Point(91, 156);
			txtCPF.Margin = new Padding(4);
			txtCPF.Multiline = false;
			txtCPF.Name = "txtCPF";
			txtCPF.Padding = new Padding(10, 7, 10, 7);
			txtCPF.PasswordChar = false;
			txtCPF.PlaceholderColor = Color.DimGray;
			txtCPF.PlaceholderText = "Exemplo: 12312312312";
			txtCPF.Size = new Size(462, 29);
			txtCPF.TabIndex = 0;
			txtCPF.Texts = "";
			txtCPF.UnderlinedStyle = false;
			// 
			// txtPontuacao
			// 
			txtPontuacao.BackColor = SystemColors.Window;
			txtPontuacao.BorderColor = Color.Black;
			txtPontuacao.BorderFocusColor = Color.Black;
			txtPontuacao.BorderRadius = 11;
			txtPontuacao.BorderSize = 2;
			txtPontuacao.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
			txtPontuacao.ForeColor = Color.FromArgb(64, 64, 64);
			txtPontuacao.Location = new Point(91, 249);
			txtPontuacao.Margin = new Padding(4);
			txtPontuacao.Multiline = false;
			txtPontuacao.Name = "txtPontuacao";
			txtPontuacao.Padding = new Padding(10, 7, 10, 7);
			txtPontuacao.PasswordChar = false;
			txtPontuacao.PlaceholderColor = Color.DarkGray;
			txtPontuacao.PlaceholderText = "";
			txtPontuacao.Size = new Size(462, 29);
			txtPontuacao.TabIndex = 1;
			txtPontuacao.Texts = "";
			txtPontuacao.UnderlinedStyle = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(12, 92, 64);
			label1.Location = new Point(230, 123);
			label1.Name = "label1";
			label1.Size = new Size(182, 29);
			label1.TabIndex = 2;
			label1.Text = "CPF do Usuário";
			// 
			// wilBitPanel2
			// 
			wilBitPanel2.BackColor = Color.Black;
			wilBitPanel2.BorderColor = Color.PaleVioletRed;
			wilBitPanel2.BorderRadius = 11;
			wilBitPanel2.BorderSize = 0;
			wilBitPanel2.ForeColor = Color.White;
			wilBitPanel2.Location = new Point(102, 165);
			wilBitPanel2.Name = "wilBitPanel2";
			wilBitPanel2.Size = new Size(462, 30);
			wilBitPanel2.TabIndex = 5;
			// 
			// wilBitPanel3
			// 
			wilBitPanel3.BackColor = Color.Black;
			wilBitPanel3.BorderColor = Color.PaleVioletRed;
			wilBitPanel3.BorderRadius = 11;
			wilBitPanel3.BorderSize = 0;
			wilBitPanel3.ForeColor = Color.White;
			wilBitPanel3.Location = new Point(102, 259);
			wilBitPanel3.Name = "wilBitPanel3";
			wilBitPanel3.Size = new Size(462, 30);
			wilBitPanel3.TabIndex = 6;
			// 
			// PainelResponsivo_DarPontos
			// 
			PainelResponsivo_DarPontos.Anchor = AnchorStyles.None;
			PainelResponsivo_DarPontos.Controls.Add(lblPontodeColeta);
			PainelResponsivo_DarPontos.Controls.Add(label3);
			PainelResponsivo_DarPontos.Controls.Add(wilBitPanel1);
			PainelResponsivo_DarPontos.Location = new Point(93, 41);
			PainelResponsivo_DarPontos.Name = "PainelResponsivo_DarPontos";
			PainelResponsivo_DarPontos.Size = new Size(907, 548);
			PainelResponsivo_DarPontos.TabIndex = 7;
			PainelResponsivo_DarPontos.Paint += PainelResponsivo_DarPontos_Paint;
			// 
			// lblPontodeColeta
			// 
			lblPontodeColeta.Anchor = AnchorStyles.None;
			lblPontodeColeta.BackColor = Color.Transparent;
			lblPontodeColeta.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			lblPontodeColeta.ForeColor = Color.White;
			lblPontodeColeta.Location = new Point(420, -46);
			lblPontodeColeta.Name = "lblPontodeColeta";
			lblPontodeColeta.Size = new Size(216, 29);
			lblPontodeColeta.TabIndex = 8;
			lblPontodeColeta.Text = "\"Ponto de Coleta\"";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label4);
			panel1.Location = new Point(604, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(212, 476);
			panel1.TabIndex = 10;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(9, 75);
			label4.Name = "label4";
			label4.Size = new Size(200, 312);
			label4.TabIndex = 11;
			label4.Text = resources.GetString("label4.Text");
			// 
			// DarPontos
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(0, 3, 21);
			ClientSize = new Size(1046, 788);
			Controls.Add(PainelResponsivo_DarPontos);
			FormBorderStyle = FormBorderStyle.None;
			Name = "DarPontos";
			Text = "DarPontos";
			Load += DarPontos_Load;
			wilBitPanel1.ResumeLayout(false);
			wilBitPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			PainelResponsivo_DarPontos.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Label label3;
		private WiLBiT.WiLBiTPanel wilBitPanel1;
		private WiLBiT.WiLBiTButton btnDepositar;
		private Label label2;
		private WiLBiT.WiLBiTTextBox txtCPF;
		private WiLBiT.WiLBiTTextBox txtPontuacao;
		private Label label1;
		private PictureBox pictureBox1;
		private WiLBiT.WiLBiTPanel wilBitPanel2;
		private WiLBiT.WiLBiTPanel wilBitPanel3;
		private Panel PainelResponsivo_DarPontos;
		private Label lblPontodeColeta;
		private Label lblErro;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private Label lblTudoCerto;
		private Panel panel1;
		private Label label4;
	}
}
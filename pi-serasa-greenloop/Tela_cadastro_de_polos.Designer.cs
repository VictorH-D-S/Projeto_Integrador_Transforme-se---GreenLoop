namespace pi_serasa_greenloop
{
    partial class Tela_cadastro_de_polos
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
            wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            btnMostraSenha = new FontAwesome.Sharp.IconPictureBox();
            btnEscondeSenha = new FontAwesome.Sharp.IconPictureBox();
            btnConfirmar = new WiLBiT.WiLBiTButton();
            txtSenha = new WiLBiT.WiLBiTTextBox();
            txtEmail = new WiLBiT.WiLBiTTextBox();
            txtEndereco = new WiLBiT.WiLBiTTextBox();
            txtNome = new WiLBiT.WiLBiTTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnRemover = new WiLBiT.WiLBiTButton();
            btnAdicionar = new WiLBiT.WiLBiTButton();
            label3 = new Label();
            pnlResponsivo_CadastroPollos = new Panel();
            wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostraSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEscondeSenha).BeginInit();
            pnlResponsivo_CadastroPollos.SuspendLayout();
            SuspendLayout();
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.BackColor = Color.FromArgb(65, 41, 160);
            wilBitPanel1.BorderColor = Color.PaleVioletRed;
            wilBitPanel1.BorderRadius = 11;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(btnMostraSenha);
            wilBitPanel1.Controls.Add(btnEscondeSenha);
            wilBitPanel1.Controls.Add(btnConfirmar);
            wilBitPanel1.Controls.Add(txtSenha);
            wilBitPanel1.Controls.Add(txtEmail);
            wilBitPanel1.Controls.Add(txtEndereco);
            wilBitPanel1.Controls.Add(txtNome);
            wilBitPanel1.Controls.Add(label7);
            wilBitPanel1.Controls.Add(label6);
            wilBitPanel1.Controls.Add(label5);
            wilBitPanel1.Controls.Add(label2);
            wilBitPanel1.Controls.Add(btnRemover);
            wilBitPanel1.Controls.Add(btnAdicionar);
            wilBitPanel1.ForeColor = Color.White;
            wilBitPanel1.Location = new Point(45, 42);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(924, 415);
            wilBitPanel1.TabIndex = 2;
            wilBitPanel1.Paint += wilBitPanel1_Paint;
            // 
            // btnMostraSenha
            // 
            btnMostraSenha.BackColor = Color.FromArgb(65, 41, 160);
            btnMostraSenha.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnMostraSenha.IconColor = Color.White;
            btnMostraSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostraSenha.Location = new Point(604, 236);
            btnMostraSenha.Name = "btnMostraSenha";
            btnMostraSenha.Size = new Size(32, 32);
            btnMostraSenha.TabIndex = 25;
            btnMostraSenha.TabStop = false;
            btnMostraSenha.Click += btnMostraSenha_Click;
            // 
            // btnEscondeSenha
            // 
            btnEscondeSenha.BackColor = Color.FromArgb(65, 41, 160);
            btnEscondeSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnEscondeSenha.IconColor = Color.White;
            btnEscondeSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEscondeSenha.Location = new Point(604, 236);
            btnEscondeSenha.Name = "btnEscondeSenha";
            btnEscondeSenha.Size = new Size(32, 32);
            btnEscondeSenha.TabIndex = 26;
            btnEscondeSenha.TabStop = false;
            btnEscondeSenha.Visible = false;
            btnEscondeSenha.Click += btnEscondeSenha_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(128, 255, 255);
            btnConfirmar.BorderColor = Color.FromArgb(72, 116, 245);
            btnConfirmar.BorderRadius = 11;
            btnConfirmar.BorderSize = 0;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.Location = new Point(699, 366);
            btnConfirmar.Margin = new Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(223, 47);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Window;
            txtSenha.BorderColor = Color.Black;
            txtSenha.BorderFocusColor = Color.DeepSkyBlue;
            txtSenha.BorderRadius = 15;
            txtSenha.BorderSize = 2;
            txtSenha.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(16, 236);
            txtSenha.Margin = new Padding(4);
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Padding = new Padding(10, 7, 10, 7);
            txtSenha.PasswordChar = true;
            txtSenha.PlaceholderColor = Color.DarkGray;
            txtSenha.PlaceholderText = "";
            txtSenha.Size = new Size(581, 29);
            txtSenha.TabIndex = 18;
            txtSenha.Texts = "";
            txtSenha.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.Black;
            txtEmail.BorderFocusColor = Color.DeepSkyBlue;
            txtEmail.BorderRadius = 15;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(17, 168);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(10, 7, 10, 7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.FromArgb(64, 64, 64);
            txtEmail.PlaceholderText = "Exemplo: lospollos@mexico.com";
            txtEmail.Size = new Size(581, 29);
            txtEmail.TabIndex = 17;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = SystemColors.Window;
            txtEndereco.BorderColor = Color.Black;
            txtEndereco.BorderFocusColor = Color.DeepSkyBlue;
            txtEndereco.BorderRadius = 15;
            txtEndereco.BorderSize = 2;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.ForeColor = Color.FromArgb(64, 64, 64);
            txtEndereco.Location = new Point(18, 102);
            txtEndereco.Margin = new Padding(4);
            txtEndereco.Multiline = false;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Padding = new Padding(10, 7, 10, 7);
            txtEndereco.PasswordChar = false;
            txtEndereco.PlaceholderColor = Color.FromArgb(64, 64, 64);
            txtEndereco.PlaceholderText = "Exemplo: Endereço: R. Mal. Deodoro, 3183 - Centro, São Carlos - SP, 13560-201";
            txtEndereco.Size = new Size(581, 29);
            txtEndereco.TabIndex = 16;
            txtEndereco.Texts = "";
            txtEndereco.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.BorderColor = Color.Black;
            txtNome.BorderFocusColor = Color.DeepSkyBlue;
            txtNome.BorderRadius = 15;
            txtNome.BorderSize = 2;
            txtNome.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(19, 40);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Padding = new Padding(10, 7, 10, 7);
            txtNome.PasswordChar = false;
            txtNome.PlaceholderColor = Color.FromArgb(64, 64, 64);
            txtNome.PlaceholderText = "Exemplo: Los Pollos Reciclagens";
            txtNome.Size = new Size(580, 29);
            txtNome.TabIndex = 15;
            txtNome.Texts = "";
            txtNome.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 11);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 14;
            label7.Text = "Nome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 73);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 13;
            label6.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 139);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 13;
            label5.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 210);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 8;
            label2.Text = "Senha";
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(128, 255, 255);
            btnRemover.BorderColor = Color.FromArgb(72, 116, 245);
            btnRemover.BorderRadius = 20;
            btnRemover.BorderSize = 0;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(320, 337);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(278, 57);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "REMOVER";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(128, 255, 255);
            btnAdicionar.BorderColor = Color.FromArgb(72, 116, 245);
            btnAdicionar.BorderRadius = 20;
            btnAdicionar.BorderSize = 0;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(18, 337);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(261, 57);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(371, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(272, 25);
            label3.TabIndex = 4;
            label3.Text = "Administrar Pontos de Coleta";
            // 
            // pnlResponsivo_CadastroPollos
            // 
            pnlResponsivo_CadastroPollos.Anchor = AnchorStyles.None;
            pnlResponsivo_CadastroPollos.Controls.Add(label3);
            pnlResponsivo_CadastroPollos.Controls.Add(wilBitPanel1);
            pnlResponsivo_CadastroPollos.Location = new Point(212, 134);
            pnlResponsivo_CadastroPollos.Name = "pnlResponsivo_CadastroPollos";
            pnlResponsivo_CadastroPollos.Size = new Size(1007, 483);
            pnlResponsivo_CadastroPollos.TabIndex = 5;
            // 
            // Tela_cadastro_de_polos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1370, 717);
            Controls.Add(pnlResponsivo_CadastroPollos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tela_cadastro_de_polos";
            Text = "Form1";
            Load += Tela_cadastro_de_polos_Load_1;
            wilBitPanel1.ResumeLayout(false);
            wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostraSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEscondeSenha).EndInit();
            pnlResponsivo_CadastroPollos.ResumeLayout(false);
            pnlResponsivo_CadastroPollos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private WiLBiT.WiLBiTButton btnRemover;
        private WiLBiT.WiLBiTButton btnAdicionar;
        private Label label2;
        private Label label3;
        private WiLBiT.WiLBiTButton btnConfirmar;
        private Label label7;
        private Label label6;
        private Label label5;
        private WiLBiT.WiLBiTTextBox txtSenha;
        private WiLBiT.WiLBiTTextBox txtEmail;
        private WiLBiT.WiLBiTTextBox txtEndereco;
        private WiLBiT.WiLBiTTextBox txtNome;
        private Panel pnlResponsivo_CadastroPollos;
        private FontAwesome.Sharp.IconPictureBox btnMostraSenha;
        private FontAwesome.Sharp.IconPictureBox btnEscondeSenha;
    }
}
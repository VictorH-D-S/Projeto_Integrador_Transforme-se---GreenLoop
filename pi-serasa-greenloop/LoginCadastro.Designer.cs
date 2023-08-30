namespace pi_serasa_greenloop
{
    partial class LoginCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            painelSuperior = new Panel();
            lblLogin = new Label();
            painelCentral = new Panel();
            btnLogin = new Button();
            btnCdastrar = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            textEmail = new TextBox();
            textSenha = new TextBox();
            painelSuperior.SuspendLayout();
            painelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // painelSuperior
            // 
            painelSuperior.BackColor = Color.Lime;
            painelSuperior.Controls.Add(lblLogin);
            painelSuperior.Location = new Point(192, 36);
            painelSuperior.Name = "painelSuperior";
            painelSuperior.Size = new Size(200, 100);
            painelSuperior.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(75, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(81, 25);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "| Login |";
            lblLogin.Click += lblLogin_Click;
            // 
            // painelCentral
            // 
            painelCentral.BackColor = Color.FromArgb(128, 255, 128);
            painelCentral.Controls.Add(textSenha);
            painelCentral.Controls.Add(textEmail);
            painelCentral.Controls.Add(label2);
            painelCentral.Controls.Add(label1);
            painelCentral.Controls.Add(btnConfirmar);
            painelCentral.Controls.Add(btnCdastrar);
            painelCentral.Controls.Add(btnLogin);
            painelCentral.Location = new Point(139, 179);
            painelCentral.Name = "painelCentral";
            painelCentral.Size = new Size(550, 390);
            painelCentral.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(213, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCdastrar
            // 
            btnCdastrar.Location = new Point(213, 289);
            btnCdastrar.Name = "btnCdastrar";
            btnCdastrar.Size = new Size(75, 23);
            btnCdastrar.TabIndex = 1;
            btnCdastrar.Text = "Cadastrar";
            btnCdastrar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(213, 339);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 113);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(40, 43);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(248, 23);
            textEmail.TabIndex = 5;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(40, 142);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(248, 23);
            textSenha.TabIndex = 6;
            // 
            // LoginCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 570);
            Controls.Add(painelCentral);
            Controls.Add(painelSuperior);
            Name = "LoginCadastro";
            Text = "Form1";
            Load += LoginCadastro_Load;
            painelSuperior.ResumeLayout(false);
            painelSuperior.PerformLayout();
            painelCentral.ResumeLayout(false);
            painelCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelSuperior;
        private Label lblLogin;
        private Panel painelCentral;
        private Button btnConfirmar;
        private Button btnCdastrar;
        private Button btnLogin;
        private TextBox textSenha;
        private TextBox textEmail;
        private Label label2;
        private Label label1;
    }
}
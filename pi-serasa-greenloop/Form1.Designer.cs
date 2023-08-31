namespace pi_serasa_greenloop
{
    partial class Form1
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
            btnSalvar = new Button();
            textNome = new TextBox();
            textIdade = new TextBox();
            textEmail = new TextBox();
            textSenha = new TextBox();
            textCPF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(340, 361);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(190, 36);
            textNome.Name = "textNome";
            textNome.Size = new Size(334, 23);
            textNome.TabIndex = 1;
            // 
            // textIdade
            // 
            textIdade.Location = new Point(190, 105);
            textIdade.Name = "textIdade";
            textIdade.Size = new Size(334, 23);
            textIdade.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(190, 165);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(334, 23);
            textEmail.TabIndex = 3;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(190, 234);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(334, 23);
            textSenha.TabIndex = 4;
            // 
            // textCPF
            // 
            textCPF.Location = new Point(190, 299);
            textCPF.Name = "textCPF";
            textCPF.Size = new Size(334, 23);
            textCPF.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 147);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 216);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 281);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 10;
            label5.Text = "cpf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textCPF);
            Controls.Add(textSenha);
            Controls.Add(textEmail);
            Controls.Add(textIdade);
            Controls.Add(textNome);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox textNome;
        private TextBox textIdade;
        private TextBox textEmail;
        private TextBox textSenha;
        private TextBox textCPF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
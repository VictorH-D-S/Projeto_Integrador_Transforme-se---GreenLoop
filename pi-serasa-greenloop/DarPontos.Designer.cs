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
            this.label3 = new System.Windows.Forms.Label();
            this.wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDepositar = new WiLBiT.WiLBiTButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new WiLBiT.WiLBiTTextBox();
            this.txtPontuacao = new WiLBiT.WiLBiTTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            this.wilBitPanel3 = new WiLBiT.WiLBiTPanel();
            this.wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(807, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bem-Vindo, Ponto de Coleta";
            // 
            // wilBitPanel1
            // 
            this.wilBitPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(253)))), ((int)(((byte)(206)))));
            this.wilBitPanel1.BorderColor = System.Drawing.Color.White;
            this.wilBitPanel1.BorderRadius = 40;
            this.wilBitPanel1.BorderSize = 0;
            this.wilBitPanel1.Controls.Add(this.pictureBox1);
            this.wilBitPanel1.Controls.Add(this.btnDepositar);
            this.wilBitPanel1.Controls.Add(this.label2);
            this.wilBitPanel1.Controls.Add(this.txtCPF);
            this.wilBitPanel1.Controls.Add(this.txtPontuacao);
            this.wilBitPanel1.Controls.Add(this.label1);
            this.wilBitPanel1.Controls.Add(this.wilBitPanel2);
            this.wilBitPanel1.Controls.Add(this.wilBitPanel3);
            this.wilBitPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel1.Location = new System.Drawing.Point(661, 178);
            this.wilBitPanel1.Name = "wilBitPanel1";
            this.wilBitPanel1.Size = new System.Drawing.Size(626, 598);
            this.wilBitPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.btnDepositar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.btnDepositar.BorderRadius = 20;
            this.btnDepositar.BorderSize = 0;
            this.btnDepositar.FlatAppearance.BorderSize = 0;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepositar.ForeColor = System.Drawing.Color.White;
            this.btnDepositar.Location = new System.Drawing.Point(192, 444);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(229, 74);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(240, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pontuação";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF.BorderColor = System.Drawing.Color.Black;
            this.txtCPF.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCPF.BorderRadius = 11;
            this.txtCPF.BorderSize = 2;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF.Location = new System.Drawing.Point(81, 224);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCPF.PlaceholderText = "";
            this.txtCPF.Size = new System.Drawing.Size(462, 29);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.Texts = "";
            this.txtCPF.UnderlinedStyle = false;
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtPontuacao.BorderColor = System.Drawing.Color.Black;
            this.txtPontuacao.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPontuacao.BorderRadius = 11;
            this.txtPontuacao.BorderSize = 2;
            this.txtPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPontuacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPontuacao.Location = new System.Drawing.Point(81, 364);
            this.txtPontuacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtPontuacao.Multiline = false;
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPontuacao.PasswordChar = false;
            this.txtPontuacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPontuacao.PlaceholderText = "";
            this.txtPontuacao.Size = new System.Drawing.Size(462, 29);
            this.txtPontuacao.TabIndex = 1;
            this.txtPontuacao.Texts = "";
            this.txtPontuacao.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(220, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF do Usuário";
            // 
            // wilBitPanel2
            // 
            this.wilBitPanel2.BackColor = System.Drawing.Color.Black;
            this.wilBitPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel2.BorderRadius = 11;
            this.wilBitPanel2.BorderSize = 0;
            this.wilBitPanel2.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel2.Location = new System.Drawing.Point(92, 233);
            this.wilBitPanel2.Name = "wilBitPanel2";
            this.wilBitPanel2.Size = new System.Drawing.Size(462, 30);
            this.wilBitPanel2.TabIndex = 5;
            // 
            // wilBitPanel3
            // 
            this.wilBitPanel3.BackColor = System.Drawing.Color.Black;
            this.wilBitPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel3.BorderRadius = 11;
            this.wilBitPanel3.BorderSize = 0;
            this.wilBitPanel3.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel3.Location = new System.Drawing.Point(92, 374);
            this.wilBitPanel3.Name = "wilBitPanel3";
            this.wilBitPanel3.Size = new System.Drawing.Size(462, 30);
            this.wilBitPanel3.TabIndex = 6;
            // 
            // DarPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wilBitPanel1);
            this.Name = "DarPontos";
            this.Text = "DarPontos";
            this.wilBitPanel1.ResumeLayout(false);
            this.wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
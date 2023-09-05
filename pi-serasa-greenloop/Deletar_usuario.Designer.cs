namespace pi_serasa_greenloop
{
    partial class Deletar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deletar_usuario));
            wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtCPF_Ademir = new WiLBiT.WiLBiTTextBox();
            btnDeletar_usuario = new WiLBiT.WiLBiTButton();
            label1 = new Label();
            wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.BackColor = Color.Gray;
            wilBitPanel1.BorderColor = Color.PaleVioletRed;
            wilBitPanel1.BorderRadius = 6;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(pictureBox1);
            wilBitPanel1.Controls.Add(label2);
            wilBitPanel1.Controls.Add(txtCPF_Ademir);
            wilBitPanel1.ForeColor = Color.White;
            wilBitPanel1.Location = new Point(390, 144);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(1158, 303);
            wilBitPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(502, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(564, 186);
            label2.Name = "label2";
            label2.Size = new Size(77, 45);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // txtCPF_Ademir
            // 
            txtCPF_Ademir.BackColor = SystemColors.Window;
            txtCPF_Ademir.BorderColor = Color.Black;
            txtCPF_Ademir.BorderFocusColor = Color.DeepSkyBlue;
            txtCPF_Ademir.BorderRadius = 16;
            txtCPF_Ademir.BorderSize = 2;
            txtCPF_Ademir.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF_Ademir.ForeColor = Color.FromArgb(64, 64, 64);
            txtCPF_Ademir.Location = new Point(271, 235);
            txtCPF_Ademir.Margin = new Padding(4);
            txtCPF_Ademir.Multiline = false;
            txtCPF_Ademir.Name = "txtCPF_Ademir";
            txtCPF_Ademir.Padding = new Padding(10, 7, 10, 7);
            txtCPF_Ademir.PasswordChar = false;
            txtCPF_Ademir.PlaceholderColor = Color.DarkGray;
            txtCPF_Ademir.PlaceholderText = "";
            txtCPF_Ademir.Size = new Size(669, 36);
            txtCPF_Ademir.TabIndex = 0;
            txtCPF_Ademir.Texts = "";
            txtCPF_Ademir.UnderlinedStyle = false;
            // 
            // btnDeletar_usuario
            // 
            btnDeletar_usuario.BackColor = Color.Firebrick;
            btnDeletar_usuario.BorderColor = Color.FromArgb(72, 116, 245);
            btnDeletar_usuario.BorderRadius = 15;
            btnDeletar_usuario.BorderSize = 0;
            btnDeletar_usuario.FlatAppearance.BorderSize = 0;
            btnDeletar_usuario.FlatStyle = FlatStyle.Flat;
            btnDeletar_usuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletar_usuario.ForeColor = Color.White;
            btnDeletar_usuario.Location = new Point(846, 503);
            btnDeletar_usuario.Name = "btnDeletar_usuario";
            btnDeletar_usuario.Size = new Size(260, 79);
            btnDeletar_usuario.TabIndex = 1;
            btnDeletar_usuario.Text = "Deletar";
            btnDeletar_usuario.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(827, 96);
            label1.Name = "label1";
            label1.Size = new Size(306, 45);
            label1.TabIndex = 2;
            label1.Text = "DELETAR USUÁRIO";
            // 
            // Deletar_usuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1898, 1024);
            Controls.Add(label1);
            Controls.Add(btnDeletar_usuario);
            Controls.Add(wilBitPanel1);
            Name = "Deletar_usuario";
            Text = "Deletar_usuario";
            wilBitPanel1.ResumeLayout(false);
            wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private WiLBiT.WiLBiTButton btnDeletar_usuario;
        private WiLBiT.WiLBiTTextBox txtCPF_Ademir;
        private Label label2;
        public Label label1;
        private PictureBox pictureBox1;
    }
}
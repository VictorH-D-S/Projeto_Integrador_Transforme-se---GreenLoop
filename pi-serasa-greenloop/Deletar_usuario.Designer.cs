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
            PainelResponsivo_DeletarUsuário = new Panel();
            wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PainelResponsivo_DeletarUsuário.SuspendLayout();
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
            wilBitPanel1.Location = new Point(2, 36);
            wilBitPanel1.Margin = new Padding(2);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(819, 182);
            wilBitPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(358, 19);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(387, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
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
            txtCPF_Ademir.Location = new Point(195, 144);
            txtCPF_Ademir.Margin = new Padding(3, 2, 3, 2);
            txtCPF_Ademir.Multiline = false;
            txtCPF_Ademir.Name = "txtCPF_Ademir";
            txtCPF_Ademir.Padding = new Padding(7, 4, 7, 4);
            txtCPF_Ademir.PasswordChar = false;
            txtCPF_Ademir.PlaceholderColor = Color.DarkGray;
            txtCPF_Ademir.PlaceholderText = "";
            txtCPF_Ademir.Size = new Size(468, 23);
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
            btnDeletar_usuario.Location = new Point(343, 222);
            btnDeletar_usuario.Margin = new Padding(2);
            btnDeletar_usuario.Name = "btnDeletar_usuario";
            btnDeletar_usuario.Size = new Size(182, 47);
            btnDeletar_usuario.TabIndex = 1;
            btnDeletar_usuario.Text = "Deletar";
            btnDeletar_usuario.UseVisualStyleBackColor = false;
            btnDeletar_usuario.Click += btnDeletar_usuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 2;
            label1.Text = "DELETAR USUÁRIO";
            // 
            // PainelResponsivo_DeletarUsuário
            // 
            PainelResponsivo_DeletarUsuário.Controls.Add(wilBitPanel1);
            PainelResponsivo_DeletarUsuário.Controls.Add(label1);
            PainelResponsivo_DeletarUsuário.Controls.Add(btnDeletar_usuario);
            PainelResponsivo_DeletarUsuário.Location = new Point(295, 99);
            PainelResponsivo_DeletarUsuário.Name = "PainelResponsivo_DeletarUsuário";
            PainelResponsivo_DeletarUsuário.Size = new Size(821, 279);
            PainelResponsivo_DeletarUsuário.TabIndex = 3;
            // 
            // Deletar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1329, 614);
            Controls.Add(PainelResponsivo_DeletarUsuário);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Deletar_usuario";
            Text = "Deletar_usuario";
            Load += Deletar_usuario_Load;
            wilBitPanel1.ResumeLayout(false);
            wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PainelResponsivo_DeletarUsuário.ResumeLayout(false);
            PainelResponsivo_DeletarUsuário.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private WiLBiT.WiLBiTButton btnDeletar_usuario;
        private WiLBiT.WiLBiTTextBox txtCPF_Ademir;
        private Label label2;
        public Label label1;
        private PictureBox pictureBox1;
        private Panel PainelResponsivo_DeletarUsuário;
    }
}
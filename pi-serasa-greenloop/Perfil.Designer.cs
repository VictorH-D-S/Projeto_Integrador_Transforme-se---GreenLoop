namespace pi_serasa_greenloop
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            this.ptbPerfilAvatar = new WiLBiT.WiLBiTRoundedPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal_Reciclado = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerfilAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wilBitPanel1
            // 
            this.wilBitPanel1.BackColor = System.Drawing.Color.Black;
            this.wilBitPanel1.BorderColor = System.Drawing.Color.OldLace;
            this.wilBitPanel1.BorderRadius = 11;
            this.wilBitPanel1.BorderSize = 0;
            this.wilBitPanel1.Controls.Add(this.ptbPerfilAvatar);
            this.wilBitPanel1.Controls.Add(this.label6);
            this.wilBitPanel1.Controls.Add(this.lblPontos);
            this.wilBitPanel1.Controls.Add(this.label4);
            this.wilBitPanel1.Controls.Add(this.label3);
            this.wilBitPanel1.Controls.Add(this.lblTotal_Reciclado);
            this.wilBitPanel1.Controls.Add(this.lblNome);
            this.wilBitPanel1.ForeColor = System.Drawing.Color.SeaShell;
            this.wilBitPanel1.Location = new System.Drawing.Point(546, 149);
            this.wilBitPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.wilBitPanel1.Name = "wilBitPanel1";
            this.wilBitPanel1.Size = new System.Drawing.Size(883, 529);
            this.wilBitPanel1.TabIndex = 0;
            this.wilBitPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.wilBitPanel1_Paint);
            // 
            // ptbPerfilAvatar
            // 
            this.ptbPerfilAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ptbPerfilAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptbPerfilAvatar.BorderColor = System.Drawing.Color.Lime;
            this.ptbPerfilAvatar.BorderColor2 = System.Drawing.Color.Lime;
            this.ptbPerfilAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptbPerfilAvatar.BorderSize = 2;
            this.ptbPerfilAvatar.GradientAngle = 50F;
            this.ptbPerfilAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbPerfilAvatar.Image")));
            this.ptbPerfilAvatar.Location = new System.Drawing.Point(349, 64);
            this.ptbPerfilAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPerfilAvatar.Name = "ptbPerfilAvatar";
            this.ptbPerfilAvatar.Size = new System.Drawing.Size(205, 205);
            this.ptbPerfilAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPerfilAvatar.TabIndex = 8;
            this.ptbPerfilAvatar.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(437, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Olá";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontos.Location = new System.Drawing.Point(497, 409);
            this.lblPontos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(23, 25);
            this.lblPontos.TabIndex = 5;
            this.lblPontos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(399, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pontos - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(369, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Reciclado -";
            // 
            // lblTotal_Reciclado
            // 
            this.lblTotal_Reciclado.AutoSize = true;
            this.lblTotal_Reciclado.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal_Reciclado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal_Reciclado.Location = new System.Drawing.Point(541, 350);
            this.lblTotal_Reciclado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Reciclado.Name = "lblTotal_Reciclado";
            this.lblTotal_Reciclado.Size = new System.Drawing.Size(23, 25);
            this.lblTotal_Reciclado.TabIndex = 2;
            this.lblTotal_Reciclado.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(358, 295);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(194, 30);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Úsuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.wilBitPanel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.wilBitPanel1.ResumeLayout(false);
            this.wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerfilAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private Label label3;
        private Label lblTotal_Reciclado;
        private Label lblNome;
        private Label lblPontos;
        private Label label4;
        private Label label6;
        private WiLBiT.WiLBiTRoundedPictureBox ptbPerfilAvatar;
        private PictureBox pictureBox1;
    }
}
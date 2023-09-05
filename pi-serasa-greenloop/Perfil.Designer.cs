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
            wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            ptbPerfilAvatar = new WiLBiT.WiLBiTRoundedPictureBox();
            label6 = new Label();
            lblPontos = new Label();
            label4 = new Label();
            label3 = new Label();
            lblTotal_Reciclado = new Label();
            lblNome = new Label();
            pictureBox1 = new PictureBox();
            wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPerfilAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.BackColor = Color.Black;
            wilBitPanel1.BorderColor = Color.OldLace;
            wilBitPanel1.BorderRadius = 11;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(ptbPerfilAvatar);
            wilBitPanel1.Controls.Add(label6);
            wilBitPanel1.Controls.Add(lblPontos);
            wilBitPanel1.Controls.Add(label4);
            wilBitPanel1.Controls.Add(label3);
            wilBitPanel1.Controls.Add(lblTotal_Reciclado);
            wilBitPanel1.Controls.Add(lblNome);
            wilBitPanel1.ForeColor = Color.SeaShell;
            wilBitPanel1.Location = new Point(366, 135);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(1166, 750);
            wilBitPanel1.TabIndex = 0;
            // 
            // ptbPerfilAvatar
            // 
            ptbPerfilAvatar.BackColor = Color.Transparent;
            ptbPerfilAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            ptbPerfilAvatar.BorderColor = Color.Lime;
            ptbPerfilAvatar.BorderColor2 = Color.Lime;
            ptbPerfilAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            ptbPerfilAvatar.BorderSize = 2;
            ptbPerfilAvatar.GradientAngle = 50F;
            ptbPerfilAvatar.Image = (Image)resources.GetObject("ptbPerfilAvatar.Image");
            ptbPerfilAvatar.Location = new Point(453, 47);
            ptbPerfilAvatar.Name = "ptbPerfilAvatar";
            ptbPerfilAvatar.Size = new Size(293, 293);
            ptbPerfilAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPerfilAvatar.TabIndex = 8;
            ptbPerfilAvatar.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(579, 373);
            label6.Name = "label6";
            label6.Size = new Size(62, 38);
            label6.TabIndex = 7;
            label6.Text = "Olá";
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.BackColor = Color.Transparent;
            lblPontos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontos.Location = new Point(664, 621);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(33, 38);
            lblPontos.TabIndex = 5;
            lblPontos.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(524, 621);
            label4.Name = "label4";
            label4.Size = new Size(134, 38);
            label4.TabIndex = 4;
            label4.Text = "Pontos - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(481, 523);
            label3.Name = "label3";
            label3.Size = new Size(231, 38);
            label3.TabIndex = 3;
            label3.Text = "Total Reciclado -";
            // 
            // lblTotal_Reciclado
            // 
            lblTotal_Reciclado.AutoSize = true;
            lblTotal_Reciclado.BackColor = Color.Transparent;
            lblTotal_Reciclado.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal_Reciclado.Location = new Point(727, 523);
            lblTotal_Reciclado.Name = "lblTotal_Reciclado";
            lblTotal_Reciclado.Size = new Size(33, 38);
            lblTotal_Reciclado.TabIndex = 2;
            lblTotal_Reciclado.Text = "0";
            lblTotal_Reciclado.Click += label2_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNome.Location = new Point(465, 432);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(281, 45);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome do Úsuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1898, 1024);
            Controls.Add(wilBitPanel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "Perfil";
            Text = "Perfil";
            wilBitPanel1.ResumeLayout(false);
            wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPerfilAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
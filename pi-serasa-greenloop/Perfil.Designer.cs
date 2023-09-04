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
            wilBitRoundedPictureBox1 = new WiLBiT.WiLBiTRoundedPictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wilBitRoundedPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.BackColor = Color.Black;
            wilBitPanel1.BorderColor = Color.OldLace;
            wilBitPanel1.BorderRadius = 11;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(wilBitRoundedPictureBox1);
            wilBitPanel1.Controls.Add(label6);
            wilBitPanel1.Controls.Add(label5);
            wilBitPanel1.Controls.Add(label4);
            wilBitPanel1.Controls.Add(label3);
            wilBitPanel1.Controls.Add(label2);
            wilBitPanel1.Controls.Add(label1);
            wilBitPanel1.ForeColor = Color.SeaShell;
            wilBitPanel1.Location = new Point(366, 135);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(1166, 750);
            wilBitPanel1.TabIndex = 0;
            // 
            // wilBitRoundedPictureBox1
            // 
            wilBitRoundedPictureBox1.BackColor = Color.Transparent;
            wilBitRoundedPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            wilBitRoundedPictureBox1.BorderColor = Color.Lime;
            wilBitRoundedPictureBox1.BorderColor2 = Color.Lime;
            wilBitRoundedPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            wilBitRoundedPictureBox1.BorderSize = 2;
            wilBitRoundedPictureBox1.GradientAngle = 50F;
            wilBitRoundedPictureBox1.Image = (Image)resources.GetObject("wilBitRoundedPictureBox1.Image");
            wilBitRoundedPictureBox1.Location = new Point(453, 47);
            wilBitRoundedPictureBox1.Name = "wilBitRoundedPictureBox1";
            wilBitRoundedPictureBox1.Size = new Size(293, 293);
            wilBitRoundedPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            wilBitRoundedPictureBox1.TabIndex = 8;
            wilBitRoundedPictureBox1.TabStop = false;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(664, 621);
            label5.Name = "label5";
            label5.Size = new Size(33, 38);
            label5.TabIndex = 5;
            label5.Text = "0";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(727, 523);
            label2.Name = "label2";
            label2.Size = new Size(33, 38);
            label2.TabIndex = 2;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(465, 432);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 1;
            label1.Text = "Nome do Úsuario";
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
            ((System.ComponentModel.ISupportInitialize)wilBitRoundedPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
        private WiLBiT.WiLBiTRoundedPictureBox wilBitRoundedPictureBox1;
        private PictureBox pictureBox1;
    }
}
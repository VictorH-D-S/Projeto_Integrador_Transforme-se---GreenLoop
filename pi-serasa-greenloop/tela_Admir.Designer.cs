﻿namespace pi_serasa_greenloop
{
    partial class tela_Admir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_Admir));
            btnPolos = new WiLBiT.WiLBiTButton();
            btnUsuarios = new WiLBiT.WiLBiTButton();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnPolos
            // 
            btnPolos.BackColor = Color.FromArgb(21, 191, 81);
            btnPolos.BorderColor = Color.FromArgb(72, 116, 245);
            btnPolos.BorderRadius = 15;
            btnPolos.BorderSize = 0;
            btnPolos.FlatAppearance.BorderSize = 0;
            btnPolos.FlatStyle = FlatStyle.Flat;
            btnPolos.ForeColor = Color.White;
            btnPolos.Location = new Point(270, 308);
            btnPolos.Name = "btnPolos";
            btnPolos.Size = new Size(424, 438);
            btnPolos.TabIndex = 0;
            btnPolos.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Gray;
            btnUsuarios.BorderColor = Color.FromArgb(72, 116, 245);
            btnUsuarios.BorderRadius = 15;
            btnUsuarios.BorderSize = 0;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(1163, 308);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(424, 438);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(21, 191, 81);
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(401, 402);
            label1.Name = "label1";
            label1.Size = new Size(162, 70);
            label1.TabIndex = 3;
            label1.Text = "Polos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1251, 402);
            label2.Name = "label2";
            label2.Size = new Size(241, 70);
            label2.TabIndex = 4;
            label2.Text = "Usuários";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1240, 475);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(21, 191, 81);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(345, 475);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 241);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // tela_Admir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1898, 1024);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnUsuarios);
            Controls.Add(btnPolos);
            Name = "tela_Admir";
            Text = "tela_Admir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton btnPolos;
        private WiLBiT.WiLBiTButton btnUsuarios;
        public Label label1;
        public Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
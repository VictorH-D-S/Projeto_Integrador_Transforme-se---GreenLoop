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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.painel = new System.Windows.Forms.Panel();
            this.btnVoltar = new WiLBiT.WiLBiTButton();
            this.wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            this.wilBitButton1 = new WiLBiT.WiLBiTButton();
            this.wilBitGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrincipal.Font = new System.Drawing.Font("Trebuchet MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(851, 18);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(179, 40);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "GreenLoop";
            this.lblPrincipal.Click += new System.EventHandler(this.lblPrincipal_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(1, 81);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(1902, 963);
            this.painel.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.btnVoltar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.btnVoltar.BorderRadius = 6;
            this.btnVoltar.BorderSize = 0;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(11, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 40);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.wilBitButton1_Click);
            // 
            // wilBitGradientPanel1
            // 
            this.wilBitGradientPanel1.BackColor = System.Drawing.Color.Green;
            this.wilBitGradientPanel1.BackColor2 = System.Drawing.Color.Lime;
            this.wilBitGradientPanel1.BorderColor = System.Drawing.Color.Lime;
            this.wilBitGradientPanel1.BorderRadius = 6;
            this.wilBitGradientPanel1.BorderSize = 0;
            this.wilBitGradientPanel1.Controls.Add(this.wilBitButton1);
            this.wilBitGradientPanel1.Controls.Add(this.btnVoltar);
            this.wilBitGradientPanel1.Controls.Add(this.lblPrincipal);
            this.wilBitGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitGradientPanel1.Location = new System.Drawing.Point(1, 2);
            this.wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            this.wilBitGradientPanel1.Size = new System.Drawing.Size(1902, 84);
            this.wilBitGradientPanel1.TabIndex = 14;
            this.wilBitGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.wilBitGradientPanel1_Paint);
            // 
            // wilBitButton1
            // 
            this.wilBitButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.wilBitButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.wilBitButton1.BorderRadius = 6;
            this.wilBitButton1.BorderSize = 0;
            this.wilBitButton1.FlatAppearance.BorderSize = 0;
            this.wilBitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wilBitButton1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wilBitButton1.ForeColor = System.Drawing.Color.White;
            this.wilBitButton1.Location = new System.Drawing.Point(1648, 18);
            this.wilBitButton1.Name = "wilBitButton1";
            this.wilBitButton1.Size = new System.Drawing.Size(200, 49);
            this.wilBitButton1.TabIndex = 40;
            this.wilBitButton1.Text = "Login / Cadastro";
            this.wilBitButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.wilBitGradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.wilBitGradientPanel1.ResumeLayout(false);
            this.wilBitGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel painel;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private WiLBiT.WiLBiTButton btnVoltar;
        private WiLBiT.WiLBiTButton wilBitButton1;
    }
}
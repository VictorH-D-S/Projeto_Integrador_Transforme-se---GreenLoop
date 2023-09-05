namespace pi_serasa_greenloop
{
    partial class Form1
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
            this.wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            this.btnVoltar = new WiLBiT.WiLBiTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.painel = new System.Windows.Forms.Panel();
            this.wilBitGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wilBitGradientPanel1
            // 
            this.wilBitGradientPanel1.BackColor = System.Drawing.Color.Green;
            this.wilBitGradientPanel1.BackColor2 = System.Drawing.Color.LimeGreen;
            this.wilBitGradientPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitGradientPanel1.BorderRadius = 6;
            this.wilBitGradientPanel1.BorderSize = 0;
            this.wilBitGradientPanel1.Controls.Add(this.btnVoltar);
            this.wilBitGradientPanel1.Controls.Add(this.label1);
            this.wilBitGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitGradientPanel1.Location = new System.Drawing.Point(-4, -4);
            this.wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            this.wilBitGradientPanel1.Size = new System.Drawing.Size(1919, 77);
            this.wilBitGradientPanel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoltar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.btnVoltar.BorderRadius = 6;
            this.btnVoltar.BorderSize = 0;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(51, 24);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 30);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(825, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GreenLoop";
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(0, 70);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(1918, 973);
            this.painel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(21)))));
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

        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private Label label1;
        private Panel painel;
        private WiLBiT.WiLBiTButton btnVoltar;
    }
}
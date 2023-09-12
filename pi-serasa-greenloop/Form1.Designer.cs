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
        public void InitializeComponent()
        {
            this.btnVoltar = new WiLBiT.WiLBiTButton();
            painel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.btnVoltar.BorderRadius = 6;
            this.btnVoltar.BorderSize = 0;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(61, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 47);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // painel
            // 
            painel.Anchor = System.Windows.Forms.AnchorStyles.None;
            painel.Location = new System.Drawing.Point(0, 89);
            painel.Name = "painel";
            painel.Size = new System.Drawing.Size(1904, 952);
            painel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LimeGreen;
            panel1.Controls.Add(this.btnVoltar);
            panel1.Controls.Add(this.label2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.ForeColor = System.Drawing.Color.LimeGreen;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1904, 89);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1325, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "GreenLoop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(panel1);
            this.Controls.Add(painel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public WiLBiT.WiLBiTButton btnVoltar;

        #endregion

        public Label label2;
        public static Panel painel;
        public static Panel panel1;
    }
}
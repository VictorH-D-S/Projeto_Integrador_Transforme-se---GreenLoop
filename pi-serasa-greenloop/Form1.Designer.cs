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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wilBitButton2 = new WiLBiT.WiLBiTButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1905, 87);
            this.panel1.TabIndex = 0;
            // 
            // wilBitButton2
            // 
            this.wilBitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wilBitButton2.BorderColor = System.Drawing.Color.Silver;
            this.wilBitButton2.BorderRadius = 75;
            this.wilBitButton2.BorderSize = 0;
            this.wilBitButton2.FlatAppearance.BorderSize = 0;
            this.wilBitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wilBitButton2.ForeColor = System.Drawing.Color.Black;
            this.wilBitButton2.Location = new System.Drawing.Point(52, 12);
            this.wilBitButton2.Name = "wilBitButton2";
            this.wilBitButton2.Size = new System.Drawing.Size(137, 137);
            this.wilBitButton2.TabIndex = 2;
            this.wilBitButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.wilBitButton2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WiLBiT.WiLBiTButton wilBitButton2;
    }
}
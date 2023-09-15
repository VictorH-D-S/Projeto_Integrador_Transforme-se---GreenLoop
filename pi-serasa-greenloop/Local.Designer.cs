namespace pi_serasa_greenloop
{
    partial class Local
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
            this.wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wilBitPanel1
            // 
            this.wilBitPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wilBitPanel1.AutoScroll = true;
            this.wilBitPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wilBitPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel1.BorderRadius = 6;
            this.wilBitPanel1.BorderSize = 0;
            this.wilBitPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel1.Location = new System.Drawing.Point(63, 177);
            this.wilBitPanel1.Name = "wilBitPanel1";
            this.wilBitPanel1.Size = new System.Drawing.Size(1214, 347);
            this.wilBitPanel1.TabIndex = 0;
            this.wilBitPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.wilBitPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pi_serasa_greenloop.Properties.Resources._535137;
            this.pictureBox1.Location = new System.Drawing.Point(422, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Polos Parceiros";
            // 
            // Local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wilBitPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Local";
            this.Text = "Local";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
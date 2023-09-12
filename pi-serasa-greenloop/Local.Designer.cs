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
            this.SuspendLayout();
            // 
            // wilBitPanel1
            // 
            this.wilBitPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wilBitPanel1.AutoScroll = true;
            this.wilBitPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.wilBitPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel1.BorderRadius = 6;
            this.wilBitPanel1.BorderSize = 0;
            this.wilBitPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel1.Location = new System.Drawing.Point(64, 161);
            this.wilBitPanel1.Name = "wilBitPanel1";
            this.wilBitPanel1.Size = new System.Drawing.Size(1214, 347);
            this.wilBitPanel1.TabIndex = 0;
            // 
            // Local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.wilBitPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Local";
            this.Text = "Local";
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
    }
}
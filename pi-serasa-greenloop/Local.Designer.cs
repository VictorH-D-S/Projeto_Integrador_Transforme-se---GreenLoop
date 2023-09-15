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
            this.wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomePolo = new System.Windows.Forms.Label();
            this.linkLocalizar = new System.Windows.Forms.LinkLabel();
            this.enderecoPolo = new System.Windows.Forms.Label();
            this.wilBitPanel1.SuspendLayout();
            this.wilBitPanel2.SuspendLayout();
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
            this.wilBitPanel1.Controls.Add(this.wilBitPanel2);
            this.wilBitPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel1.Location = new System.Drawing.Point(63, 177);
            this.wilBitPanel1.Name = "wilBitPanel1";
            this.wilBitPanel1.Size = new System.Drawing.Size(1214, 347);
            this.wilBitPanel1.TabIndex = 0;
            this.wilBitPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.wilBitPanel1_Paint);
            // 
            // wilBitPanel2
            // 
            this.wilBitPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.wilBitPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel2.BorderRadius = 30;
            this.wilBitPanel2.BorderSize = 0;
            this.wilBitPanel2.Controls.Add(this.enderecoPolo);
            this.wilBitPanel2.Controls.Add(this.linkLocalizar);
            this.wilBitPanel2.Controls.Add(this.lblNomePolo);
            this.wilBitPanel2.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel2.Location = new System.Drawing.Point(46, 41);
            this.wilBitPanel2.Name = "wilBitPanel2";
            this.wilBitPanel2.Size = new System.Drawing.Size(300, 265);
            this.wilBitPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pi_serasa_greenloop.Properties.Resources._535137;
            this.pictureBox1.Location = new System.Drawing.Point(422, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // lblNomePolo
            // 
            this.lblNomePolo.AutoSize = true;
            this.lblNomePolo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomePolo.Location = new System.Drawing.Point(85, 36);
            this.lblNomePolo.Name = "lblNomePolo";
            this.lblNomePolo.Size = new System.Drawing.Size(132, 24);
            this.lblNomePolo.TabIndex = 0;
            this.lblNomePolo.Text = "nome do polo";
            // 
            // linkLocalizar
            // 
            this.linkLocalizar.AutoSize = true;
            this.linkLocalizar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLocalizar.LinkColor = System.Drawing.Color.White;
            this.linkLocalizar.Location = new System.Drawing.Point(111, 169);
            this.linkLocalizar.Name = "linkLocalizar";
            this.linkLocalizar.Size = new System.Drawing.Size(81, 22);
            this.linkLocalizar.TabIndex = 1;
            this.linkLocalizar.TabStop = true;
            this.linkLocalizar.Text = "Localizar";
            // 
            // enderecoPolo
            // 
            this.enderecoPolo.AutoSize = true;
            this.enderecoPolo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enderecoPolo.Location = new System.Drawing.Point(98, 80);
            this.enderecoPolo.Name = "enderecoPolo";
            this.enderecoPolo.Size = new System.Drawing.Size(94, 24);
            this.enderecoPolo.TabIndex = 2;
            this.enderecoPolo.Text = "endereço";
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
            this.Name = "Local";
            this.Text = "Local";
            this.Load += new System.EventHandler(this.Local_Load);
            this.wilBitPanel1.ResumeLayout(false);
            this.wilBitPanel2.ResumeLayout(false);
            this.wilBitPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private Label enderecoPolo;
        private LinkLabel linkLocalizar;
        private Label lblNomePolo;
    }
}
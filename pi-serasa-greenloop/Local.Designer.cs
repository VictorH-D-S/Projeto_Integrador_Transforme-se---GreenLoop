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
            pnlCarregaPolos = new WiLBiT.WiLBiTPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlCarregaPolos
            // 
            pnlCarregaPolos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlCarregaPolos.AutoScroll = true;
            pnlCarregaPolos.BackColor = Color.FromArgb(255, 128, 0);
            pnlCarregaPolos.BorderColor = Color.Peru;
            pnlCarregaPolos.BorderRadius = 6;
            pnlCarregaPolos.BorderSize = 0;
            pnlCarregaPolos.ForeColor = Color.White;
            pnlCarregaPolos.Location = new Point(69, 164);
            pnlCarregaPolos.Name = "pnlCarregaPolos";
            pnlCarregaPolos.Size = new Size(1005, 290);
            pnlCarregaPolos.TabIndex = 0;
            pnlCarregaPolos.Paint += wilBitPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._535137;
            pictureBox1.Location = new Point(546, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(644, 91);
            label1.Name = "label1";
            label1.Size = new Size(243, 40);
            label1.TabIndex = 2;
            label1.Text = "Polos Parceiros";
            // 
            // Local
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1350, 729);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlCarregaPolos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Local";
            Text = "Local";
            Load += Local_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTPanel pnlCarregaPolos;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
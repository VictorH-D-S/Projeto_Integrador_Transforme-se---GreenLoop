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
            btnVoltar = new WiLBiT.WiLBiTButton();
            painel = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 128, 0);
            btnVoltar.BorderColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderRadius = 6;
            btnVoltar.BorderSize = 0;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(61, 23);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(125, 47);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // painel
            // 
            painel.Anchor = AnchorStyles.None;
            painel.Location = new Point(0, 78);
            painel.Name = "painel";
            painel.Size = new Size(1451, 786);
            painel.TabIndex = 1;
            painel.Paint += painel_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.LimeGreen;
            panel1.Location = new Point(-6, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1456, 89);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1101, 30);
            label2.Name = "label2";
            label2.Size = new Size(180, 40);
            label2.TabIndex = 0;
            label2.Text = "GreenLoop";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1444, 866);
            Controls.Add(panel1);
            Controls.Add(painel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        public WiLBiT.WiLBiTButton btnVoltar;

        #endregion

        public static Label label2;
        public static Panel painel;
        public static Panel panel1;
    }
}
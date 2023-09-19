namespace pi_serasa_greenloop
{
    partial class recompensas
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
            painelConteudo = new Panel();
            lblNadaAinda = new Label();
            label12 = new Label();
            lblSeusPontos = new Label();
            label11 = new Label();
            pnlMenuCima = new Panel();
            wilBitPanel6 = new WiLBiT.WiLBiTPanel();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            wilBitButton5 = new WiLBiT.WiLBiTButton();
            painelConteudo.SuspendLayout();
            pnlMenuCima.SuspendLayout();
            wilBitPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // painelConteudo
            // 
            painelConteudo.Anchor = AnchorStyles.None;
            painelConteudo.AutoScroll = true;
            painelConteudo.BackColor = Color.FromArgb(66, 11, 62);
            painelConteudo.Controls.Add(lblNadaAinda);
            painelConteudo.Location = new Point(132, 131);
            painelConteudo.Name = "painelConteudo";
            painelConteudo.Size = new Size(963, 254);
            painelConteudo.TabIndex = 0;
            // 
            // lblNadaAinda
            // 
            lblNadaAinda.AutoSize = true;
            lblNadaAinda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNadaAinda.ForeColor = Color.White;
            lblNadaAinda.Location = new Point(246, 133);
            lblNadaAinda.Name = "lblNadaAinda";
            lblNadaAinda.Size = new Size(534, 75);
            lblNadaAinda.TabIndex = 1;
            lblNadaAinda.Text = "Ocorreu um erro inesperado \r\nque impediu o carregamento apropriado de Recompensas.\r\nDesculpe pelo transtorno :(\r\n";
            lblNadaAinda.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(398, 12);
            label12.Name = "label12";
            label12.Size = new Size(186, 35);
            label12.TabIndex = 3;
            label12.Text = "Recompensas";
            // 
            // lblSeusPontos
            // 
            lblSeusPontos.AutoSize = true;
            lblSeusPontos.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeusPontos.ForeColor = Color.White;
            lblSeusPontos.Location = new Point(192, 59);
            lblSeusPontos.Name = "lblSeusPontos";
            lblSeusPontos.Size = new Size(31, 35);
            lblSeusPontos.TabIndex = 2;
            lblSeusPontos.Text = "0";
            lblSeusPontos.Click += lblSeusPontos_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 59);
            label11.Name = "label11";
            label11.Size = new Size(183, 35);
            label11.TabIndex = 1;
            label11.Text = "Seus Pontos -";
            // 
            // pnlMenuCima
            // 
            pnlMenuCima.Anchor = AnchorStyles.Top;
            pnlMenuCima.Controls.Add(label12);
            pnlMenuCima.Controls.Add(label11);
            pnlMenuCima.Controls.Add(lblSeusPontos);
            pnlMenuCima.Location = new Point(132, 0);
            pnlMenuCima.Name = "pnlMenuCima";
            pnlMenuCima.Size = new Size(950, 101);
            pnlMenuCima.TabIndex = 4;
            // 
            // wilBitPanel6
            // 
            wilBitPanel6.BackColor = Color.LimeGreen;
            wilBitPanel6.BorderColor = Color.PaleVioletRed;
            wilBitPanel6.BorderRadius = 40;
            wilBitPanel6.BorderSize = 0;
            wilBitPanel6.Controls.Add(label16);
            wilBitPanel6.Controls.Add(label17);
            wilBitPanel6.Controls.Add(label18);
            wilBitPanel6.Controls.Add(wilBitButton5);
            wilBitPanel6.ForeColor = Color.White;
            wilBitPanel6.Location = new Point(-275, 375);
            wilBitPanel6.Name = "wilBitPanel6";
            wilBitPanel6.Size = new Size(244, 199);
            wilBitPanel6.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(50, 57);
            label16.Name = "label16";
            label16.Size = new Size(31, 35);
            label16.TabIndex = 3;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(78, 57);
            label17.Name = "label17";
            label17.Size = new Size(99, 35);
            label17.TabIndex = 2;
            label17.Text = "Pontos";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(20, 22);
            label18.Name = "label18";
            label18.Size = new Size(198, 35);
            label18.TabIndex = 1;
            label18.Text = "Recompensa 1";
            // 
            // wilBitButton5
            // 
            wilBitButton5.BackColor = Color.MediumVioletRed;
            wilBitButton5.BorderColor = Color.Transparent;
            wilBitButton5.BorderRadius = 20;
            wilBitButton5.BorderSize = 0;
            wilBitButton5.FlatAppearance.BorderSize = 0;
            wilBitButton5.FlatStyle = FlatStyle.Flat;
            wilBitButton5.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            wilBitButton5.ForeColor = Color.White;
            wilBitButton5.Location = new Point(20, 135);
            wilBitButton5.Name = "wilBitButton5";
            wilBitButton5.Size = new Size(208, 36);
            wilBitButton5.TabIndex = 0;
            wilBitButton5.Text = "Resgatar";
            wilBitButton5.UseVisualStyleBackColor = false;
            // 
            // recompensas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1210, 773);
            Controls.Add(pnlMenuCima);
            Controls.Add(painelConteudo);
            Controls.Add(wilBitPanel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recompensas";
            Text = "recompensas";
            Load += recompensas_Load_1;
            painelConteudo.ResumeLayout(false);
            painelConteudo.PerformLayout();
            pnlMenuCima.ResumeLayout(false);
            pnlMenuCima.PerformLayout();
            wilBitPanel6.ResumeLayout(false);
            wilBitPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelConteudo;
        private Label label11;
        private Label lblSeusPontos;
        private Label label12;
        private Panel pnlMenuCima;
        private WiLBiT.WiLBiTPanel wilBitPanel6;
        private Label label16;
        private Label label17;
        private Label label18;
        private WiLBiT.WiLBiTButton wilBitButton5;
        private Label lblNadaAinda;
    }
}
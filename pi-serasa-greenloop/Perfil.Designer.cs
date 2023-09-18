namespace pi_serasa_greenloop
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            pnlPerfil = new WiLBiT.WiLBiTPanel();
            label2 = new Label();
            pnlMeusPremios = new Panel();
            lblNadaAinda = new Label();
            btnExcluirConta_Usuário = new WiLBiT.WiLBiTButton();
            lblCpf = new Label();
            label8 = new Label();
            lblNasciemnto = new Label();
            label5 = new Label();
            lblEmail = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ptbPerfilAvatar = new WiLBiT.WiLBiTRoundedPictureBox();
            label4 = new Label();
            lblPontos = new Label();
            lblNome = new Label();
            pnlPerfil.SuspendLayout();
            pnlMeusPremios.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPerfilAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlPerfil
            // 
            pnlPerfil.Anchor = AnchorStyles.None;
            pnlPerfil.AutoSize = true;
            pnlPerfil.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlPerfil.BackColor = Color.DarkViolet;
            pnlPerfil.BorderColor = Color.OldLace;
            pnlPerfil.BorderRadius = 11;
            pnlPerfil.BorderSize = 0;
            pnlPerfil.Controls.Add(label2);
            pnlPerfil.Controls.Add(pnlMeusPremios);
            pnlPerfil.Controls.Add(btnExcluirConta_Usuário);
            pnlPerfil.Controls.Add(lblCpf);
            pnlPerfil.Controls.Add(label8);
            pnlPerfil.Controls.Add(lblNasciemnto);
            pnlPerfil.Controls.Add(label5);
            pnlPerfil.Controls.Add(lblEmail);
            pnlPerfil.Controls.Add(label1);
            pnlPerfil.Controls.Add(panel1);
            pnlPerfil.ForeColor = Color.SeaShell;
            pnlPerfil.Location = new Point(138, 81);
            pnlPerfil.Margin = new Padding(2);
            pnlPerfil.Name = "pnlPerfil";
            pnlPerfil.Size = new Size(1120, 529);
            pnlPerfil.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(762, 25);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 1;
            label2.Text = "Meus Prêmios";
            // 
            // pnlMeusPremios
            // 
            pnlMeusPremios.AutoScroll = true;
            pnlMeusPremios.BackColor = Color.FromArgb(66, 11, 62);
            pnlMeusPremios.Controls.Add(lblNadaAinda);
            pnlMeusPremios.Location = new Point(480, 58);
            pnlMeusPremios.Name = "pnlMeusPremios";
            pnlMeusPremios.Size = new Size(637, 468);
            pnlMeusPremios.TabIndex = 17;
            pnlMeusPremios.Paint += pnlMeusPremios_Paint;
            // 
            // lblNadaAinda
            // 
            lblNadaAinda.AutoSize = true;
            lblNadaAinda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNadaAinda.Location = new Point(150, 192);
            lblNadaAinda.Name = "lblNadaAinda";
            lblNadaAinda.Size = new Size(424, 75);
            lblNadaAinda.TabIndex = 0;
            lblNadaAinda.Text = "Poxa! Você ainda não tem prêmios! :(\r\nPara resolver isso, leve seu lixo reciclável até o \r\nPolo de Reciclagem mais próximo de você!\r\n";
            lblNadaAinda.Visible = false;
            // 
            // btnExcluirConta_Usuário
            // 
            btnExcluirConta_Usuário.BackColor = Color.Blue;
            btnExcluirConta_Usuário.BorderColor = Color.FromArgb(72, 116, 245);
            btnExcluirConta_Usuário.BorderRadius = 6;
            btnExcluirConta_Usuário.BorderSize = 0;
            btnExcluirConta_Usuário.FlatAppearance.BorderSize = 0;
            btnExcluirConta_Usuário.FlatStyle = FlatStyle.Flat;
            btnExcluirConta_Usuário.ForeColor = Color.White;
            btnExcluirConta_Usuário.Location = new Point(377, 504);
            btnExcluirConta_Usuário.Name = "btnExcluirConta_Usuário";
            btnExcluirConta_Usuário.Size = new Size(94, 22);
            btnExcluirConta_Usuário.TabIndex = 15;
            btnExcluirConta_Usuário.Text = "Sair da Conta";
            btnExcluirConta_Usuário.UseVisualStyleBackColor = false;
            btnExcluirConta_Usuário.Click += btnExcluirConta_Usuário_Click_1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCpf.Location = new Point(40, 436);
            lblCpf.Margin = new Padding(2, 0, 2, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(193, 30);
            lblCpf.TabIndex = 14;
            lblCpf.Text = "\"CPF do Usuário\"";
            lblCpf.Click += lblCpf_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(40, 416);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 13;
            label8.Text = "CPF";
            // 
            // lblNasciemnto
            // 
            lblNasciemnto.AutoSize = true;
            lblNasciemnto.BackColor = Color.Transparent;
            lblNasciemnto.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNasciemnto.Location = new Point(40, 360);
            lblNasciemnto.Margin = new Padding(2, 0, 2, 0);
            lblNasciemnto.Name = "lblNasciemnto";
            lblNasciemnto.Size = new Size(364, 30);
            lblNasciemnto.TabIndex = 12;
            lblNasciemnto.Text = "\"Data de Nascimento do Usuário\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 340);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 11;
            label5.Text = "Data de Nascimento";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEmail.Location = new Point(40, 284);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(218, 30);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "\"e-mail do usuário\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 264);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 9;
            label1.Text = "E-mail";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(ptbPerfilAvatar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblPontos);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 260);
            panel1.TabIndex = 16;
            // 
            // ptbPerfilAvatar
            // 
            ptbPerfilAvatar.BackColor = Color.Transparent;
            ptbPerfilAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            ptbPerfilAvatar.BorderColor = Color.Lime;
            ptbPerfilAvatar.BorderColor2 = Color.Lime;
            ptbPerfilAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            ptbPerfilAvatar.BorderSize = 2;
            ptbPerfilAvatar.GradientAngle = 50F;
            ptbPerfilAvatar.Image = (Image)resources.GetObject("ptbPerfilAvatar.Image");
            ptbPerfilAvatar.Location = new Point(11, 26);
            ptbPerfilAvatar.Margin = new Padding(2);
            ptbPerfilAvatar.Name = "ptbPerfilAvatar";
            ptbPerfilAvatar.Size = new Size(205, 205);
            ptbPerfilAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPerfilAvatar.TabIndex = 8;
            ptbPerfilAvatar.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(220, 103);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 4;
            label4.Text = "Pontos - ";
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.BackColor = Color.Transparent;
            lblPontos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontos.Location = new Point(307, 103);
            lblPontos.Margin = new Padding(2, 0, 2, 0);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(23, 25);
            lblPontos.TabIndex = 5;
            lblPontos.Text = "0";
            lblPontos.Click += lblPontos_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(220, 58);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(184, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "\"Nome de Usuário\"";
            lblNome.Click += lblNome_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 3, 21);
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlPerfil);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Perfil";
            Text = "Perfil";
            Load += Perfil_Load_1;
            pnlPerfil.ResumeLayout(false);
            pnlPerfil.PerformLayout();
            pnlMeusPremios.ResumeLayout(false);
            pnlMeusPremios.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPerfilAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTPanel pnlPerfil;
        private Label lblNome;
        private Label label8;
        private Label lblNasciemnto;
        private Label label5;
        private Label lblEmail;
        private Label label1;
        private Label lblCpf;
        private WiLBiT.WiLBiTButton btnExcluirConta_Usuário;
        private Panel panel1;
        private WiLBiT.WiLBiTRoundedPictureBox ptbPerfilAvatar;
        private Label label4;
        private Label lblPontos;
        private Panel pnlMeusPremios;
        private Label lblNadaAinda;
        private Label label2;
    }
}
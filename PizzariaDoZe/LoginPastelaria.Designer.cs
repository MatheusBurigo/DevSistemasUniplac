namespace PizzariaDoZe
{
    partial class LoginPastelaria
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPastelaria));
            labelIdioma = new Label();
            comboBoxIdiomaLogin = new ComboBox();
            buttonLogin = new Button();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            labelCpf = new Label();
            pictureBox1 = new PictureBox();
            systemTray = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItemShow = new ToolStripMenuItem();
            toolStripMenuItemInfo = new ToolStripMenuItem();
            toolStripMenuItemClose = new ToolStripMenuItem();
            maskedTextBoxCpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdioma.Location = new Point(168, 448);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(53, 19);
            labelIdioma.TabIndex = 15;
            labelIdioma.Text = "Idioma";
            // 
            // comboBoxIdiomaLogin
            // 
            comboBoxIdiomaLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdiomaLogin.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxIdiomaLogin.FormattingEnabled = true;
            comboBoxIdiomaLogin.Location = new Point(168, 468);
            comboBoxIdiomaLogin.Margin = new Padding(3, 2, 3, 2);
            comboBoxIdiomaLogin.MaxDropDownItems = 3;
            comboBoxIdiomaLogin.Name = "comboBoxIdiomaLogin";
            comboBoxIdiomaLogin.Size = new Size(219, 27);
            comboBoxIdiomaLogin.TabIndex = 13;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(227, 395);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(97, 36);
            buttonLogin.TabIndex = 14;
            buttonLogin.TabStop = false;
            buttonLogin.Text = "Entrar";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha.Location = new Point(168, 332);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(219, 27);
            textBoxSenha.TabIndex = 10;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.Location = new Point(168, 310);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(48, 19);
            labelSenha.TabIndex = 12;
            labelSenha.Text = "Senha";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(168, 242);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 19);
            labelCpf.TabIndex = 11;
            labelCpf.Text = "CPF";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logoZe_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.logoZe;
            pictureBox1.InitialImage = Properties.Resources.logoZe;
            pictureBox1.Location = new Point(178, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // systemTray
            // 
            systemTray.BalloonTipIcon = ToolTipIcon.Info;
            systemTray.BalloonTipText = "Pizzaria do Zé";
            systemTray.BalloonTipTitle = "O programa está em segundo plano";
            systemTray.Icon = (Icon)resources.GetObject("systemTray.Icon");
            systemTray.Text = "Pizzaria do Zé";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemShow, toolStripMenuItemInfo, toolStripMenuItemClose });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(204, 70);
            // 
            // toolStripMenuItemShow
            // 
            toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            toolStripMenuItemShow.Size = new Size(203, 22);
            toolStripMenuItemShow.Text = "toolStripMenuItemShow";
            // 
            // toolStripMenuItemInfo
            // 
            toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            toolStripMenuItemInfo.Size = new Size(203, 22);
            toolStripMenuItemInfo.Text = "toolStripMenuItemInfo";
            // 
            // toolStripMenuItemClose
            // 
            toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            toolStripMenuItemClose.Size = new Size(203, 22);
            toolStripMenuItemClose.Text = "toolStripMenuItemClose";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCpf.Location = new Point(168, 262);
            maskedTextBoxCpf.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCpf.Mask = "999,999,999-99";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(219, 27);
            maskedTextBoxCpf.TabIndex = 9;
            maskedTextBoxCpf.MaskInputRejected += maskedTextBoxCpf_MaskInputRejected;
            // 
            // LoginPastelaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 510);
            Controls.Add(labelIdioma);
            Controls.Add(comboBoxIdiomaLogin);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelCpf);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBoxCpf);
            Name = "LoginPastelaria";
            Text = "LoginPastelaria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdioma;
        private ComboBox comboBoxIdiomaLogin;
        private Button buttonLogin;
        private TextBox textBoxSenha;
        private Label labelSenha;
        private Label labelCpf;
        private PictureBox pictureBox1;
        private NotifyIcon systemTray;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuItemShow;
        private ToolStripMenuItem toolStripMenuItemInfo;
        private ToolStripMenuItem toolStripMenuItemClose;
        private MaskedTextBox maskedTextBoxCpf;
    }
}
namespace PizzariaDoZe
{
    partial class Configuracoes
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
            labelTitleConfiguracoes = new Label();
            buttonFecharConfig = new Button();
            tabControlConfig = new TabControl();
            tabPageIdioma = new TabPage();
            labelIdioma = new Label();
            comboBoxIdiomaConfig = new ComboBox();
            tabControlConfig.SuspendLayout();
            tabPageIdioma.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitleConfiguracoes
            // 
            labelTitleConfiguracoes.AutoSize = true;
            labelTitleConfiguracoes.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleConfiguracoes.Location = new Point(391, 9);
            labelTitleConfiguracoes.Name = "labelTitleConfiguracoes";
            labelTitleConfiguracoes.Size = new Size(216, 41);
            labelTitleConfiguracoes.TabIndex = 83;
            labelTitleConfiguracoes.Text = "Configurações";
            // 
            // buttonFecharConfig
            // 
            buttonFecharConfig.BackColor = Color.Blue;
            buttonFecharConfig.Image = Properties.Resources.cancelicon;
            buttonFecharConfig.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharConfig.Location = new Point(444, 461);
            buttonFecharConfig.Margin = new Padding(0);
            buttonFecharConfig.Name = "buttonFecharConfig";
            buttonFecharConfig.Padding = new Padding(5, 0, 5, 0);
            buttonFecharConfig.Size = new Size(102, 48);
            buttonFecharConfig.TabIndex = 84;
            buttonFecharConfig.TabStop = false;
            buttonFecharConfig.Text = "Fechar";
            buttonFecharConfig.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharConfig.UseVisualStyleBackColor = false;
            buttonFecharConfig.Click += buttonFecharConfig_Click;
            // 
            // tabControlConfig
            // 
            tabControlConfig.Controls.Add(tabPageIdioma);
            tabControlConfig.Location = new Point(83, 122);
            tabControlConfig.Name = "tabControlConfig";
            tabControlConfig.SelectedIndex = 0;
            tabControlConfig.Size = new Size(861, 271);
            tabControlConfig.TabIndex = 85;
            tabControlConfig.TabStop = false;
            // 
            // tabPageIdioma
            // 
            tabPageIdioma.BackColor = SystemColors.ActiveCaption;
            tabPageIdioma.Controls.Add(labelIdioma);
            tabPageIdioma.Controls.Add(comboBoxIdiomaConfig);
            tabPageIdioma.Location = new Point(4, 33);
            tabPageIdioma.Name = "tabPageIdioma";
            tabPageIdioma.Padding = new Padding(3);
            tabPageIdioma.Size = new Size(853, 234);
            tabPageIdioma.TabIndex = 0;
            tabPageIdioma.Text = "Idioma";
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdioma.Location = new Point(22, 22);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(68, 24);
            labelIdioma.TabIndex = 9;
            labelIdioma.Text = "Idioma";
            // 
            // comboBoxIdiomaConfig
            // 
            comboBoxIdiomaConfig.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdiomaConfig.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxIdiomaConfig.FormattingEnabled = true;
            comboBoxIdiomaConfig.Location = new Point(22, 49);
            comboBoxIdiomaConfig.MaxDropDownItems = 3;
            comboBoxIdiomaConfig.Name = "comboBoxIdiomaConfig";
            comboBoxIdiomaConfig.Size = new Size(250, 32);
            comboBoxIdiomaConfig.TabIndex = 0;
            comboBoxIdiomaConfig.SelectedValueChanged += comboBoxIdiomaConfig_SelectedValueChanged;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 540);
            Controls.Add(tabControlConfig);
            Controls.Add(buttonFecharConfig);
            Controls.Add(labelTitleConfiguracoes);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Configuracoes";
            Text = "Configuracoes";
            tabControlConfig.ResumeLayout(false);
            tabPageIdioma.ResumeLayout(false);
            tabPageIdioma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleConfiguracoes;
        private Button buttonFecharConfig;
        private TabControl tabControlConfig;
        private TabPage tabPageIdioma;
        private Label labelIdioma;
        private ComboBox comboBoxIdiomaConfig;
    }
}
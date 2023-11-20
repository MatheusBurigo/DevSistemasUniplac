namespace PizzariaDoZe
{
    partial class CadastroLogradouro
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            maskedTextBoxCepCadastroLogradouro = new MaskedTextBox();
            comboBoxUfCadastroLogradouro = new ComboBox();
            comboBoxPaisCadastroLogradouro = new ComboBox();
            comboBoxCidadeCadastroLogradouro = new ComboBox();
            textBoxBairroCadastroLogradouro = new TextBox();
            textBoxLogradouroCadastroLogradouro = new TextBox();
            textBoxIdCadastroLogradouro = new TextBox();
            labelPais = new Label();
            labelUf = new Label();
            labelCidade = new Label();
            labelBairro = new Label();
            labelIdCadastroLogradouro = new Label();
            labelCep = new Label();
            labelLogradouro = new Label();
            buttonFecharCadastroLogradouro = new Button();
            buttonExcluirCadastroLogradouro = new Button();
            buttonEditarCadastroLogradouro = new Button();
            buttonSalvarCadastroLogradouro = new Button();
            labelTitleCadastroLogradouro = new Label();
            buttonPesquisaCadastroIngredientes = new Button();
            ListaEnderecos = new DataGridView();
            textBoxPesquisaCadastroIngredientes = new TextBox();
            labelEnderecosCadastroLogradouro = new Label();
            ((System.ComponentModel.ISupportInitialize)ListaEnderecos).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBoxCepCadastroLogradouro
            // 
            maskedTextBoxCepCadastroLogradouro.Location = new Point(105, 148);
            maskedTextBoxCepCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxCepCadastroLogradouro.Mask = "00000-000";
            maskedTextBoxCepCadastroLogradouro.Name = "maskedTextBoxCepCadastroLogradouro";
            maskedTextBoxCepCadastroLogradouro.Size = new Size(107, 27);
            maskedTextBoxCepCadastroLogradouro.TabIndex = 0;
            maskedTextBoxCepCadastroLogradouro.KeyDown += checkKeyDown;
            // 
            // comboBoxUfCadastroLogradouro
            // 
            comboBoxUfCadastroLogradouro.FormattingEnabled = true;
            comboBoxUfCadastroLogradouro.Location = new Point(258, 261);
            comboBoxUfCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            comboBoxUfCadastroLogradouro.Name = "comboBoxUfCadastroLogradouro";
            comboBoxUfCadastroLogradouro.Size = new Size(232, 27);
            comboBoxUfCadastroLogradouro.TabIndex = 3;
            comboBoxUfCadastroLogradouro.KeyDown += checkKeyDown;
            // 
            // comboBoxPaisCadastroLogradouro
            // 
            comboBoxPaisCadastroLogradouro.FormattingEnabled = true;
            comboBoxPaisCadastroLogradouro.Location = new Point(12, 261);
            comboBoxPaisCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            comboBoxPaisCadastroLogradouro.Name = "comboBoxPaisCadastroLogradouro";
            comboBoxPaisCadastroLogradouro.Size = new Size(238, 27);
            comboBoxPaisCadastroLogradouro.TabIndex = 2;
            comboBoxPaisCadastroLogradouro.KeyDown += checkKeyDown;
            // 
            // comboBoxCidadeCadastroLogradouro
            // 
            comboBoxCidadeCadastroLogradouro.FormattingEnabled = true;
            comboBoxCidadeCadastroLogradouro.Location = new Point(12, 398);
            comboBoxCidadeCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            comboBoxCidadeCadastroLogradouro.Name = "comboBoxCidadeCadastroLogradouro";
            comboBoxCidadeCadastroLogradouro.Size = new Size(223, 27);
            comboBoxCidadeCadastroLogradouro.TabIndex = 4;
            comboBoxCidadeCadastroLogradouro.KeyDown += checkKeyDown;
            // 
            // textBoxBairroCadastroLogradouro
            // 
            textBoxBairroCadastroLogradouro.Location = new Point(241, 398);
            textBoxBairroCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            textBoxBairroCadastroLogradouro.Name = "textBoxBairroCadastroLogradouro";
            textBoxBairroCadastroLogradouro.Size = new Size(280, 27);
            textBoxBairroCadastroLogradouro.TabIndex = 5;
            textBoxBairroCadastroLogradouro.KeyDown += checkKeyDown;
            // 
            // textBoxLogradouroCadastroLogradouro
            // 
            textBoxLogradouroCadastroLogradouro.Location = new Point(218, 148);
            textBoxLogradouroCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            textBoxLogradouroCadastroLogradouro.Name = "textBoxLogradouroCadastroLogradouro";
            textBoxLogradouroCadastroLogradouro.Size = new Size(248, 27);
            textBoxLogradouroCadastroLogradouro.TabIndex = 1;
            textBoxLogradouroCadastroLogradouro.KeyDown += checkKeyDown;
            // 
            // textBoxIdCadastroLogradouro
            // 
            textBoxIdCadastroLogradouro.Location = new Point(12, 148);
            textBoxIdCadastroLogradouro.Margin = new Padding(3, 4, 3, 4);
            textBoxIdCadastroLogradouro.Name = "textBoxIdCadastroLogradouro";
            textBoxIdCadastroLogradouro.ReadOnly = true;
            textBoxIdCadastroLogradouro.Size = new Size(82, 27);
            textBoxIdCadastroLogradouro.TabIndex = 63;
            textBoxIdCadastroLogradouro.TabStop = false;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPais.Location = new Point(12, 233);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(36, 19);
            labelPais.TabIndex = 62;
            labelPais.Text = "País";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUf.Location = new Point(258, 233);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(26, 19);
            labelUf.TabIndex = 61;
            labelUf.Text = "UF";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCidade.Location = new Point(12, 370);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(54, 19);
            labelCidade.TabIndex = 60;
            labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBairro.Location = new Point(241, 370);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(48, 19);
            labelBairro.TabIndex = 59;
            labelBairro.Text = "Bairro";
            // 
            // labelIdCadastroLogradouro
            // 
            labelIdCadastroLogradouro.AutoSize = true;
            labelIdCadastroLogradouro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdCadastroLogradouro.Location = new Point(12, 120);
            labelIdCadastroLogradouro.Name = "labelIdCadastroLogradouro";
            labelIdCadastroLogradouro.Size = new Size(23, 19);
            labelIdCadastroLogradouro.TabIndex = 58;
            labelIdCadastroLogradouro.Text = "ID";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCep.Location = new Point(105, 120);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 19);
            labelCep.TabIndex = 57;
            labelCep.Text = "CEP";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogradouro.Location = new Point(218, 120);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(82, 19);
            labelLogradouro.TabIndex = 56;
            labelLogradouro.Text = "Logradouro";
            // 
            // buttonFecharCadastroLogradouro
            // 
            buttonFecharCadastroLogradouro.BackColor = Color.Blue;
            buttonFecharCadastroLogradouro.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroLogradouro.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroLogradouro.Location = new Point(765, 513);
            buttonFecharCadastroLogradouro.Margin = new Padding(0);
            buttonFecharCadastroLogradouro.Name = "buttonFecharCadastroLogradouro";
            buttonFecharCadastroLogradouro.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroLogradouro.Size = new Size(102, 48);
            buttonFecharCadastroLogradouro.TabIndex = 82;
            buttonFecharCadastroLogradouro.TabStop = false;
            buttonFecharCadastroLogradouro.Text = "Fechar";
            buttonFecharCadastroLogradouro.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroLogradouro.UseVisualStyleBackColor = false;
            buttonFecharCadastroLogradouro.Click += buttonFecharCadastroLogradouro_Click;
            // 
            // buttonExcluirCadastroLogradouro
            // 
            buttonExcluirCadastroLogradouro.BackColor = Color.Red;
            buttonExcluirCadastroLogradouro.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroLogradouro.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroLogradouro.Location = new Point(648, 513);
            buttonExcluirCadastroLogradouro.Margin = new Padding(0);
            buttonExcluirCadastroLogradouro.Name = "buttonExcluirCadastroLogradouro";
            buttonExcluirCadastroLogradouro.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroLogradouro.Size = new Size(102, 48);
            buttonExcluirCadastroLogradouro.TabIndex = 81;
            buttonExcluirCadastroLogradouro.TabStop = false;
            buttonExcluirCadastroLogradouro.Text = "Excluir";
            buttonExcluirCadastroLogradouro.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroLogradouro.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCadastroLogradouro
            // 
            buttonEditarCadastroLogradouro.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroLogradouro.Image = Properties.Resources.editicon;
            buttonEditarCadastroLogradouro.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroLogradouro.Location = new Point(531, 513);
            buttonEditarCadastroLogradouro.Margin = new Padding(0);
            buttonEditarCadastroLogradouro.Name = "buttonEditarCadastroLogradouro";
            buttonEditarCadastroLogradouro.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroLogradouro.Size = new Size(102, 48);
            buttonEditarCadastroLogradouro.TabIndex = 80;
            buttonEditarCadastroLogradouro.TabStop = false;
            buttonEditarCadastroLogradouro.Text = "Editar";
            buttonEditarCadastroLogradouro.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroLogradouro.UseVisualStyleBackColor = false;
            // 
            // buttonSalvarCadastroLogradouro
            // 
            buttonSalvarCadastroLogradouro.BackColor = Color.YellowGreen;
            buttonSalvarCadastroLogradouro.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroLogradouro.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroLogradouro.Location = new Point(413, 513);
            buttonSalvarCadastroLogradouro.Margin = new Padding(0);
            buttonSalvarCadastroLogradouro.Name = "buttonSalvarCadastroLogradouro";
            buttonSalvarCadastroLogradouro.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroLogradouro.Size = new Size(102, 48);
            buttonSalvarCadastroLogradouro.TabIndex = 79;
            buttonSalvarCadastroLogradouro.TabStop = false;
            buttonSalvarCadastroLogradouro.Text = "Salvar";
            buttonSalvarCadastroLogradouro.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroLogradouro.UseVisualStyleBackColor = false;
            buttonSalvarCadastroLogradouro.Click += buttonSalvarCadastroLogradouro_Click;
            // 
            // labelTitleCadastroLogradouro
            // 
            labelTitleCadastroLogradouro.AutoSize = true;
            labelTitleCadastroLogradouro.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCadastroLogradouro.Location = new Point(84, 32);
            labelTitleCadastroLogradouro.Name = "labelTitleCadastroLogradouro";
            labelTitleCadastroLogradouro.Size = new Size(283, 33);
            labelTitleCadastroLogradouro.TabIndex = 83;
            labelTitleCadastroLogradouro.Text = "Cadastro de Logradouro";
            // 
            // buttonPesquisaCadastroIngredientes
            // 
            buttonPesquisaCadastroIngredientes.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroIngredientes.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroIngredientes.Image = Properties.Resources.search;
            buttonPesquisaCadastroIngredientes.Location = new Point(1001, 62);
            buttonPesquisaCadastroIngredientes.Margin = new Padding(0);
            buttonPesquisaCadastroIngredientes.Name = "buttonPesquisaCadastroIngredientes";
            buttonPesquisaCadastroIngredientes.Padding = new Padding(5, 0, 5, 0);
            buttonPesquisaCadastroIngredientes.Size = new Size(44, 32);
            buttonPesquisaCadastroIngredientes.TabIndex = 87;
            buttonPesquisaCadastroIngredientes.TabStop = false;
            buttonPesquisaCadastroIngredientes.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisaCadastroIngredientes.UseVisualStyleBackColor = false;
            buttonPesquisaCadastroIngredientes.Click += buttonPesquisaCadastroIngredientes_Click;
            // 
            // ListaEnderecos
            // 
            ListaEnderecos.AllowUserToAddRows = false;
            ListaEnderecos.AllowUserToDeleteRows = false;
            ListaEnderecos.AllowUserToOrderColumns = true;
            ListaEnderecos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ListaEnderecos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaEnderecos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaEnderecos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaEnderecos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaEnderecos.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaEnderecos.GridColor = SystemColors.InactiveCaption;
            ListaEnderecos.Location = new Point(675, 120);
            ListaEnderecos.MultiSelect = false;
            ListaEnderecos.Name = "ListaEnderecos";
            ListaEnderecos.ReadOnly = true;
            ListaEnderecos.RowHeadersVisible = false;
            ListaEnderecos.RowHeadersWidth = 51;
            ListaEnderecos.RowTemplate.Height = 29;
            ListaEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaEnderecos.ShowEditingIcon = false;
            ListaEnderecos.Size = new Size(724, 319);
            ListaEnderecos.TabIndex = 86;
            // 
            // textBoxPesquisaCadastroIngredientes
            // 
            textBoxPesquisaCadastroIngredientes.Location = new Point(675, 62);
            textBoxPesquisaCadastroIngredientes.Name = "textBoxPesquisaCadastroIngredientes";
            textBoxPesquisaCadastroIngredientes.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroIngredientes.Size = new Size(323, 27);
            textBoxPesquisaCadastroIngredientes.TabIndex = 85;
            // 
            // labelEnderecosCadastroLogradouro
            // 
            labelEnderecosCadastroLogradouro.AutoSize = true;
            labelEnderecosCadastroLogradouro.Location = new Point(675, 35);
            labelEnderecosCadastroLogradouro.Name = "labelEnderecosCadastroLogradouro";
            labelEnderecosCadastroLogradouro.Size = new Size(76, 19);
            labelEnderecosCadastroLogradouro.TabIndex = 84;
            labelEnderecosCadastroLogradouro.Text = "Endereços";
            // 
            // CadastroLogradouro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1411, 570);
            Controls.Add(buttonPesquisaCadastroIngredientes);
            Controls.Add(ListaEnderecos);
            Controls.Add(textBoxPesquisaCadastroIngredientes);
            Controls.Add(labelEnderecosCadastroLogradouro);
            Controls.Add(labelTitleCadastroLogradouro);
            Controls.Add(buttonFecharCadastroLogradouro);
            Controls.Add(buttonExcluirCadastroLogradouro);
            Controls.Add(buttonEditarCadastroLogradouro);
            Controls.Add(buttonSalvarCadastroLogradouro);
            Controls.Add(maskedTextBoxCepCadastroLogradouro);
            Controls.Add(comboBoxUfCadastroLogradouro);
            Controls.Add(comboBoxPaisCadastroLogradouro);
            Controls.Add(comboBoxCidadeCadastroLogradouro);
            Controls.Add(textBoxBairroCadastroLogradouro);
            Controls.Add(textBoxLogradouroCadastroLogradouro);
            Controls.Add(textBoxIdCadastroLogradouro);
            Controls.Add(labelPais);
            Controls.Add(labelUf);
            Controls.Add(labelCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelIdCadastroLogradouro);
            Controls.Add(labelCep);
            Controls.Add(labelLogradouro);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroLogradouro";
            Text = "CadastroLogradouro";
            ((System.ComponentModel.ISupportInitialize)ListaEnderecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxCepCadastroLogradouro;
        private ComboBox comboBoxUfCadastroLogradouro;
        private ComboBox comboBoxPaisCadastroLogradouro;
        private ComboBox comboBoxCidadeCadastroLogradouro;
        private TextBox textBoxBairroCadastroLogradouro;
        private TextBox textBoxLogradouroCadastroLogradouro;
        private TextBox textBoxIdCadastroLogradouro;
        private Label labelPais;
        private Label labelUf;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelIdCadastroLogradouro;
        private Label labelCep;
        private Label labelLogradouro;
        private Button buttonFecharCadastroLogradouro;
        private Button buttonExcluirCadastroLogradouro;
        private Button buttonEditarCadastroLogradouro;
        private Button buttonSalvarCadastroLogradouro;
        private Label labelTitleCadastroLogradouro;
        private Button buttonPesquisaCadastroIngredientes;
        private DataGridView ListaEnderecos;
        private TextBox textBoxPesquisaCadastroIngredientes;
        private Label labelEnderecosCadastroLogradouro;
    }
}
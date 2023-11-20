namespace PizzariaDoZe
{
    partial class CadastroCliente
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
            labelIdCadastroCliente = new Label();
            labelNome = new Label();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
            labelComplemento = new Label();
            labelNumero = new Label();
            labelLogradouro = new Label();
            labelCep = new Label();
            labelIdLogradouroCadastroCliente = new Label();
            labelBairro = new Label();
            labelCidade = new Label();
            labelUf = new Label();
            labelPais = new Label();
            textBoxIdCadastroCliente = new TextBox();
            textBoxNomeCadastroCliente = new TextBox();
            textBoxEmailCadastroCliente = new TextBox();
            textBoxIdLogradouroCadastroCliente = new TextBox();
            textBoxLogradouroCadastroCliente = new TextBox();
            textBoxBairroCadastroCliente = new TextBox();
            textBoxNumeroCadastroCliente = new TextBox();
            textBoxComplementoCadastroCliente = new TextBox();
            comboBoxCidadeCadastroCliente = new ComboBox();
            comboBoxPaisCadastroCliente = new ComboBox();
            comboBoxUfCadastroCliente = new ComboBox();
            buttonFecharCadastroCliente = new Button();
            buttonExcluirCadastroCliente = new Button();
            buttonEditarCadastroCliente = new Button();
            buttonSalvarCadastroCliente = new Button();
            maskedTextBoxCpfCadastroCliente = new MaskedTextBox();
            maskedTextBoxTelefoneCadastroCliente = new MaskedTextBox();
            maskedTextBoxCepCadastroCliente = new MaskedTextBox();
            labelTitleCadastroCliente = new Label();
            buttonPesquisaCadastroIngredientes = new Button();
            ListaClientes = new DataGridView();
            textBoxPesquisaCadastroClientes = new TextBox();
            labelClienteCadastroFuncionarios = new Label();
            ((System.ComponentModel.ISupportInitialize)ListaClientes).BeginInit();
            SuspendLayout();
            // 
            // labelIdCadastroCliente
            // 
            labelIdCadastroCliente.AutoSize = true;
            labelIdCadastroCliente.Enabled = false;
            labelIdCadastroCliente.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdCadastroCliente.Location = new Point(21, 88);
            labelIdCadastroCliente.Name = "labelIdCadastroCliente";
            labelIdCadastroCliente.Size = new Size(23, 19);
            labelIdCadastroCliente.TabIndex = 0;
            labelIdCadastroCliente.Text = "ID";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(21, 177);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(47, 19);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(180, 285);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(50, 19);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "E-mail";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(21, 285);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(65, 19);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(103, 88);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 19);
            labelCpf.TabIndex = 5;
            labelCpf.Text = "CPF";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelComplemento.Location = new Point(643, 407);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(99, 19);
            labelComplemento.TabIndex = 6;
            labelComplemento.Text = "Complemento";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.Location = new Point(535, 407);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(60, 19);
            labelNumero.TabIndex = 7;
            labelNumero.Text = "Número";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogradouro.Location = new Point(731, 83);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(82, 19);
            labelLogradouro.TabIndex = 8;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCep.Location = new Point(616, 88);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 19);
            labelCep.TabIndex = 9;
            labelCep.Text = "CEP";
            // 
            // labelIdLogradouroCadastroCliente
            // 
            labelIdLogradouroCadastroCliente.AutoSize = true;
            labelIdLogradouroCadastroCliente.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdLogradouroCadastroCliente.Location = new Point(535, 88);
            labelIdLogradouroCadastroCliente.Name = "labelIdLogradouroCadastroCliente";
            labelIdLogradouroCadastroCliente.Size = new Size(23, 19);
            labelIdLogradouroCadastroCliente.TabIndex = 10;
            labelIdLogradouroCadastroCliente.Text = "ID";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBairro.Location = new Point(807, 285);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(48, 19);
            labelBairro.TabIndex = 11;
            labelBairro.Text = "Bairro";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCidade.Location = new Point(535, 285);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(54, 19);
            labelCidade.TabIndex = 12;
            labelCidade.Text = "Cidade";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUf.Location = new Point(807, 177);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(26, 19);
            labelUf.TabIndex = 13;
            labelUf.Text = "UF";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPais.Location = new Point(535, 177);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(36, 19);
            labelPais.TabIndex = 14;
            labelPais.Text = "País";
            // 
            // textBoxIdCadastroCliente
            // 
            textBoxIdCadastroCliente.Location = new Point(21, 110);
            textBoxIdCadastroCliente.Name = "textBoxIdCadastroCliente";
            textBoxIdCadastroCliente.ReadOnly = true;
            textBoxIdCadastroCliente.Size = new Size(76, 27);
            textBoxIdCadastroCliente.TabIndex = 15;
            textBoxIdCadastroCliente.TabStop = false;
            // 
            // textBoxNomeCadastroCliente
            // 
            textBoxNomeCadastroCliente.Location = new Point(21, 199);
            textBoxNomeCadastroCliente.Name = "textBoxNomeCadastroCliente";
            textBoxNomeCadastroCliente.Size = new Size(423, 27);
            textBoxNomeCadastroCliente.TabIndex = 1;
            textBoxNomeCadastroCliente.KeyDown += checkKeyDown;
            // 
            // textBoxEmailCadastroCliente
            // 
            textBoxEmailCadastroCliente.Location = new Point(180, 307);
            textBoxEmailCadastroCliente.Name = "textBoxEmailCadastroCliente";
            textBoxEmailCadastroCliente.Size = new Size(223, 27);
            textBoxEmailCadastroCliente.TabIndex = 3;
            textBoxEmailCadastroCliente.KeyDown += checkKeyDown;
            // 
            // textBoxLogradouroCadastroCliente
            // 
            textBoxLogradouroCadastroCliente.Location = new Point(731, 110);
            textBoxLogradouroCadastroCliente.Name = "textBoxLogradouroCadastroCliente";
            textBoxLogradouroCadastroCliente.Size = new Size(329, 27);
            textBoxLogradouroCadastroCliente.TabIndex = 5;
            textBoxLogradouroCadastroCliente.KeyDown += checkKeyDown;
            // 
            // textBoxBairroCadastroCliente
            // 
            textBoxBairroCadastroCliente.Location = new Point(807, 307);
            textBoxBairroCadastroCliente.Name = "textBoxBairroCadastroCliente";
            textBoxBairroCadastroCliente.Size = new Size(253, 27);
            textBoxBairroCadastroCliente.TabIndex = 9;
            textBoxBairroCadastroCliente.KeyDown += checkKeyDown;
            // 
            // textBoxNumeroCadastroCliente
            // 
            textBoxNumeroCadastroCliente.Location = new Point(535, 429);
            textBoxNumeroCadastroCliente.Name = "textBoxNumeroCadastroCliente";
            textBoxNumeroCadastroCliente.Size = new Size(102, 27);
            textBoxNumeroCadastroCliente.TabIndex = 10;
            textBoxNumeroCadastroCliente.KeyDown += checkKeyDown;
            // 
            // textBoxComplementoCadastroCliente
            // 
            textBoxComplementoCadastroCliente.Location = new Point(643, 429);
            textBoxComplementoCadastroCliente.Name = "textBoxComplementoCadastroCliente";
            textBoxComplementoCadastroCliente.Size = new Size(337, 27);
            textBoxComplementoCadastroCliente.TabIndex = 11;
            textBoxComplementoCadastroCliente.KeyDown += checkKeyDown;
            // 
            // comboBoxCidadeCadastroCliente
            // 
            comboBoxCidadeCadastroCliente.FormattingEnabled = true;
            comboBoxCidadeCadastroCliente.Location = new Point(535, 307);
            comboBoxCidadeCadastroCliente.Name = "comboBoxCidadeCadastroCliente";
            comboBoxCidadeCadastroCliente.Size = new Size(266, 27);
            comboBoxCidadeCadastroCliente.TabIndex = 8;
            comboBoxCidadeCadastroCliente.KeyDown += checkKeyDown;
            // 
            // comboBoxPaisCadastroCliente
            // 
            comboBoxPaisCadastroCliente.FormattingEnabled = true;
            comboBoxPaisCadastroCliente.Location = new Point(535, 199);
            comboBoxPaisCadastroCliente.Name = "comboBoxPaisCadastroCliente";
            comboBoxPaisCadastroCliente.Size = new Size(266, 27);
            comboBoxPaisCadastroCliente.TabIndex = 6;
            comboBoxPaisCadastroCliente.KeyDown += checkKeyDown;
            // 
            // comboBoxUfCadastroCliente
            // 
            comboBoxUfCadastroCliente.FormattingEnabled = true;
            comboBoxUfCadastroCliente.Location = new Point(807, 199);
            comboBoxUfCadastroCliente.Name = "comboBoxUfCadastroCliente";
            comboBoxUfCadastroCliente.Size = new Size(253, 27);
            comboBoxUfCadastroCliente.TabIndex = 7;
            comboBoxUfCadastroCliente.KeyDown += checkKeyDown;
            // 
            // buttonFecharCadastroCliente
            // 
            buttonFecharCadastroCliente.BackColor = Color.Blue;
            buttonFecharCadastroCliente.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroCliente.Location = new Point(645, 508);
            buttonFecharCadastroCliente.Margin = new Padding(0);
            buttonFecharCadastroCliente.Name = "buttonFecharCadastroCliente";
            buttonFecharCadastroCliente.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroCliente.Size = new Size(102, 48);
            buttonFecharCadastroCliente.TabIndex = 32;
            buttonFecharCadastroCliente.TabStop = false;
            buttonFecharCadastroCliente.Text = "Fechar";
            buttonFecharCadastroCliente.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroCliente.UseVisualStyleBackColor = false;
            buttonFecharCadastroCliente.Click += buttonFecharCadastroCliente_Click;
            // 
            // buttonExcluirCadastroCliente
            // 
            buttonExcluirCadastroCliente.BackColor = Color.Red;
            buttonExcluirCadastroCliente.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroCliente.Location = new Point(528, 508);
            buttonExcluirCadastroCliente.Margin = new Padding(0);
            buttonExcluirCadastroCliente.Name = "buttonExcluirCadastroCliente";
            buttonExcluirCadastroCliente.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroCliente.Size = new Size(102, 48);
            buttonExcluirCadastroCliente.TabIndex = 31;
            buttonExcluirCadastroCliente.TabStop = false;
            buttonExcluirCadastroCliente.Text = "Excluir";
            buttonExcluirCadastroCliente.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroCliente.UseVisualStyleBackColor = false;
            buttonExcluirCadastroCliente.Click += buttonExcluirCadastroCliente_Click;
            // 
            // buttonEditarCadastroCliente
            // 
            buttonEditarCadastroCliente.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroCliente.Image = Properties.Resources.editicon;
            buttonEditarCadastroCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroCliente.Location = new Point(411, 508);
            buttonEditarCadastroCliente.Margin = new Padding(0);
            buttonEditarCadastroCliente.Name = "buttonEditarCadastroCliente";
            buttonEditarCadastroCliente.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroCliente.Size = new Size(102, 48);
            buttonEditarCadastroCliente.TabIndex = 30;
            buttonEditarCadastroCliente.TabStop = false;
            buttonEditarCadastroCliente.Text = "Editar";
            buttonEditarCadastroCliente.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroCliente.UseVisualStyleBackColor = false;
            buttonEditarCadastroCliente.Click += buttonEditarCadastroCliente_Click;
            // 
            // buttonSalvarCadastroCliente
            // 
            buttonSalvarCadastroCliente.BackColor = Color.YellowGreen;
            buttonSalvarCadastroCliente.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroCliente.Location = new Point(293, 508);
            buttonSalvarCadastroCliente.Margin = new Padding(0);
            buttonSalvarCadastroCliente.Name = "buttonSalvarCadastroCliente";
            buttonSalvarCadastroCliente.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroCliente.Size = new Size(102, 48);
            buttonSalvarCadastroCliente.TabIndex = 29;
            buttonSalvarCadastroCliente.TabStop = false;
            buttonSalvarCadastroCliente.Text = "Salvar";
            buttonSalvarCadastroCliente.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroCliente.UseVisualStyleBackColor = false;
            buttonSalvarCadastroCliente.Click += buttonSalvarCadastroCliente_Click;
            // 
            // maskedTextBoxCpfCadastroCliente
            // 
            maskedTextBoxCpfCadastroCliente.Location = new Point(103, 110);
            maskedTextBoxCpfCadastroCliente.Mask = "000\\.000\\.000-00";
            maskedTextBoxCpfCadastroCliente.Name = "maskedTextBoxCpfCadastroCliente";
            maskedTextBoxCpfCadastroCliente.Size = new Size(139, 27);
            maskedTextBoxCpfCadastroCliente.TabIndex = 0;
            maskedTextBoxCpfCadastroCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCpfCadastroCliente.KeyDown += checkKeyDown;
            // 
            // maskedTextBoxTelefoneCadastroCliente
            // 
            maskedTextBoxTelefoneCadastroCliente.Location = new Point(21, 307);
            maskedTextBoxTelefoneCadastroCliente.Mask = "(00) 0 0000-0000";
            maskedTextBoxTelefoneCadastroCliente.Name = "maskedTextBoxTelefoneCadastroCliente";
            maskedTextBoxTelefoneCadastroCliente.Size = new Size(153, 27);
            maskedTextBoxTelefoneCadastroCliente.TabIndex = 2;
            maskedTextBoxTelefoneCadastroCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxTelefoneCadastroCliente.KeyDown += checkKeyDown;
            // 
            // maskedTextBoxCepCadastroCliente
            // 
            maskedTextBoxCepCadastroCliente.Location = new Point(616, 110);
            maskedTextBoxCepCadastroCliente.Mask = "00000-000";
            maskedTextBoxCepCadastroCliente.Name = "maskedTextBoxCepCadastroCliente";
            maskedTextBoxCepCadastroCliente.Size = new Size(109, 27);
            maskedTextBoxCepCadastroCliente.TabIndex = 4;
            maskedTextBoxCepCadastroCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCepCadastroCliente.KeyDown += checkKeyDown;
            maskedTextBoxCepCadastroCliente.Leave += maskedTextBoxCepCadastroCliente_Leave;
            // 
            // labelTitleCadastroCliente
            // 
            labelTitleCadastroCliente.AutoSize = true;
            labelTitleCadastroCliente.Enabled = false;
            labelTitleCadastroCliente.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCadastroCliente.Location = new Point(388, 9);
            labelTitleCadastroCliente.Name = "labelTitleCadastroCliente";
            labelTitleCadastroCliente.Size = new Size(233, 33);
            labelTitleCadastroCliente.TabIndex = 36;
            labelTitleCadastroCliente.Text = "Cadastro de Cliente";
            // 
            // buttonPesquisaCadastroIngredientes
            // 
            buttonPesquisaCadastroIngredientes.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroIngredientes.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroIngredientes.Image = Properties.Resources.search;
            buttonPesquisaCadastroIngredientes.Location = new Point(345, 661);
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
            // ListaClientes
            // 
            ListaClientes.AllowUserToAddRows = false;
            ListaClientes.AllowUserToDeleteRows = false;
            ListaClientes.AllowUserToOrderColumns = true;
            ListaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaClientes.GridColor = SystemColors.InactiveCaption;
            ListaClientes.Location = new Point(21, 720);
            ListaClientes.MultiSelect = false;
            ListaClientes.Name = "ListaClientes";
            ListaClientes.ReadOnly = true;
            ListaClientes.RowHeadersVisible = false;
            ListaClientes.RowHeadersWidth = 51;
            ListaClientes.RowTemplate.Height = 29;
            ListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaClientes.ShowEditingIcon = false;
            ListaClientes.Size = new Size(1094, 188);
            ListaClientes.TabIndex = 86;
            ListaClientes.MouseDoubleClick += ListaClientes_MouseDoubleClick;
            // 
            // textBoxPesquisaCadastroClientes
            // 
            textBoxPesquisaCadastroClientes.Location = new Point(19, 661);
            textBoxPesquisaCadastroClientes.Name = "textBoxPesquisaCadastroClientes";
            textBoxPesquisaCadastroClientes.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroClientes.Size = new Size(323, 27);
            textBoxPesquisaCadastroClientes.TabIndex = 85;
            // 
            // labelClienteCadastroFuncionarios
            // 
            labelClienteCadastroFuncionarios.AutoSize = true;
            labelClienteCadastroFuncionarios.Location = new Point(19, 634);
            labelClienteCadastroFuncionarios.Name = "labelClienteCadastroFuncionarios";
            labelClienteCadastroFuncionarios.Size = new Size(62, 19);
            labelClienteCadastroFuncionarios.TabIndex = 84;
            labelClienteCadastroFuncionarios.Text = "Clientes";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(30, 30);
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1314, 945);
            Controls.Add(buttonPesquisaCadastroIngredientes);
            Controls.Add(ListaClientes);
            Controls.Add(textBoxPesquisaCadastroClientes);
            Controls.Add(labelClienteCadastroFuncionarios);
            Controls.Add(labelTitleCadastroCliente);
            Controls.Add(maskedTextBoxCepCadastroCliente);
            Controls.Add(maskedTextBoxTelefoneCadastroCliente);
            Controls.Add(maskedTextBoxCpfCadastroCliente);
            Controls.Add(buttonFecharCadastroCliente);
            Controls.Add(buttonExcluirCadastroCliente);
            Controls.Add(buttonEditarCadastroCliente);
            Controls.Add(buttonSalvarCadastroCliente);
            Controls.Add(comboBoxUfCadastroCliente);
            Controls.Add(comboBoxPaisCadastroCliente);
            Controls.Add(comboBoxCidadeCadastroCliente);
            Controls.Add(textBoxComplementoCadastroCliente);
            Controls.Add(textBoxNumeroCadastroCliente);
            Controls.Add(textBoxBairroCadastroCliente);
            Controls.Add(textBoxLogradouroCadastroCliente);
            Controls.Add(textBoxIdLogradouroCadastroCliente);
            Controls.Add(textBoxEmailCadastroCliente);
            Controls.Add(textBoxNomeCadastroCliente);
            Controls.Add(textBoxIdCadastroCliente);
            Controls.Add(labelPais);
            Controls.Add(labelUf);
            Controls.Add(labelCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelIdLogradouroCadastroCliente);
            Controls.Add(labelCep);
            Controls.Add(labelLogradouro);
            Controls.Add(labelNumero);
            Controls.Add(labelComplemento);
            Controls.Add(labelCpf);
            Controls.Add(labelTelefone);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(labelIdCadastroCliente);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            ((System.ComponentModel.ISupportInitialize)ListaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCadastroCliente;
        private Label labelNome;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelComplemento;
        private Label labelNumero;
        private Label labelLogradouro;
        private Label labelCep;
        private Label labelIdLogradouroCadastroCliente;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelUf;
        private Label labelPais;
        private TextBox textBoxIdCadastroCliente;
        private TextBox textBoxNomeCadastroCliente;
        private TextBox textBoxEmailCadastroCliente;
        private TextBox textBoxIdLogradouroCadastroCliente;
        private TextBox textBoxLogradouroCadastroCliente;
        private TextBox textBoxBairroCadastroCliente;
        private TextBox textBoxNumeroCadastroCliente;
        private TextBox textBoxComplementoCadastroCliente;
        private ComboBox comboBoxCidadeCadastroCliente;
        private ComboBox comboBoxPaisCadastroCliente;
        private ComboBox comboBoxUfCadastroCliente;
        private Button buttonFecharCadastroCliente;
        private Button buttonExcluirCadastroCliente;
        private Button buttonEditarCadastroCliente;
        private Button buttonSalvarCadastroCliente;
        private MaskedTextBox maskedTextBoxCpfCadastroCliente;
        private MaskedTextBox maskedTextBoxTelefoneCadastroCliente;
        private MaskedTextBox maskedTextBoxCepCadastroCliente;
        private Label labelTitleCadastroCliente;
        private Button buttonPesquisaCadastroIngredientes;
        private DataGridView ListaClientes;
        private TextBox textBoxPesquisaCadastroClientes;
        private Label labelClienteCadastroFuncionarios;
    }
}
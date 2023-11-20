namespace PizzariaDoZe
{
    partial class CadastroFuncionario
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
            maskedTextBoxCepCadastroFuncionario = new MaskedTextBox();
            comboBoxUfCadastroFuncionario = new ComboBox();
            comboBoxPaisCadastroFuncionario = new ComboBox();
            comboBoxCidadeCadastroFuncionario = new ComboBox();
            textBoxComplementoCadastroFuncionario = new TextBox();
            textBoxNumeroCadastroFuncionario = new TextBox();
            textBoxBairroCadastroFuncionario = new TextBox();
            textBoxLogradouroCadastroFuncionario = new TextBox();
            labelPais = new Label();
            labelUf = new Label();
            labelCidade = new Label();
            labelBairro = new Label();
            labelIdLogradouroCadastroFuncionario = new Label();
            labelCep = new Label();
            labelLogradouro = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            textBoxIdLogradouroCadastroFuncionario = new TextBox();
            maskedTextBoxTelefoneCadastroFuncionario = new MaskedTextBox();
            maskedTextBoxCpfCadastroFuncionario = new MaskedTextBox();
            textBoxEmailCadastroFuncionario = new TextBox();
            textBoxNomeCadastroFuncionario = new TextBox();
            textBoxIdCadastroFuncionario = new TextBox();
            labelCpf = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelNome = new Label();
            labelIdCadastroFuncionario = new Label();
            labelObservacao = new Label();
            labelSenha = new Label();
            labelValidade = new Label();
            labelCarteiraMotorista = new Label();
            labelMatricula = new Label();
            textBoxCarteiraMotoristaCadastroFuncionario = new TextBox();
            dateTimePickerCadastroFuncionario = new DateTimePicker();
            textBoxMatriculaCadastroFuncionario = new TextBox();
            textBoxSenhaCadastroFuncionario = new TextBox();
            richTextBoxObservacaoCadastroFuncionario = new RichTextBox();
            groupBoxGrupoCadastroFuncionario = new GroupBox();
            radioButtonEntregadorCadastroFuncionario = new RadioButton();
            radioButtonAtendenteCadastroFuncionario = new RadioButton();
            radioButtonAdministradorCadastroFuncionario = new RadioButton();
            buttonFecharCadastroFuncionario = new Button();
            buttonExcluirCadastroFuncionario = new Button();
            buttonEditarCadastroFuncionario = new Button();
            buttonSalvarCadastroFuncionario = new Button();
            labelTitleCadastroFuncionario = new Label();
            buttonPesquisaCadastroIngredientes = new Button();
            ListaFuncionarios = new DataGridView();
            textBoxPesquisaCadastroFuncionarios = new TextBox();
            labelFuncionarioCadastroFuncionarios = new Label();
            groupBoxGrupoCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListaFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBoxCepCadastroFuncionario
            // 
            maskedTextBoxCepCadastroFuncionario.Location = new Point(857, 139);
            maskedTextBoxCepCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxCepCadastroFuncionario.Mask = "00000-000";
            maskedTextBoxCepCadastroFuncionario.Name = "maskedTextBoxCepCadastroFuncionario";
            maskedTextBoxCepCadastroFuncionario.Size = new Size(108, 32);
            maskedTextBoxCepCadastroFuncionario.TabIndex = 8;
            maskedTextBoxCepCadastroFuncionario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCepCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // comboBoxUfCadastroFuncionario
            // 
            comboBoxUfCadastroFuncionario.FormattingEnabled = true;
            comboBoxUfCadastroFuncionario.Location = new Point(1010, 252);
            comboBoxUfCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            comboBoxUfCadastroFuncionario.Name = "comboBoxUfCadastroFuncionario";
            comboBoxUfCadastroFuncionario.Size = new Size(232, 32);
            comboBoxUfCadastroFuncionario.TabIndex = 11;
            comboBoxUfCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // comboBoxPaisCadastroFuncionario
            // 
            comboBoxPaisCadastroFuncionario.FormattingEnabled = true;
            comboBoxPaisCadastroFuncionario.Location = new Point(764, 252);
            comboBoxPaisCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            comboBoxPaisCadastroFuncionario.Name = "comboBoxPaisCadastroFuncionario";
            comboBoxPaisCadastroFuncionario.Size = new Size(238, 32);
            comboBoxPaisCadastroFuncionario.TabIndex = 10;
            comboBoxPaisCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // comboBoxCidadeCadastroFuncionario
            // 
            comboBoxCidadeCadastroFuncionario.FormattingEnabled = true;
            comboBoxCidadeCadastroFuncionario.Location = new Point(764, 389);
            comboBoxCidadeCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            comboBoxCidadeCadastroFuncionario.Name = "comboBoxCidadeCadastroFuncionario";
            comboBoxCidadeCadastroFuncionario.Size = new Size(223, 32);
            comboBoxCidadeCadastroFuncionario.TabIndex = 12;
            comboBoxCidadeCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxComplementoCadastroFuncionario
            // 
            textBoxComplementoCadastroFuncionario.Location = new Point(888, 543);
            textBoxComplementoCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxComplementoCadastroFuncionario.Name = "textBoxComplementoCadastroFuncionario";
            textBoxComplementoCadastroFuncionario.Size = new Size(385, 32);
            textBoxComplementoCadastroFuncionario.TabIndex = 15;
            textBoxComplementoCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxNumeroCadastroFuncionario
            // 
            textBoxNumeroCadastroFuncionario.Location = new Point(764, 543);
            textBoxNumeroCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxNumeroCadastroFuncionario.Name = "textBoxNumeroCadastroFuncionario";
            textBoxNumeroCadastroFuncionario.Size = new Size(116, 32);
            textBoxNumeroCadastroFuncionario.TabIndex = 14;
            textBoxNumeroCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxBairroCadastroFuncionario
            // 
            textBoxBairroCadastroFuncionario.Location = new Point(993, 389);
            textBoxBairroCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxBairroCadastroFuncionario.Name = "textBoxBairroCadastroFuncionario";
            textBoxBairroCadastroFuncionario.Size = new Size(280, 32);
            textBoxBairroCadastroFuncionario.TabIndex = 13;
            textBoxBairroCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxLogradouroCadastroFuncionario
            // 
            textBoxLogradouroCadastroFuncionario.Location = new Point(971, 139);
            textBoxLogradouroCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxLogradouroCadastroFuncionario.Name = "textBoxLogradouroCadastroFuncionario";
            textBoxLogradouroCadastroFuncionario.Size = new Size(247, 32);
            textBoxLogradouroCadastroFuncionario.TabIndex = 9;
            textBoxLogradouroCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPais.Location = new Point(764, 224);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(43, 24);
            labelPais.TabIndex = 44;
            labelPais.Text = "País";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUf.Location = new Point(1010, 224);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(32, 24);
            labelUf.TabIndex = 43;
            labelUf.Text = "UF";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCidade.Location = new Point(764, 361);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(68, 24);
            labelCidade.TabIndex = 42;
            labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBairro.Location = new Point(993, 361);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(61, 24);
            labelBairro.TabIndex = 41;
            labelBairro.Text = "Bairro";
            // 
            // labelIdLogradouroCadastroFuncionario
            // 
            labelIdLogradouroCadastroFuncionario.AutoSize = true;
            labelIdLogradouroCadastroFuncionario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdLogradouroCadastroFuncionario.Location = new Point(764, 111);
            labelIdLogradouroCadastroFuncionario.Name = "labelIdLogradouroCadastroFuncionario";
            labelIdLogradouroCadastroFuncionario.Size = new Size(27, 24);
            labelIdLogradouroCadastroFuncionario.TabIndex = 40;
            labelIdLogradouroCadastroFuncionario.Text = "ID";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCep.Location = new Point(857, 111);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(41, 24);
            labelCep.TabIndex = 39;
            labelCep.Text = "CEP";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogradouro.Location = new Point(971, 111);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(106, 24);
            labelLogradouro.TabIndex = 38;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.Location = new Point(764, 516);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(78, 24);
            labelNumero.TabIndex = 37;
            labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelComplemento.Location = new Point(888, 516);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(129, 24);
            labelComplemento.TabIndex = 36;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxIdLogradouroCadastroFuncionario
            // 
            textBoxIdLogradouroCadastroFuncionario.Location = new Point(764, 139);
            textBoxIdLogradouroCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxIdLogradouroCadastroFuncionario.Name = "textBoxIdLogradouroCadastroFuncionario";
            textBoxIdLogradouroCadastroFuncionario.ReadOnly = true;
            textBoxIdLogradouroCadastroFuncionario.Size = new Size(82, 32);
            textBoxIdLogradouroCadastroFuncionario.TabIndex = 45;
            textBoxIdLogradouroCadastroFuncionario.TabStop = false;
            // 
            // maskedTextBoxTelefoneCadastroFuncionario
            // 
            maskedTextBoxTelefoneCadastroFuncionario.Location = new Point(15, 389);
            maskedTextBoxTelefoneCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTelefoneCadastroFuncionario.Mask = "(00) 0 0000-0000";
            maskedTextBoxTelefoneCadastroFuncionario.Name = "maskedTextBoxTelefoneCadastroFuncionario";
            maskedTextBoxTelefoneCadastroFuncionario.Size = new Size(141, 32);
            maskedTextBoxTelefoneCadastroFuncionario.TabIndex = 3;
            maskedTextBoxTelefoneCadastroFuncionario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxTelefoneCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // maskedTextBoxCpfCadastroFuncionario
            // 
            maskedTextBoxCpfCadastroFuncionario.Location = new Point(108, 139);
            maskedTextBoxCpfCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxCpfCadastroFuncionario.Mask = "000\\.000\\.000-00";
            maskedTextBoxCpfCadastroFuncionario.Name = "maskedTextBoxCpfCadastroFuncionario";
            maskedTextBoxCpfCadastroFuncionario.Size = new Size(157, 32);
            maskedTextBoxCpfCadastroFuncionario.TabIndex = 0;
            maskedTextBoxCpfCadastroFuncionario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCpfCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxEmailCadastroFuncionario
            // 
            textBoxEmailCadastroFuncionario.Location = new Point(163, 389);
            textBoxEmailCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxEmailCadastroFuncionario.Name = "textBoxEmailCadastroFuncionario";
            textBoxEmailCadastroFuncionario.Size = new Size(287, 32);
            textBoxEmailCadastroFuncionario.TabIndex = 4;
            textBoxEmailCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxNomeCadastroFuncionario
            // 
            textBoxNomeCadastroFuncionario.Location = new Point(15, 252);
            textBoxNomeCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxNomeCadastroFuncionario.Name = "textBoxNomeCadastroFuncionario";
            textBoxNomeCadastroFuncionario.ScrollBars = ScrollBars.Both;
            textBoxNomeCadastroFuncionario.Size = new Size(483, 32);
            textBoxNomeCadastroFuncionario.TabIndex = 2;
            textBoxNomeCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxIdCadastroFuncionario
            // 
            textBoxIdCadastroFuncionario.Location = new Point(15, 139);
            textBoxIdCadastroFuncionario.Margin = new Padding(3, 4, 3, 4);
            textBoxIdCadastroFuncionario.Name = "textBoxIdCadastroFuncionario";
            textBoxIdCadastroFuncionario.ReadOnly = true;
            textBoxIdCadastroFuncionario.Size = new Size(86, 32);
            textBoxIdCadastroFuncionario.TabIndex = 59;
            textBoxIdCadastroFuncionario.TabStop = false;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(108, 111);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(40, 24);
            labelCpf.TabIndex = 58;
            labelCpf.Text = "CPF";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(15, 361);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(81, 24);
            labelTelefone.TabIndex = 57;
            labelTelefone.Text = "Telefone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(163, 361);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 24);
            labelEmail.TabIndex = 56;
            labelEmail.Text = "E-mail";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(15, 224);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(60, 24);
            labelNome.TabIndex = 55;
            labelNome.Text = "Nome";
            // 
            // labelIdCadastroFuncionario
            // 
            labelIdCadastroFuncionario.AutoSize = true;
            labelIdCadastroFuncionario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdCadastroFuncionario.Location = new Point(15, 111);
            labelIdCadastroFuncionario.Name = "labelIdCadastroFuncionario";
            labelIdCadastroFuncionario.Size = new Size(27, 24);
            labelIdCadastroFuncionario.TabIndex = 54;
            labelIdCadastroFuncionario.Text = "ID";
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Location = new Point(17, 565);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(115, 24);
            labelObservacao.TabIndex = 64;
            labelObservacao.Text = "Observações";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(334, 467);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(61, 24);
            labelSenha.TabIndex = 65;
            labelSenha.Text = "Senha";
            // 
            // labelValidade
            // 
            labelValidade.AutoSize = true;
            labelValidade.Location = new Point(213, 467);
            labelValidade.Name = "labelValidade";
            labelValidade.Size = new Size(82, 24);
            labelValidade.TabIndex = 66;
            labelValidade.Text = "Validade";
            // 
            // labelCarteiraMotorista
            // 
            labelCarteiraMotorista.AutoSize = true;
            labelCarteiraMotorista.Location = new Point(17, 462);
            labelCarteiraMotorista.Name = "labelCarteiraMotorista";
            labelCarteiraMotorista.Size = new Size(191, 24);
            labelCarteiraMotorista.TabIndex = 67;
            labelCarteiraMotorista.Text = "Carteira de Motorista";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(271, 111);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(90, 24);
            labelMatricula.TabIndex = 68;
            labelMatricula.Text = "Matricula";
            // 
            // textBoxCarteiraMotoristaCadastroFuncionario
            // 
            textBoxCarteiraMotoristaCadastroFuncionario.Location = new Point(17, 489);
            textBoxCarteiraMotoristaCadastroFuncionario.Name = "textBoxCarteiraMotoristaCadastroFuncionario";
            textBoxCarteiraMotoristaCadastroFuncionario.Size = new Size(180, 32);
            textBoxCarteiraMotoristaCadastroFuncionario.TabIndex = 5;
            textBoxCarteiraMotoristaCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // dateTimePickerCadastroFuncionario
            // 
            dateTimePickerCadastroFuncionario.CustomFormat = "dd/MM/yyyy";
            dateTimePickerCadastroFuncionario.ImeMode = ImeMode.NoControl;
            dateTimePickerCadastroFuncionario.Location = new Point(213, 489);
            dateTimePickerCadastroFuncionario.Name = "dateTimePickerCadastroFuncionario";
            dateTimePickerCadastroFuncionario.Size = new Size(109, 32);
            dateTimePickerCadastroFuncionario.TabIndex = 70;
            dateTimePickerCadastroFuncionario.TabStop = false;
            dateTimePickerCadastroFuncionario.Value = new DateTime(2023, 8, 6, 2, 11, 34, 0);
            dateTimePickerCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxMatriculaCadastroFuncionario
            // 
            textBoxMatriculaCadastroFuncionario.Location = new Point(271, 139);
            textBoxMatriculaCadastroFuncionario.Name = "textBoxMatriculaCadastroFuncionario";
            textBoxMatriculaCadastroFuncionario.Size = new Size(227, 32);
            textBoxMatriculaCadastroFuncionario.TabIndex = 1;
            textBoxMatriculaCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // textBoxSenhaCadastroFuncionario
            // 
            textBoxSenhaCadastroFuncionario.Location = new Point(334, 489);
            textBoxSenhaCadastroFuncionario.Name = "textBoxSenhaCadastroFuncionario";
            textBoxSenhaCadastroFuncionario.Size = new Size(164, 32);
            textBoxSenhaCadastroFuncionario.TabIndex = 6;
            textBoxSenhaCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // richTextBoxObservacaoCadastroFuncionario
            // 
            richTextBoxObservacaoCadastroFuncionario.Location = new Point(17, 587);
            richTextBoxObservacaoCadastroFuncionario.Name = "richTextBoxObservacaoCadastroFuncionario";
            richTextBoxObservacaoCadastroFuncionario.Size = new Size(481, 91);
            richTextBoxObservacaoCadastroFuncionario.TabIndex = 7;
            richTextBoxObservacaoCadastroFuncionario.Text = "";
            richTextBoxObservacaoCadastroFuncionario.KeyDown += checkKeyDown;
            // 
            // groupBoxGrupoCadastroFuncionario
            // 
            groupBoxGrupoCadastroFuncionario.Controls.Add(radioButtonEntregadorCadastroFuncionario);
            groupBoxGrupoCadastroFuncionario.Controls.Add(radioButtonAtendenteCadastroFuncionario);
            groupBoxGrupoCadastroFuncionario.Controls.Add(radioButtonAdministradorCadastroFuncionario);
            groupBoxGrupoCadastroFuncionario.Location = new Point(527, 111);
            groupBoxGrupoCadastroFuncionario.Name = "groupBoxGrupoCadastroFuncionario";
            groupBoxGrupoCadastroFuncionario.Size = new Size(200, 200);
            groupBoxGrupoCadastroFuncionario.TabIndex = 74;
            groupBoxGrupoCadastroFuncionario.TabStop = false;
            groupBoxGrupoCadastroFuncionario.Text = "Grupo";
            // 
            // radioButtonEntregadorCadastroFuncionario
            // 
            radioButtonEntregadorCadastroFuncionario.AutoSize = true;
            radioButtonEntregadorCadastroFuncionario.Location = new Point(43, 141);
            radioButtonEntregadorCadastroFuncionario.Name = "radioButtonEntregadorCadastroFuncionario";
            radioButtonEntregadorCadastroFuncionario.Size = new Size(124, 28);
            radioButtonEntregadorCadastroFuncionario.TabIndex = 2;
            radioButtonEntregadorCadastroFuncionario.Text = "Entregador";
            radioButtonEntregadorCadastroFuncionario.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtendenteCadastroFuncionario
            // 
            radioButtonAtendenteCadastroFuncionario.AutoSize = true;
            radioButtonAtendenteCadastroFuncionario.Location = new Point(43, 92);
            radioButtonAtendenteCadastroFuncionario.Name = "radioButtonAtendenteCadastroFuncionario";
            radioButtonAtendenteCadastroFuncionario.Size = new Size(119, 28);
            radioButtonAtendenteCadastroFuncionario.TabIndex = 1;
            radioButtonAtendenteCadastroFuncionario.Text = "Atendente";
            radioButtonAtendenteCadastroFuncionario.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdministradorCadastroFuncionario
            // 
            radioButtonAdministradorCadastroFuncionario.AutoSize = true;
            radioButtonAdministradorCadastroFuncionario.Location = new Point(43, 44);
            radioButtonAdministradorCadastroFuncionario.Name = "radioButtonAdministradorCadastroFuncionario";
            radioButtonAdministradorCadastroFuncionario.Size = new Size(152, 28);
            radioButtonAdministradorCadastroFuncionario.TabIndex = 0;
            radioButtonAdministradorCadastroFuncionario.Text = "Administrador";
            radioButtonAdministradorCadastroFuncionario.UseVisualStyleBackColor = true;
            // 
            // buttonFecharCadastroFuncionario
            // 
            buttonFecharCadastroFuncionario.BackColor = Color.Blue;
            buttonFecharCadastroFuncionario.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroFuncionario.Location = new Point(675, 744);
            buttonFecharCadastroFuncionario.Margin = new Padding(0);
            buttonFecharCadastroFuncionario.Name = "buttonFecharCadastroFuncionario";
            buttonFecharCadastroFuncionario.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroFuncionario.Size = new Size(102, 48);
            buttonFecharCadastroFuncionario.TabIndex = 78;
            buttonFecharCadastroFuncionario.TabStop = false;
            buttonFecharCadastroFuncionario.Text = "Fechar";
            buttonFecharCadastroFuncionario.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroFuncionario.UseVisualStyleBackColor = false;
            buttonFecharCadastroFuncionario.Click += buttonFecharCadastroFuncionario_Click;
            // 
            // buttonExcluirCadastroFuncionario
            // 
            buttonExcluirCadastroFuncionario.BackColor = Color.Red;
            buttonExcluirCadastroFuncionario.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroFuncionario.Location = new Point(787, 744);
            buttonExcluirCadastroFuncionario.Margin = new Padding(0);
            buttonExcluirCadastroFuncionario.Name = "buttonExcluirCadastroFuncionario";
            buttonExcluirCadastroFuncionario.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroFuncionario.Size = new Size(102, 48);
            buttonExcluirCadastroFuncionario.TabIndex = 77;
            buttonExcluirCadastroFuncionario.TabStop = false;
            buttonExcluirCadastroFuncionario.Text = "Excluir";
            buttonExcluirCadastroFuncionario.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroFuncionario.UseVisualStyleBackColor = false;
            buttonExcluirCadastroFuncionario.Click += buttonExcluirCadastroFuncionario_Click;
            // 
            // buttonEditarCadastroFuncionario
            // 
            buttonEditarCadastroFuncionario.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroFuncionario.Image = Properties.Resources.editicon;
            buttonEditarCadastroFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroFuncionario.Location = new Point(555, 744);
            buttonEditarCadastroFuncionario.Margin = new Padding(0);
            buttonEditarCadastroFuncionario.Name = "buttonEditarCadastroFuncionario";
            buttonEditarCadastroFuncionario.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroFuncionario.Size = new Size(102, 48);
            buttonEditarCadastroFuncionario.TabIndex = 76;
            buttonEditarCadastroFuncionario.TabStop = false;
            buttonEditarCadastroFuncionario.Text = "Editar";
            buttonEditarCadastroFuncionario.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroFuncionario.UseVisualStyleBackColor = false;
            buttonEditarCadastroFuncionario.Click += buttonEditarCadastroFuncionario_Click;
            // 
            // buttonSalvarCadastroFuncionario
            // 
            buttonSalvarCadastroFuncionario.BackColor = Color.YellowGreen;
            buttonSalvarCadastroFuncionario.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroFuncionario.Location = new Point(437, 744);
            buttonSalvarCadastroFuncionario.Margin = new Padding(0);
            buttonSalvarCadastroFuncionario.Name = "buttonSalvarCadastroFuncionario";
            buttonSalvarCadastroFuncionario.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroFuncionario.Size = new Size(102, 48);
            buttonSalvarCadastroFuncionario.TabIndex = 75;
            buttonSalvarCadastroFuncionario.TabStop = false;
            buttonSalvarCadastroFuncionario.Text = "Salvar";
            buttonSalvarCadastroFuncionario.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroFuncionario.UseVisualStyleBackColor = false;
            buttonSalvarCadastroFuncionario.Click += buttonSalvarCadastroFuncionario_Click;
            // 
            // labelTitleCadastroFuncionario
            // 
            labelTitleCadastroFuncionario.AutoSize = true;
            labelTitleCadastroFuncionario.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCadastroFuncionario.Location = new Point(460, 9);
            labelTitleCadastroFuncionario.Name = "labelTitleCadastroFuncionario";
            labelTitleCadastroFuncionario.Size = new Size(360, 41);
            labelTitleCadastroFuncionario.TabIndex = 79;
            labelTitleCadastroFuncionario.Text = "Cadastro de Funcionário";
            // 
            // buttonPesquisaCadastroIngredientes
            // 
            buttonPesquisaCadastroIngredientes.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroIngredientes.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroIngredientes.Image = Properties.Resources.search;
            buttonPesquisaCadastroIngredientes.Location = new Point(339, 883);
            buttonPesquisaCadastroIngredientes.Margin = new Padding(0);
            buttonPesquisaCadastroIngredientes.Name = "buttonPesquisaCadastroIngredientes";
            buttonPesquisaCadastroIngredientes.Padding = new Padding(5, 0, 5, 0);
            buttonPesquisaCadastroIngredientes.Size = new Size(44, 32);
            buttonPesquisaCadastroIngredientes.TabIndex = 83;
            buttonPesquisaCadastroIngredientes.TabStop = false;
            buttonPesquisaCadastroIngredientes.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisaCadastroIngredientes.UseVisualStyleBackColor = false;
            buttonPesquisaCadastroIngredientes.Click += buttonPesquisaCadastroIngredientes_Click;
            // 
            // ListaFuncionarios
            // 
            ListaFuncionarios.AllowUserToAddRows = false;
            ListaFuncionarios.AllowUserToDeleteRows = false;
            ListaFuncionarios.AllowUserToOrderColumns = true;
            ListaFuncionarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ListaFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaFuncionarios.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaFuncionarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaFuncionarios.GridColor = SystemColors.InactiveCaption;
            ListaFuncionarios.Location = new Point(15, 942);
            ListaFuncionarios.MultiSelect = false;
            ListaFuncionarios.Name = "ListaFuncionarios";
            ListaFuncionarios.ReadOnly = true;
            ListaFuncionarios.RowHeadersVisible = false;
            ListaFuncionarios.RowHeadersWidth = 51;
            ListaFuncionarios.RowTemplate.Height = 29;
            ListaFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaFuncionarios.ShowEditingIcon = false;
            ListaFuncionarios.Size = new Size(1483, 188);
            ListaFuncionarios.TabIndex = 82;
            ListaFuncionarios.CellFormatting += ListaFuncionarios_CellFormatting;
            ListaFuncionarios.MouseDoubleClick += ListaFuncionarios_MouseDoubleClick;
            // 
            // textBoxPesquisaCadastroFuncionarios
            // 
            textBoxPesquisaCadastroFuncionarios.Location = new Point(13, 883);
            textBoxPesquisaCadastroFuncionarios.Name = "textBoxPesquisaCadastroFuncionarios";
            textBoxPesquisaCadastroFuncionarios.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroFuncionarios.Size = new Size(323, 32);
            textBoxPesquisaCadastroFuncionarios.TabIndex = 81;
            // 
            // labelFuncionarioCadastroFuncionarios
            // 
            labelFuncionarioCadastroFuncionarios.AutoSize = true;
            labelFuncionarioCadastroFuncionarios.Location = new Point(13, 856);
            labelFuncionarioCadastroFuncionarios.Name = "labelFuncionarioCadastroFuncionarios";
            labelFuncionarioCadastroFuncionarios.Size = new Size(117, 24);
            labelFuncionarioCadastroFuncionarios.TabIndex = 80;
            labelFuncionarioCadastroFuncionarios.Text = "Funcionários";
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(30, 30);
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1510, 1055);
            Controls.Add(buttonPesquisaCadastroIngredientes);
            Controls.Add(ListaFuncionarios);
            Controls.Add(textBoxPesquisaCadastroFuncionarios);
            Controls.Add(labelFuncionarioCadastroFuncionarios);
            Controls.Add(labelTitleCadastroFuncionario);
            Controls.Add(buttonFecharCadastroFuncionario);
            Controls.Add(buttonExcluirCadastroFuncionario);
            Controls.Add(buttonEditarCadastroFuncionario);
            Controls.Add(buttonSalvarCadastroFuncionario);
            Controls.Add(groupBoxGrupoCadastroFuncionario);
            Controls.Add(richTextBoxObservacaoCadastroFuncionario);
            Controls.Add(textBoxSenhaCadastroFuncionario);
            Controls.Add(textBoxMatriculaCadastroFuncionario);
            Controls.Add(dateTimePickerCadastroFuncionario);
            Controls.Add(textBoxCarteiraMotoristaCadastroFuncionario);
            Controls.Add(labelMatricula);
            Controls.Add(labelCarteiraMotorista);
            Controls.Add(labelValidade);
            Controls.Add(labelSenha);
            Controls.Add(labelObservacao);
            Controls.Add(maskedTextBoxTelefoneCadastroFuncionario);
            Controls.Add(maskedTextBoxCpfCadastroFuncionario);
            Controls.Add(textBoxEmailCadastroFuncionario);
            Controls.Add(textBoxNomeCadastroFuncionario);
            Controls.Add(textBoxIdCadastroFuncionario);
            Controls.Add(labelCpf);
            Controls.Add(labelTelefone);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(labelIdCadastroFuncionario);
            Controls.Add(maskedTextBoxCepCadastroFuncionario);
            Controls.Add(comboBoxUfCadastroFuncionario);
            Controls.Add(comboBoxPaisCadastroFuncionario);
            Controls.Add(comboBoxCidadeCadastroFuncionario);
            Controls.Add(textBoxComplementoCadastroFuncionario);
            Controls.Add(textBoxNumeroCadastroFuncionario);
            Controls.Add(textBoxBairroCadastroFuncionario);
            Controls.Add(textBoxLogradouroCadastroFuncionario);
            Controls.Add(textBoxIdLogradouroCadastroFuncionario);
            Controls.Add(labelPais);
            Controls.Add(labelUf);
            Controls.Add(labelCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelIdLogradouroCadastroFuncionario);
            Controls.Add(labelCep);
            Controls.Add(labelLogradouro);
            Controls.Add(labelNumero);
            Controls.Add(labelComplemento);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroFuncionario";
            Padding = new Padding(0, 0, 0, 30);
            Text = "CadastroFuncionario";
            groupBoxGrupoCadastroFuncionario.ResumeLayout(false);
            groupBoxGrupoCadastroFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListaFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxCepCadastroFuncionario;
        private ComboBox comboBoxUfCadastroFuncionario;
        private ComboBox comboBoxPaisCadastroFuncionario;
        private ComboBox comboBoxCidadeCadastroFuncionario;
        private TextBox textBoxComplementoCadastroFuncionario;
        private TextBox textBoxNumeroCadastroFuncionario;
        private TextBox textBoxBairroCadastroFuncionario;
        private TextBox textBoxLogradouroCadastroFuncionario;
        private Label labelPais;
        private Label labelUf;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelIdLogradouroCadastroFuncionario;
        private Label labelCep;
        private Label labelLogradouro;
        private Label labelNumero;
        private Label labelComplemento;
        private TextBox textBoxIdLogradouroCadastroFuncionario;
        private MaskedTextBox maskedTextBoxTelefoneCadastroFuncionario;
        private MaskedTextBox maskedTextBoxCpfCadastroFuncionario;
        private TextBox textBoxEmailCadastroFuncionario;
        private TextBox textBoxNomeCadastroFuncionario;
        private TextBox textBoxIdCadastroFuncionario;
        private Label labelCpf;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelNome;
        private Label labelIdCadastroFuncionario;
        private Label labelObservacao;
        private Label labelSenha;
        private Label labelValidade;
        private Label labelCarteiraMotorista;
        private Label labelMatricula;
        private TextBox textBoxCarteiraMotoristaCadastroFuncionario;
        private DateTimePicker dateTimePickerCadastroFuncionario;
        private TextBox textBoxMatriculaCadastroFuncionario;
        private TextBox textBoxSenhaCadastroFuncionario;
        private RichTextBox richTextBoxObservacaoCadastroFuncionario;
        private GroupBox groupBoxGrupoCadastroFuncionario;
        private RadioButton radioButtonEntregadorCadastroFuncionario;
        private RadioButton radioButtonAtendenteCadastroFuncionario;
        private RadioButton radioButtonAdministradorCadastroFuncionario;
        private Button buttonFecharCadastroFuncionario;
        private Button buttonExcluirCadastroFuncionario;
        private Button buttonEditarCadastroFuncionario;
        private Button buttonSalvarCadastroFuncionario;
        private Label labelTitleCadastroFuncionario;
        private Button buttonPesquisaCadastroIngredientes;
        private DataGridView ListaFuncionarios;
        private TextBox textBoxPesquisaCadastroFuncionarios;
        private Label labelFuncionarioCadastroFuncionarios;
    }
}
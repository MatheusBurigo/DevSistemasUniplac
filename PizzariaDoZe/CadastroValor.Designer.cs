namespace PizzariaDoZe
{
    partial class CadastroValor
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
            labelIdCadastroValor = new Label();
            labelTamanho = new Label();
            labelCategoria = new Label();
            labelValorBorda = new Label();
            labelValor = new Label();
            textBoxIdCadastroValor = new TextBox();
            listBoxTamanhoCadastroValor = new ListBox();
            listBoxCategoriaCadastroValor = new ListBox();
            buttonFecharCadastroValor = new Button();
            buttonExcluirCadastroValor = new Button();
            buttonEditarCadastroValor = new Button();
            buttonSalvarCadastroValor = new Button();
            labelTitleCadastroValor = new Label();
            maskedTextBoxValorCadastroValor = new MaskedTextBox();
            maskedTextBoxValorBordaCadastroValor = new MaskedTextBox();
            ListaValores = new DataGridView();
            buttonPesquisaCadastroValor = new Button();
            textBoxPesquisaCadastroValor = new TextBox();
            labelValoresCadastroValor = new Label();
            ((System.ComponentModel.ISupportInitialize)ListaValores).BeginInit();
            SuspendLayout();
            // 
            // labelIdCadastroValor
            // 
            labelIdCadastroValor.AutoSize = true;
            labelIdCadastroValor.Location = new Point(15, 77);
            labelIdCadastroValor.Name = "labelIdCadastroValor";
            labelIdCadastroValor.Size = new Size(26, 24);
            labelIdCadastroValor.TabIndex = 0;
            labelIdCadastroValor.Text = "Id";
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Location = new Point(291, 77);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(87, 24);
            labelTamanho.TabIndex = 1;
            labelTamanho.Text = "Tamanho";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(519, 77);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(90, 24);
            labelCategoria.TabIndex = 2;
            labelCategoria.Text = "Categoria";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(15, 300);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(191, 24);
            labelValorBorda.TabIndex = 3;
            labelValorBorda.Text = "Valor Adicional Borda";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(15, 179);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(53, 24);
            labelValor.TabIndex = 4;
            labelValor.Text = "Valor";
            // 
            // textBoxIdCadastroValor
            // 
            textBoxIdCadastroValor.Location = new Point(15, 104);
            textBoxIdCadastroValor.Name = "textBoxIdCadastroValor";
            textBoxIdCadastroValor.ReadOnly = true;
            textBoxIdCadastroValor.Size = new Size(88, 32);
            textBoxIdCadastroValor.TabIndex = 5;
            textBoxIdCadastroValor.TabStop = false;
            // 
            // listBoxTamanhoCadastroValor
            // 
            listBoxTamanhoCadastroValor.FormattingEnabled = true;
            listBoxTamanhoCadastroValor.ItemHeight = 24;
            listBoxTamanhoCadastroValor.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            listBoxTamanhoCadastroValor.Location = new Point(291, 104);
            listBoxTamanhoCadastroValor.Name = "listBoxTamanhoCadastroValor";
            listBoxTamanhoCadastroValor.Size = new Size(163, 268);
            listBoxTamanhoCadastroValor.TabIndex = 8;
            listBoxTamanhoCadastroValor.TabStop = false;
            // 
            // listBoxCategoriaCadastroValor
            // 
            listBoxCategoriaCadastroValor.FormattingEnabled = true;
            listBoxCategoriaCadastroValor.ItemHeight = 24;
            listBoxCategoriaCadastroValor.Items.AddRange(new object[] { "Tradicional", "Especial" });
            listBoxCategoriaCadastroValor.Location = new Point(519, 104);
            listBoxCategoriaCadastroValor.Name = "listBoxCategoriaCadastroValor";
            listBoxCategoriaCadastroValor.Size = new Size(163, 268);
            listBoxCategoriaCadastroValor.TabIndex = 9;
            listBoxCategoriaCadastroValor.TabStop = false;
            // 
            // buttonFecharCadastroValor
            // 
            buttonFecharCadastroValor.BackColor = Color.Blue;
            buttonFecharCadastroValor.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroValor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroValor.Location = new Point(519, 472);
            buttonFecharCadastroValor.Margin = new Padding(0);
            buttonFecharCadastroValor.Name = "buttonFecharCadastroValor";
            buttonFecharCadastroValor.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroValor.Size = new Size(102, 48);
            buttonFecharCadastroValor.TabIndex = 17;
            buttonFecharCadastroValor.TabStop = false;
            buttonFecharCadastroValor.Text = "Fechar";
            buttonFecharCadastroValor.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroValor.UseVisualStyleBackColor = false;
            buttonFecharCadastroValor.Click += buttonFecharCadastroValor_Click;
            // 
            // buttonExcluirCadastroValor
            // 
            buttonExcluirCadastroValor.BackColor = Color.Red;
            buttonExcluirCadastroValor.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroValor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroValor.Location = new Point(402, 472);
            buttonExcluirCadastroValor.Margin = new Padding(0);
            buttonExcluirCadastroValor.Name = "buttonExcluirCadastroValor";
            buttonExcluirCadastroValor.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroValor.Size = new Size(102, 48);
            buttonExcluirCadastroValor.TabIndex = 16;
            buttonExcluirCadastroValor.TabStop = false;
            buttonExcluirCadastroValor.Text = "Excluir";
            buttonExcluirCadastroValor.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroValor.UseVisualStyleBackColor = false;
            buttonExcluirCadastroValor.Click += buttonExcluirCadastroValor_Click;
            // 
            // buttonEditarCadastroValor
            // 
            buttonEditarCadastroValor.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroValor.Image = Properties.Resources.editicon;
            buttonEditarCadastroValor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroValor.Location = new Point(285, 472);
            buttonEditarCadastroValor.Margin = new Padding(0);
            buttonEditarCadastroValor.Name = "buttonEditarCadastroValor";
            buttonEditarCadastroValor.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroValor.Size = new Size(102, 48);
            buttonEditarCadastroValor.TabIndex = 15;
            buttonEditarCadastroValor.TabStop = false;
            buttonEditarCadastroValor.Text = "Editar";
            buttonEditarCadastroValor.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroValor.UseVisualStyleBackColor = false;
            buttonEditarCadastroValor.Click += buttonEditarCadastroValor_Click;
            // 
            // buttonSalvarCadastroValor
            // 
            buttonSalvarCadastroValor.BackColor = Color.YellowGreen;
            buttonSalvarCadastroValor.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroValor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroValor.Location = new Point(167, 472);
            buttonSalvarCadastroValor.Margin = new Padding(0);
            buttonSalvarCadastroValor.Name = "buttonSalvarCadastroValor";
            buttonSalvarCadastroValor.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroValor.Size = new Size(102, 48);
            buttonSalvarCadastroValor.TabIndex = 14;
            buttonSalvarCadastroValor.TabStop = false;
            buttonSalvarCadastroValor.Text = "Salvar";
            buttonSalvarCadastroValor.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroValor.UseVisualStyleBackColor = false;
            buttonSalvarCadastroValor.Click += buttonSalvarCadastroValor_Click;
            // 
            // labelTitleCadastroValor
            // 
            labelTitleCadastroValor.AutoSize = true;
            labelTitleCadastroValor.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCadastroValor.Location = new Point(256, 9);
            labelTitleCadastroValor.Name = "labelTitleCadastroValor";
            labelTitleCadastroValor.Size = new Size(268, 41);
            labelTitleCadastroValor.TabIndex = 82;
            labelTitleCadastroValor.Text = "Cadastro de Valor";
            // 
            // maskedTextBoxValorCadastroValor
            // 
            maskedTextBoxValorCadastroValor.Location = new Point(15, 206);
            maskedTextBoxValorCadastroValor.Mask = "$99,99";
            maskedTextBoxValorCadastroValor.Name = "maskedTextBoxValorCadastroValor";
            maskedTextBoxValorCadastroValor.Size = new Size(125, 32);
            maskedTextBoxValorCadastroValor.TabIndex = 0;
            // 
            // maskedTextBoxValorBordaCadastroValor
            // 
            maskedTextBoxValorBordaCadastroValor.Location = new Point(15, 327);
            maskedTextBoxValorBordaCadastroValor.Mask = "$99,99";
            maskedTextBoxValorBordaCadastroValor.Name = "maskedTextBoxValorBordaCadastroValor";
            maskedTextBoxValorBordaCadastroValor.Size = new Size(125, 32);
            maskedTextBoxValorBordaCadastroValor.TabIndex = 1;
            // 
            // ListaValores
            // 
            ListaValores.AllowUserToAddRows = false;
            ListaValores.AllowUserToDeleteRows = false;
            ListaValores.AllowUserToOrderColumns = true;
            ListaValores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ListaValores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaValores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaValores.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaValores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaValores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaValores.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaValores.GridColor = SystemColors.InactiveCaption;
            ListaValores.Location = new Point(745, 152);
            ListaValores.MultiSelect = false;
            ListaValores.Name = "ListaValores";
            ListaValores.ReadOnly = true;
            ListaValores.RowHeadersVisible = false;
            ListaValores.RowHeadersWidth = 51;
            ListaValores.RowTemplate.Height = 29;
            ListaValores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaValores.ShowEditingIcon = false;
            ListaValores.Size = new Size(611, 225);
            ListaValores.TabIndex = 83;
            ListaValores.CellContentDoubleClick += ListaValores_CellContentDoubleClick;
            ListaValores.CellFormatting += ListaValores_CellFormatting;
            // 
            // buttonPesquisaCadastroValor
            // 
            buttonPesquisaCadastroValor.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroValor.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroValor.Image = Properties.Resources.search;
            buttonPesquisaCadastroValor.Location = new Point(1071, 104);
            buttonPesquisaCadastroValor.Margin = new Padding(0);
            buttonPesquisaCadastroValor.Name = "buttonPesquisaCadastroValor";
            buttonPesquisaCadastroValor.Padding = new Padding(5, 0, 5, 0);
            buttonPesquisaCadastroValor.Size = new Size(44, 32);
            buttonPesquisaCadastroValor.TabIndex = 86;
            buttonPesquisaCadastroValor.TabStop = false;
            buttonPesquisaCadastroValor.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisaCadastroValor.UseVisualStyleBackColor = false;
            buttonPesquisaCadastroValor.Click += buttonPesquisaCadastroValor_Click;
            // 
            // textBoxPesquisaCadastroValor
            // 
            textBoxPesquisaCadastroValor.Location = new Point(745, 104);
            textBoxPesquisaCadastroValor.Name = "textBoxPesquisaCadastroValor";
            textBoxPesquisaCadastroValor.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroValor.Size = new Size(323, 32);
            textBoxPesquisaCadastroValor.TabIndex = 85;
            // 
            // labelValoresCadastroValor
            // 
            labelValoresCadastroValor.AutoSize = true;
            labelValoresCadastroValor.Location = new Point(745, 77);
            labelValoresCadastroValor.Name = "labelValoresCadastroValor";
            labelValoresCadastroValor.Size = new Size(71, 24);
            labelValoresCadastroValor.TabIndex = 84;
            labelValoresCadastroValor.Text = "Valores";
            // 
            // CadastroValor
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1368, 540);
            Controls.Add(buttonPesquisaCadastroValor);
            Controls.Add(textBoxPesquisaCadastroValor);
            Controls.Add(labelValoresCadastroValor);
            Controls.Add(ListaValores);
            Controls.Add(maskedTextBoxValorBordaCadastroValor);
            Controls.Add(maskedTextBoxValorCadastroValor);
            Controls.Add(labelTitleCadastroValor);
            Controls.Add(buttonFecharCadastroValor);
            Controls.Add(buttonExcluirCadastroValor);
            Controls.Add(buttonEditarCadastroValor);
            Controls.Add(buttonSalvarCadastroValor);
            Controls.Add(listBoxCategoriaCadastroValor);
            Controls.Add(listBoxTamanhoCadastroValor);
            Controls.Add(textBoxIdCadastroValor);
            Controls.Add(labelValor);
            Controls.Add(labelValorBorda);
            Controls.Add(labelCategoria);
            Controls.Add(labelTamanho);
            Controls.Add(labelIdCadastroValor);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CadastroValor";
            Text = "CadastroValor";
            ((System.ComponentModel.ISupportInitialize)ListaValores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCadastroValor;
        private Label labelTamanho;
        private Label labelCategoria;
        private Label labelValorBorda;
        private Label labelValor;
        private TextBox textBoxIdCadastroValor;
        private ListBox listBoxTamanhoCadastroValor;
        private ListBox listBoxCategoriaCadastroValor;
        private Button buttonFecharCadastroValor;
        private Button buttonExcluirCadastroValor;
        private Button buttonEditarCadastroValor;
        private Button buttonSalvarCadastroValor;
        private Label labelTitleCadastroValor;
        private MaskedTextBox maskedTextBoxValorCadastroValor;
        private MaskedTextBox maskedTextBoxValorBordaCadastroValor;
        private DataGridView ListaValores;
        private Button buttonPesquisaCadastroValor;
        private TextBox textBoxPesquisaCadastroValor;
        private Label labelValoresCadastroValor;
    }
}
namespace PizzariaDoZe
{
    partial class CadastroSabor
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
            labelIdCadastroSabor = new Label();
            labelFoto242x242 = new Label();
            labelTipo = new Label();
            labelCategoria = new Label();
            labelNome = new Label();
            textBoxNomeCadastroSabor = new TextBox();
            textBoxIdCadastroSabor = new TextBox();
            listBoxCategoriaCadastroSabor = new ListBox();
            listBoxTipoCadastroSabor = new ListBox();
            pictureBoxFotoCadastroSabor = new PictureBox();
            labelIngredientesCadastroSabor = new Label();
            checkedListBoxIngredienteCadastroSabor = new CheckedListBox();
            buttonFecharCadastroSabor = new Button();
            buttonExcluirCadastroSabor = new Button();
            buttonEditarCadastroSabor = new Button();
            buttonSalvarCadastroSabor = new Button();
            labelTitleCadastroSabor = new Label();
            buttonPesquisaCadastroSabor = new Button();
            ListaSabores = new DataGridView();
            textBoxPesquisaCadastroSabor = new TextBox();
            labelSaboresCadastroSabor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFotoCadastroSabor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListaSabores).BeginInit();
            SuspendLayout();
            // 
            // labelIdCadastroSabor
            // 
            labelIdCadastroSabor.AutoSize = true;
            labelIdCadastroSabor.Location = new Point(17, 77);
            labelIdCadastroSabor.Name = "labelIdCadastroSabor";
            labelIdCadastroSabor.Size = new Size(26, 24);
            labelIdCadastroSabor.TabIndex = 0;
            labelIdCadastroSabor.Text = "Id";
            // 
            // labelFoto242x242
            // 
            labelFoto242x242.AutoSize = true;
            labelFoto242x242.Location = new Point(17, 414);
            labelFoto242x242.Name = "labelFoto242x242";
            labelFoto242x242.Size = new Size(134, 24);
            labelFoto242x242.TabIndex = 1;
            labelFoto242x242.Text = "Foto (242x242)";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(206, 266);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(47, 24);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(17, 266);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(90, 24);
            labelCategoria.TabIndex = 3;
            labelCategoria.Text = "Categoria";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(17, 168);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(60, 24);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            // 
            // textBoxNomeCadastroSabor
            // 
            textBoxNomeCadastroSabor.Location = new Point(17, 195);
            textBoxNomeCadastroSabor.Name = "textBoxNomeCadastroSabor";
            textBoxNomeCadastroSabor.Size = new Size(312, 32);
            textBoxNomeCadastroSabor.TabIndex = 0;
            textBoxNomeCadastroSabor.KeyDown += checkKeyDown;
            // 
            // textBoxIdCadastroSabor
            // 
            textBoxIdCadastroSabor.Location = new Point(17, 104);
            textBoxIdCadastroSabor.Name = "textBoxIdCadastroSabor";
            textBoxIdCadastroSabor.ReadOnly = true;
            textBoxIdCadastroSabor.Size = new Size(90, 32);
            textBoxIdCadastroSabor.TabIndex = 7;
            textBoxIdCadastroSabor.TabStop = false;
            // 
            // listBoxCategoriaCadastroSabor
            // 
            listBoxCategoriaCadastroSabor.FormattingEnabled = true;
            listBoxCategoriaCadastroSabor.ItemHeight = 24;
            listBoxCategoriaCadastroSabor.Items.AddRange(new object[] { "Tradicional", "Especial" });
            listBoxCategoriaCadastroSabor.Location = new Point(17, 293);
            listBoxCategoriaCadastroSabor.Name = "listBoxCategoriaCadastroSabor";
            listBoxCategoriaCadastroSabor.Size = new Size(150, 100);
            listBoxCategoriaCadastroSabor.TabIndex = 8;
            listBoxCategoriaCadastroSabor.TabStop = false;
            // 
            // listBoxTipoCadastroSabor
            // 
            listBoxTipoCadastroSabor.FormattingEnabled = true;
            listBoxTipoCadastroSabor.ItemHeight = 24;
            listBoxTipoCadastroSabor.Items.AddRange(new object[] { "Doce", "Salgada" });
            listBoxTipoCadastroSabor.Location = new Point(206, 293);
            listBoxTipoCadastroSabor.Name = "listBoxTipoCadastroSabor";
            listBoxTipoCadastroSabor.Size = new Size(150, 100);
            listBoxTipoCadastroSabor.TabIndex = 9;
            listBoxTipoCadastroSabor.TabStop = false;
            // 
            // pictureBoxFotoCadastroSabor
            // 
            pictureBoxFotoCadastroSabor.BackColor = SystemColors.ActiveCaption;
            pictureBoxFotoCadastroSabor.BackgroundImage = Properties.Resources.addImagem;
            pictureBoxFotoCadastroSabor.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxFotoCadastroSabor.Location = new Point(17, 441);
            pictureBoxFotoCadastroSabor.Name = "pictureBoxFotoCadastroSabor";
            pictureBoxFotoCadastroSabor.Size = new Size(242, 242);
            pictureBoxFotoCadastroSabor.TabIndex = 10;
            pictureBoxFotoCadastroSabor.TabStop = false;
            pictureBoxFotoCadastroSabor.Click += PictureBox1_Click;
            // 
            // labelIngredientesCadastroSabor
            // 
            labelIngredientesCadastroSabor.AutoSize = true;
            labelIngredientesCadastroSabor.Location = new Point(457, 77);
            labelIngredientesCadastroSabor.Name = "labelIngredientesCadastroSabor";
            labelIngredientesCadastroSabor.Size = new Size(114, 24);
            labelIngredientesCadastroSabor.TabIndex = 5;
            labelIngredientesCadastroSabor.Text = "Ingredientes";
            // 
            // checkedListBoxIngredienteCadastroSabor
            // 
            checkedListBoxIngredienteCadastroSabor.FormattingEnabled = true;
            checkedListBoxIngredienteCadastroSabor.Items.AddRange(new object[] { "Salame", "Queijo", "Ovo", "Bacon" });
            checkedListBoxIngredienteCadastroSabor.Location = new Point(457, 104);
            checkedListBoxIngredienteCadastroSabor.Name = "checkedListBoxIngredienteCadastroSabor";
            checkedListBoxIngredienteCadastroSabor.Size = new Size(232, 490);
            checkedListBoxIngredienteCadastroSabor.TabIndex = 11;
            checkedListBoxIngredienteCadastroSabor.TabStop = false;
            // 
            // buttonFecharCadastroSabor
            // 
            buttonFecharCadastroSabor.BackColor = Color.Blue;
            buttonFecharCadastroSabor.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroSabor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroSabor.Location = new Point(483, 733);
            buttonFecharCadastroSabor.Margin = new Padding(0);
            buttonFecharCadastroSabor.Name = "buttonFecharCadastroSabor";
            buttonFecharCadastroSabor.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroSabor.Size = new Size(102, 48);
            buttonFecharCadastroSabor.TabIndex = 17;
            buttonFecharCadastroSabor.TabStop = false;
            buttonFecharCadastroSabor.Text = "Fechar";
            buttonFecharCadastroSabor.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroSabor.UseVisualStyleBackColor = false;
            buttonFecharCadastroSabor.Click += buttonFecharCadastroSabor_Click;
            // 
            // buttonExcluirCadastroSabor
            // 
            buttonExcluirCadastroSabor.BackColor = Color.Red;
            buttonExcluirCadastroSabor.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroSabor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroSabor.Location = new Point(366, 733);
            buttonExcluirCadastroSabor.Margin = new Padding(0);
            buttonExcluirCadastroSabor.Name = "buttonExcluirCadastroSabor";
            buttonExcluirCadastroSabor.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroSabor.Size = new Size(102, 48);
            buttonExcluirCadastroSabor.TabIndex = 16;
            buttonExcluirCadastroSabor.TabStop = false;
            buttonExcluirCadastroSabor.Text = "Excluir";
            buttonExcluirCadastroSabor.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroSabor.UseVisualStyleBackColor = false;
            buttonExcluirCadastroSabor.Click += buttonExcluirCadastroSabor_Click;
            // 
            // buttonEditarCadastroSabor
            // 
            buttonEditarCadastroSabor.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroSabor.Image = Properties.Resources.editicon;
            buttonEditarCadastroSabor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroSabor.Location = new Point(249, 733);
            buttonEditarCadastroSabor.Margin = new Padding(0);
            buttonEditarCadastroSabor.Name = "buttonEditarCadastroSabor";
            buttonEditarCadastroSabor.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroSabor.Size = new Size(102, 48);
            buttonEditarCadastroSabor.TabIndex = 15;
            buttonEditarCadastroSabor.TabStop = false;
            buttonEditarCadastroSabor.Text = "Editar";
            buttonEditarCadastroSabor.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroSabor.UseVisualStyleBackColor = false;
            buttonEditarCadastroSabor.Click += buttonEditarCadastroSabor_Click;
            // 
            // buttonSalvarCadastroSabor
            // 
            buttonSalvarCadastroSabor.BackColor = Color.YellowGreen;
            buttonSalvarCadastroSabor.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroSabor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroSabor.Location = new Point(131, 733);
            buttonSalvarCadastroSabor.Margin = new Padding(0);
            buttonSalvarCadastroSabor.Name = "buttonSalvarCadastroSabor";
            buttonSalvarCadastroSabor.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroSabor.Size = new Size(102, 48);
            buttonSalvarCadastroSabor.TabIndex = 14;
            buttonSalvarCadastroSabor.TabStop = false;
            buttonSalvarCadastroSabor.Text = "Salvar";
            buttonSalvarCadastroSabor.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroSabor.UseVisualStyleBackColor = false;
            buttonSalvarCadastroSabor.Click += buttonSalvarCadastroSabor_Click;
            // 
            // labelTitleCadastroSabor
            // 
            labelTitleCadastroSabor.AutoSize = true;
            labelTitleCadastroSabor.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCadastroSabor.Location = new Point(185, 19);
            labelTitleCadastroSabor.Name = "labelTitleCadastroSabor";
            labelTitleCadastroSabor.Size = new Size(276, 41);
            labelTitleCadastroSabor.TabIndex = 81;
            labelTitleCadastroSabor.Text = "Cadastro de Sabor";
            // 
            // buttonPesquisaCadastroSabor
            // 
            buttonPesquisaCadastroSabor.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroSabor.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroSabor.Image = Properties.Resources.search;
            buttonPesquisaCadastroSabor.Location = new Point(1097, 109);
            buttonPesquisaCadastroSabor.Margin = new Padding(0);
            buttonPesquisaCadastroSabor.Name = "buttonPesquisaCadastroSabor";
            buttonPesquisaCadastroSabor.Padding = new Padding(5, 0, 5, 0);
            buttonPesquisaCadastroSabor.Size = new Size(44, 32);
            buttonPesquisaCadastroSabor.TabIndex = 85;
            buttonPesquisaCadastroSabor.TabStop = false;
            buttonPesquisaCadastroSabor.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisaCadastroSabor.UseVisualStyleBackColor = false;
            buttonPesquisaCadastroSabor.Click += buttonPesquisaCadastroSabor_Click;
            // 
            // ListaSabores
            // 
            ListaSabores.AllowUserToAddRows = false;
            ListaSabores.AllowUserToDeleteRows = false;
            ListaSabores.AllowUserToOrderColumns = true;
            ListaSabores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ListaSabores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaSabores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaSabores.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaSabores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaSabores.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaSabores.GridColor = SystemColors.InactiveCaption;
            ListaSabores.Location = new Point(773, 168);
            ListaSabores.MultiSelect = false;
            ListaSabores.Name = "ListaSabores";
            ListaSabores.ReadOnly = true;
            ListaSabores.RowHeadersVisible = false;
            ListaSabores.RowHeadersWidth = 51;
            ListaSabores.RowTemplate.Height = 29;
            ListaSabores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaSabores.ShowEditingIcon = false;
            ListaSabores.Size = new Size(489, 188);
            ListaSabores.TabIndex = 84;
            ListaSabores.CellContentDoubleClick += ListaSabores_CellContentDoubleClick;
            ListaSabores.CellFormatting += ListaSabores_CellFormatting;
            // 
            // textBoxPesquisaCadastroSabor
            // 
            textBoxPesquisaCadastroSabor.Location = new Point(771, 109);
            textBoxPesquisaCadastroSabor.Name = "textBoxPesquisaCadastroSabor";
            textBoxPesquisaCadastroSabor.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroSabor.Size = new Size(323, 32);
            textBoxPesquisaCadastroSabor.TabIndex = 83;
            // 
            // labelSaboresCadastroSabor
            // 
            labelSaboresCadastroSabor.AutoSize = true;
            labelSaboresCadastroSabor.Location = new Point(771, 82);
            labelSaboresCadastroSabor.Name = "labelSaboresCadastroSabor";
            labelSaboresCadastroSabor.Size = new Size(76, 24);
            labelSaboresCadastroSabor.TabIndex = 82;
            labelSaboresCadastroSabor.Text = "Sabores";
            // 
            // CadastroSabor
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1352, 790);
            Controls.Add(buttonPesquisaCadastroSabor);
            Controls.Add(ListaSabores);
            Controls.Add(textBoxPesquisaCadastroSabor);
            Controls.Add(labelSaboresCadastroSabor);
            Controls.Add(labelTitleCadastroSabor);
            Controls.Add(buttonFecharCadastroSabor);
            Controls.Add(buttonExcluirCadastroSabor);
            Controls.Add(buttonEditarCadastroSabor);
            Controls.Add(buttonSalvarCadastroSabor);
            Controls.Add(checkedListBoxIngredienteCadastroSabor);
            Controls.Add(pictureBoxFotoCadastroSabor);
            Controls.Add(listBoxTipoCadastroSabor);
            Controls.Add(listBoxCategoriaCadastroSabor);
            Controls.Add(textBoxIdCadastroSabor);
            Controls.Add(textBoxNomeCadastroSabor);
            Controls.Add(labelIngredientesCadastroSabor);
            Controls.Add(labelNome);
            Controls.Add(labelCategoria);
            Controls.Add(labelTipo);
            Controls.Add(labelFoto242x242);
            Controls.Add(labelIdCadastroSabor);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CadastroSabor";
            Text = "CadastroSabor";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFotoCadastroSabor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListaSabores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCadastroSabor;
        private Label labelFoto242x242;
        private Label labelTipo;
        private Label labelCategoria;
        private Label labelNome;
        private TextBox textBoxNomeCadastroSabor;
        private TextBox textBoxIdCadastroSabor;
        private ListBox listBoxCategoriaCadastroSabor;
        private ListBox listBoxTipoCadastroSabor;
        private PictureBox pictureBoxFotoCadastroSabor;
        private Label labelIngredientesCadastroSabor;
        private CheckedListBox checkedListBoxIngredienteCadastroSabor;
        private Button buttonFecharCadastroSabor;
        private Button buttonExcluirCadastroSabor;
        private Button buttonEditarCadastroSabor;
        private Button buttonSalvarCadastroSabor;
        private Label labelTitleCadastroSabor;
        private Button buttonPesquisaCadastroSabor;
        private DataGridView ListaSabores;
        private TextBox textBoxPesquisaCadastroSabor;
        private Label labelSaboresCadastroSabor;
    }
}
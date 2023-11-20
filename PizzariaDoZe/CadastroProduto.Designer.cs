namespace PizzariaDoZe
{
    partial class CadastroProduto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelIdCadastroProduto = new Label();
            textBoxIdCadastroProduto = new TextBox();
            labelNome = new Label();
            labelValor = new Label();
            textBoxValor = new TextBox();
            textBoxNomeCadastroProduto = new TextBox();
            labelTipo = new Label();
            listBoxTipoCadastroProduto = new ListBox();
            labelMl = new Label();
            listBoxMlCadastroProduto = new ListBox();
            buttonSalvarCadastroProduto = new Button();
            buttonEditarCadastroProduto = new Button();
            buttonExcluirCadastroProduto = new Button();
            buttonFecharCadastroProduto = new Button();
            labelTitleCadastroProduto = new Label();
            buttonPesquisaCadastroProduto = new Button();
            ListaProdutos = new DataGridView();
            textBoxPesquisaCadastroProduto = new TextBox();
            labelSaboresCadastroProduto = new Label();
            ((System.ComponentModel.ISupportInitialize)ListaProdutos).BeginInit();
            SuspendLayout();
            // 
            // labelIdCadastroProduto
            // 
            labelIdCadastroProduto.AutoSize = true;
            labelIdCadastroProduto.Location = new Point(42, 91);
            labelIdCadastroProduto.Name = "labelIdCadastroProduto";
            labelIdCadastroProduto.Size = new Size(27, 24);
            labelIdCadastroProduto.TabIndex = 0;
            labelIdCadastroProduto.Text = "ID";
            // 
            // textBoxIdCadastroProduto
            // 
            textBoxIdCadastroProduto.Location = new Point(42, 113);
            textBoxIdCadastroProduto.Name = "textBoxIdCadastroProduto";
            textBoxIdCadastroProduto.ReadOnly = true;
            textBoxIdCadastroProduto.Size = new Size(85, 32);
            textBoxIdCadastroProduto.TabIndex = 1;
            textBoxIdCadastroProduto.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(42, 167);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(60, 24);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(42, 241);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(53, 24);
            labelValor.TabIndex = 3;
            labelValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(42, 263);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(211, 32);
            textBoxValor.TabIndex = 1;
            textBoxValor.KeyDown += checkKeyDown;
            // 
            // textBoxNomeCadastroProduto
            // 
            textBoxNomeCadastroProduto.Location = new Point(42, 189);
            textBoxNomeCadastroProduto.Name = "textBoxNomeCadastroProduto";
            textBoxNomeCadastroProduto.Size = new Size(211, 32);
            textBoxNomeCadastroProduto.TabIndex = 0;
            textBoxNomeCadastroProduto.KeyDown += checkKeyDown;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(392, 91);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(47, 24);
            labelTipo.TabIndex = 6;
            labelTipo.Text = "Tipo";
            // 
            // listBoxTipoCadastroProduto
            // 
            listBoxTipoCadastroProduto.FormattingEnabled = true;
            listBoxTipoCadastroProduto.ItemHeight = 24;
            listBoxTipoCadastroProduto.Items.AddRange(new object[] { "Refrigerante ", "Cerveja", "Suco", "Água ", "Outros" });
            listBoxTipoCadastroProduto.Location = new Point(392, 113);
            listBoxTipoCadastroProduto.Name = "listBoxTipoCadastroProduto";
            listBoxTipoCadastroProduto.Size = new Size(155, 172);
            listBoxTipoCadastroProduto.TabIndex = 7;
            listBoxTipoCadastroProduto.TabStop = false;
            // 
            // labelMl
            // 
            labelMl.AutoSize = true;
            labelMl.Location = new Point(638, 91);
            labelMl.Name = "labelMl";
            labelMl.Size = new Size(35, 24);
            labelMl.TabIndex = 8;
            labelMl.Text = "ML";
            // 
            // listBoxMlCadastroProduto
            // 
            listBoxMlCadastroProduto.FormattingEnabled = true;
            listBoxMlCadastroProduto.ItemHeight = 24;
            listBoxMlCadastroProduto.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBoxMlCadastroProduto.Location = new Point(638, 113);
            listBoxMlCadastroProduto.Name = "listBoxMlCadastroProduto";
            listBoxMlCadastroProduto.Size = new Size(155, 172);
            listBoxMlCadastroProduto.TabIndex = 9;
            listBoxMlCadastroProduto.TabStop = false;
            // 
            // buttonSalvarCadastroProduto
            // 
            buttonSalvarCadastroProduto.BackColor = Color.YellowGreen;
            buttonSalvarCadastroProduto.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroProduto.Location = new Point(197, 410);
            buttonSalvarCadastroProduto.Margin = new Padding(0);
            buttonSalvarCadastroProduto.Name = "buttonSalvarCadastroProduto";
            buttonSalvarCadastroProduto.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroProduto.Size = new Size(102, 48);
            buttonSalvarCadastroProduto.TabIndex = 10;
            buttonSalvarCadastroProduto.TabStop = false;
            buttonSalvarCadastroProduto.Text = "Salvar";
            buttonSalvarCadastroProduto.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroProduto.UseVisualStyleBackColor = false;
            buttonSalvarCadastroProduto.Click += buttonSalvarCadastroProduto_Click;
            // 
            // buttonEditarCadastroProduto
            // 
            buttonEditarCadastroProduto.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroProduto.Image = Properties.Resources.editicon;
            buttonEditarCadastroProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroProduto.Location = new Point(315, 410);
            buttonEditarCadastroProduto.Margin = new Padding(0);
            buttonEditarCadastroProduto.Name = "buttonEditarCadastroProduto";
            buttonEditarCadastroProduto.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroProduto.Size = new Size(102, 48);
            buttonEditarCadastroProduto.TabIndex = 11;
            buttonEditarCadastroProduto.TabStop = false;
            buttonEditarCadastroProduto.Text = "Editar";
            buttonEditarCadastroProduto.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroProduto.UseVisualStyleBackColor = false;
            buttonEditarCadastroProduto.Click += buttonEditarCadastroProduto_Click;
            // 
            // buttonExcluirCadastroProduto
            // 
            buttonExcluirCadastroProduto.BackColor = Color.Red;
            buttonExcluirCadastroProduto.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroProduto.Location = new Point(432, 410);
            buttonExcluirCadastroProduto.Margin = new Padding(0);
            buttonExcluirCadastroProduto.Name = "buttonExcluirCadastroProduto";
            buttonExcluirCadastroProduto.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroProduto.Size = new Size(102, 48);
            buttonExcluirCadastroProduto.TabIndex = 12;
            buttonExcluirCadastroProduto.TabStop = false;
            buttonExcluirCadastroProduto.Text = "Excluir";
            buttonExcluirCadastroProduto.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroProduto.UseVisualStyleBackColor = false;
            buttonExcluirCadastroProduto.Click += buttonExcluirCadastroProduto_Click;
            // 
            // buttonFecharCadastroProduto
            // 
            buttonFecharCadastroProduto.BackColor = Color.Blue;
            buttonFecharCadastroProduto.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroProduto.Location = new Point(549, 410);
            buttonFecharCadastroProduto.Margin = new Padding(0);
            buttonFecharCadastroProduto.Name = "buttonFecharCadastroProduto";
            buttonFecharCadastroProduto.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroProduto.Size = new Size(102, 48);
            buttonFecharCadastroProduto.TabIndex = 13;
            buttonFecharCadastroProduto.TabStop = false;
            buttonFecharCadastroProduto.Text = "Fechar";
            buttonFecharCadastroProduto.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroProduto.UseVisualStyleBackColor = false;
            buttonFecharCadastroProduto.Click += buttonFecharCadastroProduto_Click;
            // 
            // labelTitleCadastroProduto
            // 
            labelTitleCadastroProduto.AutoSize = true;
            labelTitleCadastroProduto.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCadastroProduto.Location = new Point(283, 9);
            labelTitleCadastroProduto.Name = "labelTitleCadastroProduto";
            labelTitleCadastroProduto.Size = new Size(309, 41);
            labelTitleCadastroProduto.TabIndex = 80;
            labelTitleCadastroProduto.Text = "Cadastro de Produto";
            // 
            // buttonPesquisaCadastroProduto
            // 
            buttonPesquisaCadastroProduto.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroProduto.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroProduto.Image = Properties.Resources.search;
            buttonPesquisaCadastroProduto.Location = new Point(366, 490);
            buttonPesquisaCadastroProduto.Margin = new Padding(0);
            buttonPesquisaCadastroProduto.Name = "buttonPesquisaCadastroProduto";
            buttonPesquisaCadastroProduto.Padding = new Padding(5, 0, 5, 0);
            buttonPesquisaCadastroProduto.Size = new Size(44, 32);
            buttonPesquisaCadastroProduto.TabIndex = 89;
            buttonPesquisaCadastroProduto.TabStop = false;
            buttonPesquisaCadastroProduto.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisaCadastroProduto.UseVisualStyleBackColor = false;
            buttonPesquisaCadastroProduto.Click += buttonPesquisaCadastroProduto_Click;
            // 
            // ListaProdutos
            // 
            ListaProdutos.AllowUserToAddRows = false;
            ListaProdutos.AllowUserToDeleteRows = false;
            ListaProdutos.AllowUserToOrderColumns = true;
            ListaProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            ListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            ListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaProdutos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaProdutos.GridColor = SystemColors.InactiveCaption;
            ListaProdutos.Location = new Point(42, 549);
            ListaProdutos.MultiSelect = false;
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.ReadOnly = true;
            ListaProdutos.RowHeadersVisible = false;
            ListaProdutos.RowHeadersWidth = 51;
            ListaProdutos.RowTemplate.Height = 29;
            ListaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaProdutos.ShowEditingIcon = false;
            ListaProdutos.Size = new Size(751, 188);
            ListaProdutos.TabIndex = 88;
            ListaProdutos.CellDoubleClick += ListaProdutos_CellDoubleClick;
            ListaProdutos.CellFormatting += ListaProdutos_CellFormatting;
            // 
            // textBoxPesquisaCadastroProduto
            // 
            textBoxPesquisaCadastroProduto.Location = new Point(40, 490);
            textBoxPesquisaCadastroProduto.Name = "textBoxPesquisaCadastroProduto";
            textBoxPesquisaCadastroProduto.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroProduto.Size = new Size(323, 32);
            textBoxPesquisaCadastroProduto.TabIndex = 87;
            // 
            // labelSaboresCadastroProduto
            // 
            labelSaboresCadastroProduto.AutoSize = true;
            labelSaboresCadastroProduto.Location = new Point(40, 463);
            labelSaboresCadastroProduto.Name = "labelSaboresCadastroProduto";
            labelSaboresCadastroProduto.Size = new Size(86, 24);
            labelSaboresCadastroProduto.TabIndex = 86;
            labelSaboresCadastroProduto.Text = "Produtos";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 784);
            Controls.Add(buttonPesquisaCadastroProduto);
            Controls.Add(ListaProdutos);
            Controls.Add(textBoxPesquisaCadastroProduto);
            Controls.Add(labelSaboresCadastroProduto);
            Controls.Add(labelTitleCadastroProduto);
            Controls.Add(buttonFecharCadastroProduto);
            Controls.Add(buttonExcluirCadastroProduto);
            Controls.Add(buttonEditarCadastroProduto);
            Controls.Add(buttonSalvarCadastroProduto);
            Controls.Add(listBoxMlCadastroProduto);
            Controls.Add(labelMl);
            Controls.Add(listBoxTipoCadastroProduto);
            Controls.Add(labelTipo);
            Controls.Add(textBoxNomeCadastroProduto);
            Controls.Add(textBoxValor);
            Controls.Add(labelValor);
            Controls.Add(labelNome);
            Controls.Add(textBoxIdCadastroProduto);
            Controls.Add(labelIdCadastroProduto);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)ListaProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCadastroProduto;
        private TextBox textBoxIdCadastroProduto;
        private Label labelNome;
        private Label labelValor;
        private TextBox textBoxValor;
        private TextBox textBoxNomeCadastroProduto;
        private Label labelTipo;
        private ListBox listBoxTipoCadastroProduto;
        private Label labelMl;
        private ListBox listBoxMlCadastroProduto;
        private Button buttonSalvarCadastroProduto;
        private Button buttonEditarCadastroProduto;
        private Button buttonExcluirCadastroProduto;
        private Button buttonFecharCadastroProduto;
        private Label labelTitleCadastroProduto;
        private Button buttonPesquisaCadastroProduto;
        private DataGridView ListaProdutos;
        private TextBox textBoxPesquisaCadastroProduto;
        private Label labelSaboresCadastroProduto;
    }
}
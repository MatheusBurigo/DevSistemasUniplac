namespace PizzariaDoZe
{
    partial class CadastroIngredientes
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
            textBoxNomeCadastroIngrediente = new TextBox();
            labelNomeCadastroIngrediente = new Label();
            textBoxIdCadastroIngrediente = new TextBox();
            labelIdCadastroIngrediente = new Label();
            buttonFecharCadastroIngrediente = new Button();
            buttonExcluirCadastroIngrediente = new Button();
            buttonEditarCadastroIngrediente = new Button();
            buttonSalvarCadastroIngrediente = new Button();
            labelIngredientesCadastroIngredientes = new Label();
            textBoxPesquisaCadastroIngredientes = new TextBox();
            ListaIngredientes = new DataGridView();
            buttonPesquisaCadastroIngredientes = new Button();
            ((System.ComponentModel.ISupportInitialize)ListaIngredientes).BeginInit();
            SuspendLayout();
            // 
            // textBoxNomeCadastroIngrediente
            // 
            textBoxNomeCadastroIngrediente.Location = new Point(122, 36);
            textBoxNomeCadastroIngrediente.Name = "textBoxNomeCadastroIngrediente";
            textBoxNomeCadastroIngrediente.Size = new Size(211, 32);
            textBoxNomeCadastroIngrediente.TabIndex = 0;
            textBoxNomeCadastroIngrediente.KeyDown += checkKeyDown;
            // 
            // labelNomeCadastroIngrediente
            // 
            labelNomeCadastroIngrediente.AutoSize = true;
            labelNomeCadastroIngrediente.Location = new Point(122, 14);
            labelNomeCadastroIngrediente.Name = "labelNomeCadastroIngrediente";
            labelNomeCadastroIngrediente.Size = new Size(60, 24);
            labelNomeCadastroIngrediente.TabIndex = 8;
            labelNomeCadastroIngrediente.Text = "Nome";
            // 
            // textBoxIdCadastroIngrediente
            // 
            textBoxIdCadastroIngrediente.Location = new Point(12, 36);
            textBoxIdCadastroIngrediente.Name = "textBoxIdCadastroIngrediente";
            textBoxIdCadastroIngrediente.ReadOnly = true;
            textBoxIdCadastroIngrediente.Size = new Size(85, 32);
            textBoxIdCadastroIngrediente.TabIndex = 7;
            textBoxIdCadastroIngrediente.TabStop = false;
            // 
            // labelIdCadastroIngrediente
            // 
            labelIdCadastroIngrediente.AutoSize = true;
            labelIdCadastroIngrediente.Location = new Point(12, 14);
            labelIdCadastroIngrediente.Name = "labelIdCadastroIngrediente";
            labelIdCadastroIngrediente.Size = new Size(27, 24);
            labelIdCadastroIngrediente.TabIndex = 6;
            labelIdCadastroIngrediente.Text = "ID";
            // 
            // buttonFecharCadastroIngrediente
            // 
            buttonFecharCadastroIngrediente.BackColor = Color.Blue;
            buttonFecharCadastroIngrediente.Image = Properties.Resources.cancelicon;
            buttonFecharCadastroIngrediente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFecharCadastroIngrediente.Location = new Point(598, 426);
            buttonFecharCadastroIngrediente.Margin = new Padding(0);
            buttonFecharCadastroIngrediente.Name = "buttonFecharCadastroIngrediente";
            buttonFecharCadastroIngrediente.Padding = new Padding(5, 0, 5, 0);
            buttonFecharCadastroIngrediente.Size = new Size(102, 48);
            buttonFecharCadastroIngrediente.TabIndex = 17;
            buttonFecharCadastroIngrediente.TabStop = false;
            buttonFecharCadastroIngrediente.Text = "Fechar";
            buttonFecharCadastroIngrediente.TextAlign = ContentAlignment.MiddleRight;
            buttonFecharCadastroIngrediente.UseVisualStyleBackColor = false;
            buttonFecharCadastroIngrediente.Click += buttonFecharCadastroIngrediente_Click;
            // 
            // buttonExcluirCadastroIngrediente
            // 
            buttonExcluirCadastroIngrediente.BackColor = Color.Red;
            buttonExcluirCadastroIngrediente.Image = Properties.Resources.deleteicon;
            buttonExcluirCadastroIngrediente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirCadastroIngrediente.Location = new Point(481, 426);
            buttonExcluirCadastroIngrediente.Margin = new Padding(0);
            buttonExcluirCadastroIngrediente.Name = "buttonExcluirCadastroIngrediente";
            buttonExcluirCadastroIngrediente.Padding = new Padding(5, 0, 5, 0);
            buttonExcluirCadastroIngrediente.Size = new Size(102, 48);
            buttonExcluirCadastroIngrediente.TabIndex = 16;
            buttonExcluirCadastroIngrediente.TabStop = false;
            buttonExcluirCadastroIngrediente.Text = "Excluir";
            buttonExcluirCadastroIngrediente.TextAlign = ContentAlignment.MiddleRight;
            buttonExcluirCadastroIngrediente.UseVisualStyleBackColor = false;
            buttonExcluirCadastroIngrediente.Click += buttonExcluirCadastroIngrediente_Click;
            // 
            // buttonEditarCadastroIngrediente
            // 
            buttonEditarCadastroIngrediente.BackColor = Color.MediumTurquoise;
            buttonEditarCadastroIngrediente.Image = Properties.Resources.editicon;
            buttonEditarCadastroIngrediente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCadastroIngrediente.Location = new Point(364, 426);
            buttonEditarCadastroIngrediente.Margin = new Padding(0);
            buttonEditarCadastroIngrediente.Name = "buttonEditarCadastroIngrediente";
            buttonEditarCadastroIngrediente.Padding = new Padding(5, 0, 5, 0);
            buttonEditarCadastroIngrediente.Size = new Size(102, 48);
            buttonEditarCadastroIngrediente.TabIndex = 15;
            buttonEditarCadastroIngrediente.TabStop = false;
            buttonEditarCadastroIngrediente.Text = "Editar";
            buttonEditarCadastroIngrediente.TextAlign = ContentAlignment.MiddleRight;
            buttonEditarCadastroIngrediente.UseVisualStyleBackColor = false;
            buttonEditarCadastroIngrediente.Click += buttonEditarCadastroIngrediente_Click;
            // 
            // buttonSalvarCadastroIngrediente
            // 
            buttonSalvarCadastroIngrediente.BackColor = Color.YellowGreen;
            buttonSalvarCadastroIngrediente.Image = Properties.Resources.saveicon;
            buttonSalvarCadastroIngrediente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarCadastroIngrediente.Location = new Point(246, 426);
            buttonSalvarCadastroIngrediente.Margin = new Padding(0);
            buttonSalvarCadastroIngrediente.Name = "buttonSalvarCadastroIngrediente";
            buttonSalvarCadastroIngrediente.Padding = new Padding(5, 0, 5, 0);
            buttonSalvarCadastroIngrediente.Size = new Size(102, 48);
            buttonSalvarCadastroIngrediente.TabIndex = 14;
            buttonSalvarCadastroIngrediente.TabStop = false;
            buttonSalvarCadastroIngrediente.Text = "Salvar";
            buttonSalvarCadastroIngrediente.TextAlign = ContentAlignment.MiddleRight;
            buttonSalvarCadastroIngrediente.UseVisualStyleBackColor = false;
            buttonSalvarCadastroIngrediente.Click += buttonSalvarCadastroIngrediente_Click;
            // 
            // labelIngredientesCadastroIngredientes
            // 
            labelIngredientesCadastroIngredientes.AutoSize = true;
            labelIngredientesCadastroIngredientes.Location = new Point(584, 14);
            labelIngredientesCadastroIngredientes.Name = "labelIngredientesCadastroIngredientes";
            labelIngredientesCadastroIngredientes.Size = new Size(114, 24);
            labelIngredientesCadastroIngredientes.TabIndex = 18;
            labelIngredientesCadastroIngredientes.Text = "Ingredientes";
            labelIngredientesCadastroIngredientes.Click += labelIngredientesCadastroIngredientes_Click;
            // 
            // textBoxPesquisaCadastroIngredientes
            // 
            textBoxPesquisaCadastroIngredientes.Location = new Point(584, 41);
            textBoxPesquisaCadastroIngredientes.Name = "textBoxPesquisaCadastroIngredientes";
            textBoxPesquisaCadastroIngredientes.PlaceholderText = "Pesquisa";
            textBoxPesquisaCadastroIngredientes.Size = new Size(323, 32);
            textBoxPesquisaCadastroIngredientes.TabIndex = 19;
            textBoxPesquisaCadastroIngredientes.TextChanged += TextBoxPesquisaCadastroIngredientes_TextChanged;
            // 
            // ListaIngredientes
            // 
            ListaIngredientes.AllowUserToAddRows = false;
            ListaIngredientes.AllowUserToDeleteRows = false;
            ListaIngredientes.AllowUserToOrderColumns = true;
            ListaIngredientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ListaIngredientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaIngredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListaIngredientes.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaIngredientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaIngredientes.GridColor = SystemColors.InactiveCaption;
            ListaIngredientes.Location = new Point(586, 100);
            ListaIngredientes.MultiSelect = false;
            ListaIngredientes.Name = "ListaIngredientes";
            ListaIngredientes.ReadOnly = true;
            ListaIngredientes.RowHeadersVisible = false;
            ListaIngredientes.RowHeadersWidth = 51;
            ListaIngredientes.RowTemplate.Height = 29;
            ListaIngredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaIngredientes.ShowEditingIcon = false;
            ListaIngredientes.Size = new Size(368, 188);
            ListaIngredientes.TabIndex = 20;
            ListaIngredientes.CellContentClick += ListaIngredientes_CellContentClick;
            ListaIngredientes.CellDoubleClick += ListaIngredientes_CellDoubleClick;
            // 
            // buttonPesquisaCadastroIngredientes
            // 
            buttonPesquisaCadastroIngredientes.BackColor = SystemColors.MenuHighlight;
            buttonPesquisaCadastroIngredientes.BackgroundImageLayout = ImageLayout.Center;
            buttonPesquisaCadastroIngredientes.Image = Properties.Resources.search;
            buttonPesquisaCadastroIngredientes.Location = new Point(910, 41);
            buttonPesquisaCadastroIngredientes.Margin = new Padding(0);
            buttonPesquisaCadastroIngredientes.Name = "buttonPesquisaCadastroIngredientes";
            buttonPesquisaCadastroIngredientes.Padding = new Padding(5, 0, 5, 0);
            buttonPesquisaCadastroIngredientes.Size = new Size(44, 32);
            buttonPesquisaCadastroIngredientes.TabIndex = 21;
            buttonPesquisaCadastroIngredientes.TabStop = false;
            buttonPesquisaCadastroIngredientes.TextAlign = ContentAlignment.MiddleRight;
            buttonPesquisaCadastroIngredientes.UseVisualStyleBackColor = false;
            buttonPesquisaCadastroIngredientes.Click += buttonPesquisaCadastroIngredientes_Click;
            // 
            // CadastroIngredientes
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(982, 515);
            Controls.Add(buttonPesquisaCadastroIngredientes);
            Controls.Add(ListaIngredientes);
            Controls.Add(textBoxPesquisaCadastroIngredientes);
            Controls.Add(labelIngredientesCadastroIngredientes);
            Controls.Add(buttonFecharCadastroIngrediente);
            Controls.Add(buttonExcluirCadastroIngrediente);
            Controls.Add(buttonEditarCadastroIngrediente);
            Controls.Add(buttonSalvarCadastroIngrediente);
            Controls.Add(textBoxNomeCadastroIngrediente);
            Controls.Add(labelNomeCadastroIngrediente);
            Controls.Add(textBoxIdCadastroIngrediente);
            Controls.Add(labelIdCadastroIngrediente);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroIngredientes";
            Text = "CadastroIngredientes";
            ((System.ComponentModel.ISupportInitialize)ListaIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomeCadastroIngrediente;
        private Label labelNomeCadastroIngrediente;
        private TextBox textBoxIdCadastroIngrediente;
        private Label labelIdCadastroIngrediente;
        private Button buttonFecharCadastroIngrediente;
        private Button buttonExcluirCadastroIngrediente;
        private Button buttonEditarCadastroIngrediente;
        private Button buttonSalvarCadastroIngrediente;
        private Label labelIngredientesCadastroIngredientes;
        private TextBox textBoxPesquisaCadastroIngredientes;
        private DataGridView ListaIngredientes;
        private Button buttonPesquisaCadastroIngredientes;
    }
}
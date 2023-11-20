namespace PizzariaDoZe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            contextMenuStripMenuPrincipal = new ContextMenuStrip(components);
            toolStripMenuItemCadastroProduto = new ToolStripMenuItem();
            toolStripMenuItemCadastroCliente = new ToolStripMenuItem();
            toolStripMenuItemCadastroFuncionario = new ToolStripMenuItem();
            toolStripMenuItemCadastroIngredientes = new ToolStripMenuItem();
            toolStripMenuItemCadastroSabor = new ToolStripMenuItem();
            toolStripMenuItemCadastroValor = new ToolStripMenuItem();
            toolStripMenuItemCadastroLogradouro = new ToolStripMenuItem();
            toolStripMenuItemConfiguracoes = new ToolStripMenuItem();
            toolStripMenuItemSair = new ToolStripMenuItem();
            buttonConfiguracoesLink = new Button();
            buttonLogout = new Button();
            buttonCadastroLogradouroLink = new Button();
            buttonCadastroValorLink = new Button();
            buttonCadastroClienteLink = new Button();
            buttonCadastroFuncionarioLink = new Button();
            buttonCadastroSaborLink = new Button();
            buttonCadastroIngredienteLink = new Button();
            buttonCadastroProdutoLink = new Button();
            PizzaLogo = new PictureBox();
            labelTitleMenu = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStripMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PizzaLogo).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.ContextMenuStrip = contextMenuStripMenuPrincipal;
            splitContainer1.Panel1.Controls.Add(buttonConfiguracoesLink);
            splitContainer1.Panel1.Controls.Add(buttonLogout);
            splitContainer1.Panel1.Controls.Add(buttonCadastroLogradouroLink);
            splitContainer1.Panel1.Controls.Add(buttonCadastroValorLink);
            splitContainer1.Panel1.Controls.Add(buttonCadastroClienteLink);
            splitContainer1.Panel1.Controls.Add(buttonCadastroFuncionarioLink);
            splitContainer1.Panel1.Controls.Add(buttonCadastroSaborLink);
            splitContainer1.Panel1.Controls.Add(buttonCadastroIngredienteLink);
            splitContainer1.Panel1.Controls.Add(buttonCadastroProdutoLink);
            splitContainer1.Panel1.Controls.Add(PizzaLogo);
            splitContainer1.Panel1.Controls.Add(labelTitleMenu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Size = new Size(914, 722);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // contextMenuStripMenuPrincipal
            // 
            contextMenuStripMenuPrincipal.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStripMenuPrincipal.ImageScalingSize = new Size(20, 20);
            contextMenuStripMenuPrincipal.Items.AddRange(new ToolStripItem[] { toolStripMenuItemCadastroProduto, toolStripMenuItemCadastroCliente, toolStripMenuItemCadastroFuncionario, toolStripMenuItemCadastroIngredientes, toolStripMenuItemCadastroSabor, toolStripMenuItemCadastroValor, toolStripMenuItemCadastroLogradouro, toolStripMenuItemConfiguracoes, toolStripMenuItemSair });
            contextMenuStripMenuPrincipal.Name = "contextMenuStripMenuPrincipal";
            contextMenuStripMenuPrincipal.Size = new Size(367, 256);
            // 
            // toolStripMenuItemCadastroProduto
            // 
            toolStripMenuItemCadastroProduto.Name = "toolStripMenuItemCadastroProduto";
            toolStripMenuItemCadastroProduto.ShortcutKeys = Keys.Shift | Keys.F1;
            toolStripMenuItemCadastroProduto.Size = new Size(366, 28);
            toolStripMenuItemCadastroProduto.Text = "Cadastro de Produto";
            // 
            // toolStripMenuItemCadastroCliente
            // 
            toolStripMenuItemCadastroCliente.Name = "toolStripMenuItemCadastroCliente";
            toolStripMenuItemCadastroCliente.ShortcutKeys = Keys.Shift | Keys.F2;
            toolStripMenuItemCadastroCliente.Size = new Size(366, 28);
            toolStripMenuItemCadastroCliente.Text = "Cadastro de Cliente";
            // 
            // toolStripMenuItemCadastroFuncionario
            // 
            toolStripMenuItemCadastroFuncionario.Name = "toolStripMenuItemCadastroFuncionario";
            toolStripMenuItemCadastroFuncionario.ShortcutKeys = Keys.Shift | Keys.F3;
            toolStripMenuItemCadastroFuncionario.Size = new Size(366, 28);
            toolStripMenuItemCadastroFuncionario.Text = "Cadastro de Funcionario";
            // 
            // toolStripMenuItemCadastroIngredientes
            // 
            toolStripMenuItemCadastroIngredientes.Name = "toolStripMenuItemCadastroIngredientes";
            toolStripMenuItemCadastroIngredientes.ShortcutKeys = Keys.Shift | Keys.F4;
            toolStripMenuItemCadastroIngredientes.Size = new Size(366, 28);
            toolStripMenuItemCadastroIngredientes.Text = "Cadastro de Ingredientes";
            // 
            // toolStripMenuItemCadastroSabor
            // 
            toolStripMenuItemCadastroSabor.Name = "toolStripMenuItemCadastroSabor";
            toolStripMenuItemCadastroSabor.ShortcutKeys = Keys.Shift | Keys.F5;
            toolStripMenuItemCadastroSabor.Size = new Size(366, 28);
            toolStripMenuItemCadastroSabor.Text = "Cadastro de Sabor";
            // 
            // toolStripMenuItemCadastroValor
            // 
            toolStripMenuItemCadastroValor.Name = "toolStripMenuItemCadastroValor";
            toolStripMenuItemCadastroValor.ShortcutKeys = Keys.Shift | Keys.F6;
            toolStripMenuItemCadastroValor.Size = new Size(366, 28);
            toolStripMenuItemCadastroValor.Text = "Cadastro de Valor";
            // 
            // toolStripMenuItemCadastroLogradouro
            // 
            toolStripMenuItemCadastroLogradouro.Name = "toolStripMenuItemCadastroLogradouro";
            toolStripMenuItemCadastroLogradouro.ShortcutKeys = Keys.Shift | Keys.F7;
            toolStripMenuItemCadastroLogradouro.Size = new Size(366, 28);
            toolStripMenuItemCadastroLogradouro.Text = "Cadastro de Logradouro";
            // 
            // toolStripMenuItemConfiguracoes
            // 
            toolStripMenuItemConfiguracoes.Name = "toolStripMenuItemConfiguracoes";
            toolStripMenuItemConfiguracoes.ShortcutKeys = Keys.Shift | Keys.F8;
            toolStripMenuItemConfiguracoes.Size = new Size(366, 28);
            toolStripMenuItemConfiguracoes.Text = "Configurações";
            // 
            // toolStripMenuItemSair
            // 
            toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            toolStripMenuItemSair.ShortcutKeys = Keys.Shift | Keys.Delete;
            toolStripMenuItemSair.Size = new Size(366, 28);
            toolStripMenuItemSair.Text = "Sair";
            // 
            // buttonConfiguracoesLink
            // 
            buttonConfiguracoesLink.BackColor = Color.Transparent;
            buttonConfiguracoesLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfiguracoesLink.Image = Properties.Resources.config;
            buttonConfiguracoesLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonConfiguracoesLink.Location = new Point(3, 501);
            buttonConfiguracoesLink.Margin = new Padding(3, 4, 3, 4);
            buttonConfiguracoesLink.Name = "buttonConfiguracoesLink";
            buttonConfiguracoesLink.Size = new Size(248, 49);
            buttonConfiguracoesLink.TabIndex = 10;
            buttonConfiguracoesLink.TabStop = false;
            buttonConfiguracoesLink.Text = "Con&figurações";
            buttonConfiguracoesLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracoesLink.UseVisualStyleBackColor = false;
            buttonConfiguracoesLink.Click += buttonConfiguracoesLink_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.BackColor = Color.Transparent;
            buttonLogout.BackgroundImageLayout = ImageLayout.None;
            buttonLogout.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.Image = Properties.Resources.logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogout.Location = new Point(3, 669);
            buttonLogout.Margin = new Padding(3, 4, 3, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.RightToLeft = RightToLeft.Yes;
            buttonLogout.Size = new Size(248, 49);
            buttonLogout.TabIndex = 9;
            buttonLogout.TabStop = false;
            buttonLogout.Text = "Sa&ir";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonCadastroLogradouroLink
            // 
            buttonCadastroLogradouroLink.BackColor = Color.Transparent;
            buttonCadastroLogradouroLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroLogradouroLink.Image = Properties.Resources.logradouro;
            buttonCadastroLogradouroLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroLogradouroLink.Location = new Point(3, 444);
            buttonCadastroLogradouroLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroLogradouroLink.Name = "buttonCadastroLogradouroLink";
            buttonCadastroLogradouroLink.Size = new Size(248, 49);
            buttonCadastroLogradouroLink.TabIndex = 8;
            buttonCadastroLogradouroLink.TabStop = false;
            buttonCadastroLogradouroLink.Text = "Cadastr&o de Logradouro";
            buttonCadastroLogradouroLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroLogradouroLink.UseVisualStyleBackColor = false;
            buttonCadastroLogradouroLink.Click += buttonCadastroLogradouro_Click;
            // 
            // buttonCadastroValorLink
            // 
            buttonCadastroValorLink.BackColor = Color.Transparent;
            buttonCadastroValorLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroValorLink.Image = Properties.Resources.valor;
            buttonCadastroValorLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroValorLink.Location = new Point(3, 387);
            buttonCadastroValorLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroValorLink.Name = "buttonCadastroValorLink";
            buttonCadastroValorLink.Size = new Size(248, 49);
            buttonCadastroValorLink.TabIndex = 7;
            buttonCadastroValorLink.TabStop = false;
            buttonCadastroValorLink.Text = "Cadast&ro de Valor";
            buttonCadastroValorLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroValorLink.UseVisualStyleBackColor = false;
            buttonCadastroValorLink.Click += buttonCadastroValorLink_Click;
            // 
            // buttonCadastroClienteLink
            // 
            buttonCadastroClienteLink.BackColor = Color.Transparent;
            buttonCadastroClienteLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroClienteLink.Image = Properties.Resources.cliente;
            buttonCadastroClienteLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroClienteLink.Location = new Point(3, 157);
            buttonCadastroClienteLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroClienteLink.Name = "buttonCadastroClienteLink";
            buttonCadastroClienteLink.Size = new Size(248, 49);
            buttonCadastroClienteLink.TabIndex = 6;
            buttonCadastroClienteLink.TabStop = false;
            buttonCadastroClienteLink.Text = "C&adastro de Cliente";
            buttonCadastroClienteLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroClienteLink.UseVisualStyleBackColor = false;
            buttonCadastroClienteLink.Click += buttonCadastroClienteLink_Click;
            // 
            // buttonCadastroFuncionarioLink
            // 
            buttonCadastroFuncionarioLink.BackColor = Color.Transparent;
            buttonCadastroFuncionarioLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroFuncionarioLink.Image = Properties.Resources.funcionarios;
            buttonCadastroFuncionarioLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroFuncionarioLink.Location = new Point(3, 215);
            buttonCadastroFuncionarioLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroFuncionarioLink.Name = "buttonCadastroFuncionarioLink";
            buttonCadastroFuncionarioLink.Size = new Size(248, 49);
            buttonCadastroFuncionarioLink.TabIndex = 5;
            buttonCadastroFuncionarioLink.TabStop = false;
            buttonCadastroFuncionarioLink.Text = "Ca&dastro de Funcionário";
            buttonCadastroFuncionarioLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroFuncionarioLink.UseVisualStyleBackColor = false;
            buttonCadastroFuncionarioLink.Click += buttonCadastroFuncionarioLink_Click;
            // 
            // buttonCadastroSaborLink
            // 
            buttonCadastroSaborLink.BackColor = Color.Transparent;
            buttonCadastroSaborLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroSaborLink.Image = Properties.Resources.sabor1;
            buttonCadastroSaborLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroSaborLink.Location = new Point(3, 329);
            buttonCadastroSaborLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroSaborLink.Name = "buttonCadastroSaborLink";
            buttonCadastroSaborLink.Size = new Size(248, 49);
            buttonCadastroSaborLink.TabIndex = 4;
            buttonCadastroSaborLink.TabStop = false;
            buttonCadastroSaborLink.Text = "Cadas&tro de Sabor";
            buttonCadastroSaborLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroSaborLink.UseVisualStyleBackColor = false;
            buttonCadastroSaborLink.Click += buttonCadastroSaborLink_Click;
            // 
            // buttonCadastroIngredienteLink
            // 
            buttonCadastroIngredienteLink.BackColor = Color.Transparent;
            buttonCadastroIngredienteLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroIngredienteLink.Image = Properties.Resources.ingrediente;
            buttonCadastroIngredienteLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroIngredienteLink.Location = new Point(3, 272);
            buttonCadastroIngredienteLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroIngredienteLink.Name = "buttonCadastroIngredienteLink";
            buttonCadastroIngredienteLink.Size = new Size(248, 49);
            buttonCadastroIngredienteLink.TabIndex = 3;
            buttonCadastroIngredienteLink.TabStop = false;
            buttonCadastroIngredienteLink.Text = "Cada&stro de Ingredientes";
            buttonCadastroIngredienteLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroIngredienteLink.UseVisualStyleBackColor = false;
            buttonCadastroIngredienteLink.Click += buttonCadastroIngredienteLink_Click;
            // 
            // buttonCadastroProdutoLink
            // 
            buttonCadastroProdutoLink.BackColor = Color.Transparent;
            buttonCadastroProdutoLink.BackgroundImageLayout = ImageLayout.Center;
            buttonCadastroProdutoLink.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastroProdutoLink.Image = Properties.Resources.product_2652218;
            buttonCadastroProdutoLink.ImageAlign = ContentAlignment.MiddleRight;
            buttonCadastroProdutoLink.Location = new Point(3, 100);
            buttonCadastroProdutoLink.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroProdutoLink.Name = "buttonCadastroProdutoLink";
            buttonCadastroProdutoLink.Size = new Size(248, 49);
            buttonCadastroProdutoLink.TabIndex = 2;
            buttonCadastroProdutoLink.TabStop = false;
            buttonCadastroProdutoLink.Text = "&Cadastro de Produto";
            buttonCadastroProdutoLink.TextAlign = ContentAlignment.MiddleLeft;
            buttonCadastroProdutoLink.UseVisualStyleBackColor = false;
            buttonCadastroProdutoLink.Click += buttonCadastroProdutoLink_Click;
            // 
            // PizzaLogo
            // 
            PizzaLogo.BackgroundImage = Properties.Resources.pizza;
            PizzaLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PizzaLogo.Location = new Point(205, 19);
            PizzaLogo.Margin = new Padding(3, 4, 3, 4);
            PizzaLogo.Name = "PizzaLogo";
            PizzaLogo.Size = new Size(27, 32);
            PizzaLogo.TabIndex = 1;
            PizzaLogo.TabStop = false;
            // 
            // labelTitleMenu
            // 
            labelTitleMenu.AutoSize = true;
            labelTitleMenu.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleMenu.ImageAlign = ContentAlignment.MiddleRight;
            labelTitleMenu.Location = new Point(14, 12);
            labelTitleMenu.Name = "labelTitleMenu";
            labelTitleMenu.Size = new Size(187, 37);
            labelTitleMenu.TabIndex = 0;
            labelTitleMenu.Text = "Pizzaria do Zé";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(914, 722);
            ContextMenuStrip = contextMenuStripMenuPrincipal;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            FormClosing += ClosingForm;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStripMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PizzaLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label labelTitleMenu;
        private PictureBox PizzaLogo;
        private Button buttonCadastroProdutoLink;
        private Button buttonCadastroValorLink;
        private Button buttonCadastroClienteLink;
        private Button buttonCadastroFuncionarioLink;
        private Button buttonCadastroSaborLink;
        private Button buttonCadastroIngredienteLink;
        private Button buttonCadastroLogradouroLink;
        private Button buttonLogout;
        private Button buttonConfiguracoesLink;
        private ContextMenuStrip contextMenuStripMenuPrincipal;
        private ToolStripMenuItem toolStripMenuItemCadastroProduto;
        private ToolStripMenuItem toolStripMenuItemCadastroCliente;
        private ToolStripMenuItem toolStripMenuItemCadastroFuncionario;
        private ToolStripMenuItem toolStripMenuItemCadastroIngredientes;
        private ToolStripMenuItem toolStripMenuItemCadastroSabor;
        private ToolStripMenuItem toolStripMenuItemCadastroValor;
        private ToolStripMenuItem toolStripMenuItemCadastroLogradouro;
        private ToolStripMenuItem toolStripMenuItemConfiguracoes;
        private ToolStripMenuItem toolStripMenuItemSair;
    }
}
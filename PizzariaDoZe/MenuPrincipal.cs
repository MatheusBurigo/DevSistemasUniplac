using PizzariaDoZe.utils;
namespace PizzariaDoZe
{
    /// <summary>
    /// Formulario principal com links para os menus
    /// </summary>
    public partial class Form1 : Form
    {
        private Form? actualForm;

        /// <summary>
        /// Formulario principal com links para os menus
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this.splitContainer1.Panel1);
            Funcoes.AjustaResourcesItem(contextMenuStripMenuPrincipal);
            Funcoes.EventoFocoCampos(this);
            createTooltips();
            setToolStripMenuItemClick();
            splitContainer1.Dock = DockStyle.Fill;
        }

        private void setToolStripMenuItemClick()
        {
            toolStripMenuItemCadastroProduto.Click += new EventHandler(buttonCadastroProdutoLink_Click!);
            toolStripMenuItemCadastroCliente.Click += new EventHandler(buttonCadastroClienteLink_Click!);
            toolStripMenuItemCadastroFuncionario.Click += new EventHandler(buttonCadastroFuncionarioLink_Click!);
            toolStripMenuItemCadastroIngredientes.Click += new EventHandler(buttonCadastroIngredienteLink_Click!);
            toolStripMenuItemCadastroSabor.Click += new EventHandler(buttonCadastroSaborLink_Click!);
            toolStripMenuItemCadastroValor.Click += new EventHandler(buttonCadastroValorLink_Click!);
            toolStripMenuItemCadastroLogradouro.Click += new EventHandler(buttonCadastroLogradouro_Click!);
            toolStripMenuItemConfiguracoes.Click += new EventHandler(buttonConfiguracoesLink_Click!);
            toolStripMenuItemSair.Click += new EventHandler(buttonLogout_Click!);
        }

        private void createTooltips()
        {
            new ToolTip().SetToolTip(buttonCadastroProdutoLink, "SHIFT + F1");
            new ToolTip().SetToolTip(buttonCadastroClienteLink, "SHIFT + F2");
            new ToolTip().SetToolTip(buttonCadastroFuncionarioLink, "SHIFT + F3");
            new ToolTip().SetToolTip(buttonCadastroIngredienteLink, "SHIFT + F4");
            new ToolTip().SetToolTip(buttonCadastroSaborLink, "SHIFT + F5");
            new ToolTip().SetToolTip(buttonCadastroValorLink, "SHIFT + F6");
            new ToolTip().SetToolTip(buttonCadastroLogradouroLink, "SHIFT + F7");
            new ToolTip().SetToolTip(buttonConfiguracoesLink, "SHIFT + F8");
            new ToolTip().SetToolTip(buttonLogout, "SHIFT + DEL");
        }

        private void buttonCadastroProdutoLink_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            this.openNewForm(cadastroProduto);
        }

        private void buttonCadastroClienteLink_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            this.openNewForm(cadastroCliente);
        }

        private void buttonCadastroFuncionarioLink_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            this.openNewForm(cadastroFuncionario);
        }

        private void buttonCadastroLogradouro_Click(object sender, EventArgs e)
        {
            CadastroLogradouro cadastroLogradouro = new CadastroLogradouro();
            this.openNewForm(cadastroLogradouro);
        }

        private void buttonCadastroIngredienteLink_Click(object sender, EventArgs e)
        {
            CadastroIngredientes cadastroIngredientes = new CadastroIngredientes();
            this.openNewForm(cadastroIngredientes);
        }

        private void buttonCadastroSaborLink_Click(object sender, EventArgs e)
        {
            CadastroSabor cadastroSabor = new CadastroSabor();
            this.openNewForm(cadastroSabor);
        }

        private void buttonCadastroValorLink_Click(object sender, EventArgs e)
        {
            CadastroValor cadastroValor = new CadastroValor();
            this.openNewForm(cadastroValor);
        }

        private void buttonConfiguracoesLink_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new Configuracoes();
            this.openNewForm(configuracoes);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Configure and opens a new form
        private void openNewForm(Form form)
        {
            form.TopLevel = false;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;
            this.splitContainer1.Panel2.Controls.Add(form);
            Funcoes.AjustaResourcesControl(this.splitContainer1.Panel2);
            if (this.actualForm != null) this.actualForm.Close();
            this.actualForm = form;
            form.Show();
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            string message = Properties.Resources.ResourceManager.GetString("txtLogoutQuestion")!;
            string exit = Properties.Resources.ResourceManager.GetString("txtExit")!;
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show(message, exit,
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
        }
    }
}
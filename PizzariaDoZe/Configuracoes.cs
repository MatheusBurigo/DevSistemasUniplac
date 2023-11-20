using PizzariaDoZe.utils;
namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de configuração
    /// </summary>
    public partial class Configuracoes : Form
    {
        /// <summary>
        /// Formulário de cadastro de configuração inicialização
        /// </summary>
        public Configuracoes()
        {
            InitializeComponent();
            Funcoes.configComboBox(comboBoxIdiomaConfig);
            Funcoes.EventoFocoCampos(this);
        }

        private void buttonFecharConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIdiomaConfig_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Funcoes.AjustaIdiomaArquivoConfig(comboBoxIdiomaConfig);

                //atualiza a cultura corrente
                Program.AjustaIdiomaRegiao();
                Funcoes.AjustaResourcesControl(Funcoes.getControlPath(this));
                _ = MessageBox.Show("Idioma/região alterada com sucesso!");
            }
        }
    }
}

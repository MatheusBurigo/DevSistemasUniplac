using PizzariaDoZe.DAO;
using PizzariaDoZe.utils;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de logradouro
    /// </summary>
    public partial class CadastroLogradouro : Form
    {

        private readonly EnderecoDAO enderecoDAO;

        /// <summary>
        /// Formulário de cadastro de logradouro inicialização
        /// </summary>
        public CadastroLogradouro()
        {
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            enderecoDAO = new EnderecoDAO(provider, strConnection);

            SearchEnderecos();
        }

        private void buttonFecharCadastroLogradouro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        private void buttonPesquisaCadastroIngredientes_Click(object sender, EventArgs e)
        {
            SearchEnderecos();
        }

        private void SearchEnderecos()
        {
            //Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco
            {
                Id = 0,
                Cep = textBoxPesquisaCadastroIngredientes.Text
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta o datasouce do dataGridView com os dados retornados
                ListaEnderecos.Columns.Clear();
                ListaEnderecos.AutoGenerateColumns = true;
                ListaEnderecos.DataSource = linhas;
                ListaEnderecos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvarCadastroLogradouro_Click(object sender, EventArgs e)
        {

        }
    }
}

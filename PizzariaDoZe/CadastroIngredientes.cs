using PizzariaDoZe.utils;
using PizzariaDoZe.DAO;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    /// <summary>
    /// Cadastro de ingredientes forms
    /// </summary>
    public partial class CadastroIngredientes : Form
    {
        private readonly IngredienteDAO dao;

        /// <summary>
        /// Cadastro de ingredientes forms
        /// </summary>
        public CadastroIngredientes()
        {
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);
            SearchIngredientes("", true);
        }

        private void buttonFecharCadastroIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Checa se uma tecla foi pressionada
        /// </summary>
        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        /// <summary>
        /// Salva o ingrediente digitado na tela no banco de dados
        /// </summary>
        private void buttonSalvarCadastroIngrediente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroIngrediente.Text == "")
            {
                //Instância e Preenche o objeto com os dados da view
                var ingrediente = new Ingrediente()
                {
                    Id = 0,
                    Nome = textBoxNomeCadastroIngrediente.Text,
                };

                if (ingrediente.Nome != "")
                {
                    try
                    {
                        string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataInsertWithSuccess")!;
                        // chama o método para inserir da camada model
                        dao.Inserir(ingrediente);
                        MessageBox.Show(txtMessageBox);
                        cleanFormAndUpdateList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtFillIngredientName")!;
                    MessageBox.Show(txtMessageBox);
                }
            }
            else
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectEmployeeToEdit")!;
                MessageBox.Show(txtMessageBox);
            }
        }

        /// <summary>
        /// Pesquisa e mostra na lista os ingredientes 
        /// segundo o que está escrito no campo de busca
        /// </summary>
        private void buttonPesquisaCadastroIngredientes_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisaCadastroIngredientes.Text != "")
            {
                SearchIngredientes(textBoxPesquisaCadastroIngredientes.Text);
            }
            else
            {
                SearchIngredientes("", true);
            }
        }

        /// <summary>
        /// Preenche a tabela com os dados
        /// </summary>
        /// <param name="dt">Dados para preencher a tabela</param>
        private void fillGrid(DataTable dt)
        {
            // seta o datasouce do dataGridView com os dados retornados
            ListaIngredientes.Columns.Clear();
            ListaIngredientes.AutoGenerateColumns = true;
            ListaIngredientes.DataSource = dt;
            ListaIngredientes.Refresh();
        }

        /// <summary>
        /// Pesquisa pelo ingrediente e popula os campos da tela para edição
        /// </summary>
        /// <param name="id">Identificador do ingrediente</param>
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente, false);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCadastroIngrediente.Text = row[0].ToString();
                    textBoxNomeCadastroIngrediente.Text = row[1].ToString();
                }
                textBoxNomeCadastroIngrediente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Edita os dados do ingrediente no banco
        /// </summary>
        private void buttonEditarCadastroIngrediente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroIngrediente.Text != "")
            {
                //Instância e Preenche o objeto com os dados da view
                var ingrediente = new Ingrediente
                {
                    Id = int.Parse(textBoxIdCadastroIngrediente.Text),
                    Nome = textBoxNomeCadastroIngrediente.Text,
                };
                try
                {
                    string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataEditWithSuccess")!;
                    // chama o método da model para editar
                    dao.Editar(ingrediente);
                    MessageBox.Show(txtMessageBox);
                    cleanFormAndUpdateList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectIngredientToEdit")!;
                MessageBox.Show(txtMessageBox);
            }
        }

        /// <summary>
        /// Escuta o double click na célula da lista
        /// </summary>
        private void ListaIngredientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaIngredientes.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = ListaIngredientes.Rows[ListaIngredientes.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        /// <summary>
        /// Exclui o ingrediente no banco de dados
        /// </summary>
        private void buttonExcluirCadastroIngrediente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroIngrediente.Text.Length <= 0)
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectIngredient")!;
                MessageBox.Show(txtMessageBox);
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = int.Parse(textBoxIdCadastroIngrediente.Text),
            };
            try
            {
                string txtMessageBoxQuestion = Properties.Resources.ResourceManager.GetString("txtQuestionDeleteIngredient")!;
                string txtMessageBoxAttention = Properties.Resources.ResourceManager.GetString("txtAttention")!;
                DialogResult dialog = MessageBox.Show(txtMessageBoxQuestion, txtMessageBoxAttention, MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    // chama o método da model para excluir
                    dao.Excluir(ingrediente);
                    string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataDeleteWithSuccess")!;
                    MessageBox.Show(txtMessageBox + " " + textBoxIdCadastroIngrediente.Text);
                    cleanFormAndUpdateList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Limpa o formulário e atualiza os ingredientes na lista
        /// </summary>
        private void cleanFormAndUpdateList()
        {
            cleanForm();
            SearchIngredientes("", true);
        }

        /// <summary>
        /// Limpa o formulário
        /// </summary>
        private void cleanForm()
        {
            this.Controls.ClearControls();
        }

        /// <summary>
        /// Procura pelos ingredientes no banco de dados
        /// </summary>
        /// <param name="text">Texto para pesquisar no banco</param>
        /// <param name="fetchAll">Variável para pesquisar todos os valores</param>
        private void SearchIngredientes(string text = "", bool fetchAll = false)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = text,
            };

            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente, fetchAll);
                fillGrid(linhas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxPesquisaCadastroIngredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIngredientesCadastroIngredientes_Click(object sender, EventArgs e)
        {
        }

        private void ListaIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

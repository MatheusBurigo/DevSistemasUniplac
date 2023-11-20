using PizzariaDoZe.DAO;
using PizzariaDoZe.utils;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de Cliente
    /// </summary>
    public partial class CadastroCliente : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;

        /// <summary>
        /// Formulário de cadastro de Cliente incialização
        /// </summary>
        public CadastroCliente()
        {
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);

            SearchCliente();

        }

        private void buttonFecharCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        private void maskedTextBoxCepCadastroCliente_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCepCadastroCliente.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTextBoxCepCadastroCliente.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                textBoxIdLogradouroCadastroCliente.Text = "";
                textBoxLogradouroCadastroCliente.Text = "";
                textBoxBairroCadastroCliente.Text = "";
                comboBoxCidadeCadastroCliente.Text = "";
                comboBoxUfCadastroCliente.Text = "";
                comboBoxPaisCadastroCliente.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdLogradouroCadastroCliente.Text = row["id"].ToString();
                    textBoxLogradouroCadastroCliente.Text = row["logradouro"].ToString();
                    textBoxBairroCadastroCliente.Text = row["bairro"].ToString();
                    comboBoxCidadeCadastroCliente.Text = row["cidade"].ToString();
                    comboBoxUfCadastroCliente.Text = row["uf"].ToString();
                    comboBoxPaisCadastroCliente.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroCliente.Text == "")
            {
                if (ValidForm())
                {
                    //Instância e Preenche o objeto com os dados da view
                    Cliente cliente = createCliente();
                    try
                    {
                        string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataInsertWithSuccess")!;
                        // chama o método da model para inserir e capturar o ID do cliente
                        clienteDAO.Inserir(cliente);
                        MessageBox.Show(txtMessageBox);
                        cleanFormAndUpdateList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtClientAlreadyAdd")!;
                MessageBox.Show(txtMessageBox);
            }
        }

        private Cliente createCliente()
        {
            return new Cliente
            {
                Id = textBoxIdCadastroCliente.Text == "" ? 0 : Int16.Parse(textBoxIdCadastroCliente.Text),
                Nome = textBoxNomeCadastroCliente.Text,
                Cpf = maskedTextBoxCpfCadastroCliente.Text,
                Telefone = maskedTextBoxTelefoneCadastroCliente.Text,
                Email = textBoxEmailCadastroCliente.Text,
                EnderecoId = int.Parse(textBoxIdLogradouroCadastroCliente.Text),
                Numero = textBoxNumeroCadastroCliente.Text,
                Complemento = textBoxComplementoCadastroCliente.Text,
            };
        }

        private bool ValidForm()
        {
            if (textBoxIdLogradouroCadastroCliente.Text.Length <= 0)
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectValidAddress")!;
                MessageBox.Show("Selecione um endereço valido!");
                return false;
            }

            if (textBoxNomeCadastroCliente.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypeName")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (maskedTextBoxTelefoneCadastroCliente.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypePhone")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (textBoxNumeroCadastroCliente.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypeNumber")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            return true;
        }

        private void SearchCliente()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = textBoxPesquisaCadastroClientes.Text
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                ListaClientes.Columns.Clear();
                ListaClientes.AutoGenerateColumns = true;
                ListaClientes.DataSource = linhas;
                ListaClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPesquisaCadastroIngredientes_Click(object sender, EventArgs e)
        {
            SearchCliente();
        }

        private void ListaClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListaClientes.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = ListaClientes.Rows[ListaClientes.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void buttonEditarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroCliente.Text != "")
            {
                if (ValidForm())
                {
                    //Instância e Preenche o objeto com os dados da view
                    var cliente = createCliente();

                    try
                    {
                        string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataEditWithSuccess")!;
                        // chama o método da model para editar
                        clienteDAO.Editar(cliente);
                        MessageBox.Show(txtMessageBox);
                        cleanFormAndUpdateList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } else
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectClientToEdit")!;
                MessageBox.Show(txtMessageBox);
            }
        }

        private void buttonExcluirCadastroCliente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroCliente.Text.Length <= 0)
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataSelectOneClient")!;
                MessageBox.Show(txtMessageBox);
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            Cliente cliente = new Cliente
            {
                Id = int.Parse(textBoxIdCadastroCliente.Text),
            };

            try
            {
                string txtMessageBoxQuestion = Properties.Resources.ResourceManager.GetString("txtQuestionDeleteClient")!;
                string txtMessageBoxAttention = Properties.Resources.ResourceManager.GetString("txtAttention")!;
                DialogResult dialog = MessageBox.Show(txtMessageBoxQuestion, txtMessageBoxAttention, MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    // chama o método da model para excluir
                    clienteDAO.Excluir(cliente);
                    string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataDeleteWithSuccess")!;
                    MessageBox.Show(txtMessageBox);
                    cleanFormAndUpdateList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCadastroCliente.Text = row[0].ToString();
                    textBoxNomeCadastroCliente.Text = row[1].ToString();
                    maskedTextBoxCpfCadastroCliente.Text = row[2].ToString();
                    maskedTextBoxTelefoneCadastroCliente.Text = row[3].ToString();
                    textBoxEmailCadastroCliente.Text = row[4].ToString();
                    textBoxIdLogradouroCadastroCliente.Text = row[5].ToString();
                    maskedTextBoxCepCadastroCliente.Text = row[6].ToString();
                    textBoxLogradouroCadastroCliente.Text = row[7].ToString();
                    textBoxBairroCadastroCliente.Text = row[8].ToString();
                    comboBoxCidadeCadastroCliente.Text = row[10].ToString();
                    comboBoxUfCadastroCliente.Text = row[12].ToString();
                    comboBoxPaisCadastroCliente.Text = row[14].ToString();
                    textBoxNumeroCadastroCliente.Text = row[15].ToString();
                    textBoxComplementoCadastroCliente.Text = row[16].ToString();
                }
                textBoxNomeCadastroCliente.Focus();
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
            SearchCliente();
        }

        /// <summary>
        /// Limpa o formulário
        /// </summary>
        private void cleanForm()
        {
            this.Controls.ClearControls();
            comboBoxCidadeCadastroCliente.SelectedIndex = -1;
            comboBoxPaisCadastroCliente.SelectedIndex = -1;
            comboBoxUfCadastroCliente.SelectedIndex = -1;
        }
    }
}

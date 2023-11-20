using PizzariaDoZe.DAO;
using PizzariaDoZe.utils;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de Funcionário
    /// </summary>
    public partial class CadastroFuncionario : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;

        /// <summary>
        /// Formulário de cadastro de Funcionário inicialização
        /// </summary>
        public CadastroFuncionario()
        {
            InitializeComponent();
            dateTimePickerCadastroFuncionario.Format = DateTimePickerFormat.Custom;
            dateTimePickerCadastroFuncionario.CustomFormat = "dd/MM/yyyy";
            Funcoes.EventoFocoCampos(this);
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            maskedTextBoxCepCadastroFuncionario.Leave += MaskedTextBoxCep_Leave;
            SearchFuncionario();
        }

        private void buttonFecharCadastroFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        private void MaskedTextBoxCep_Leave(object? sender, EventArgs e)
        {
            if (maskedTextBoxCepCadastroFuncionario.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTextBoxCepCadastroFuncionario.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                textBoxIdLogradouroCadastroFuncionario.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                textBoxLogradouroCadastroFuncionario.Text = "";
                textBoxBairroCadastroFuncionario.Text = "";
                comboBoxCidadeCadastroFuncionario.Text = "";
                comboBoxUfCadastroFuncionario.Text = "";
                comboBoxPaisCadastroFuncionario.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdLogradouroCadastroFuncionario.Text = row["id"].ToString();
                    maskedTextBoxCepCadastroFuncionario.Text = row["cep"].ToString();
                    textBoxLogradouroCadastroFuncionario.Text = row["logradouro"].ToString();
                    textBoxBairroCadastroFuncionario.Text = row["bairro"].ToString();
                    comboBoxCidadeCadastroFuncionario.Text = row["cidade"].ToString();
                    comboBoxUfCadastroFuncionario.Text = row["uf"].ToString();
                    comboBoxPaisCadastroFuncionario.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalvarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroFuncionario.Text == "")
            {
                if (ValidForm())
                {
                    //Instância e Preenche o objeto com os dados da view
                    Funcionario funcionario = createFuncionario();
                    try
                    {
                        string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataInsertWithSuccess")!;
                        // chama o método da model para inserir e capturar o ID do cliente
                        funcionarioDAO.Inserir(funcionario);
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
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtEmployeeAlreadyAdd")!;
                MessageBox.Show(txtMessageBox);
            }
        }

        private Funcionario createFuncionario()
        {
            return new Funcionario
            {
                Id = textBoxIdCadastroFuncionario.Text == "" ? 0 : Int16.Parse(textBoxIdCadastroFuncionario.Text),
                Nome = textBoxNomeCadastroFuncionario.Text,
                Cpf = maskedTextBoxCpfCadastroFuncionario.Text,
                Matricula = textBoxMatriculaCadastroFuncionario.Text,
                Senha = Funcoes.Sha256Hash(textBoxSenhaCadastroFuncionario.Text),
                Grupo = (radioButtonAdministradorCadastroFuncionario.Checked) ? '1' : (radioButtonAtendenteCadastroFuncionario.Checked) ? '2' : '3',
                Motorista = textBoxCarteiraMotoristaCadastroFuncionario.Text,
                Validade = dateTimePickerCadastroFuncionario.Value,
                Observacao = richTextBoxObservacaoCadastroFuncionario.Text,
                Telefone = maskedTextBoxTelefoneCadastroFuncionario.Text,
                Email = textBoxEmailCadastroFuncionario.Text,
                EnderecoId = int.Parse(textBoxIdLogradouroCadastroFuncionario.Text),
                Numero = textBoxNumeroCadastroFuncionario.Text,
                Complemento = textBoxComplementoCadastroFuncionario.Text,
            };
        }

        private bool ValidForm()
        {
            if (textBoxIdLogradouroCadastroFuncionario.Text.Length <= 0)
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectValidAddress")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (textBoxNomeCadastroFuncionario.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypeName")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (textBoxMatriculaCadastroFuncionario.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypeRegistration")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (maskedTextBoxCpfCadastroFuncionario.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypeCpf")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (!(radioButtonAdministradorCadastroFuncionario.Checked) && !(radioButtonAtendenteCadastroFuncionario.Checked) && !(radioButtonEntregadorCadastroFuncionario.Checked))
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectGroup")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            if (textBoxNumeroCadastroFuncionario.Text == "")
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtTypeNumber")!;
                MessageBox.Show(txtMessageBox);
                return false;
            }

            return true;
        }

        private void SearchFuncionario()
        {
            //Instância e Preenche o objeto com os dados da view
            Funcionario funcionario = new Funcionario
            {
                Id = 0,
                Nome = textBoxPesquisaCadastroFuncionarios.Text
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta o datasouce do dataGridView com os dados retornados
                ListaFuncionarios.Columns.Clear();
                ListaFuncionarios.AutoGenerateColumns = true;
                ListaFuncionarios.DataSource = linhas;
                ListaFuncionarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPesquisaCadastroIngredientes_Click(object sender, EventArgs e)
        {
            SearchFuncionario();
        }

        private void ListaFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.ListaFuncionarios.NewRowIndex || e.Value!.ToString()!.Trim().Length == 0)
            {
                return;
            }
            if (this.ListaFuncionarios.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()!));
            }
            else if (this.ListaFuncionarios.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.ListaFuncionarios.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.ListaFuncionarios.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.ListaFuncionarios.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString()!);
                e.Value = d.ToString("N2");
            }
        }

        private void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCadastroFuncionario.Text = row[0].ToString();
                    textBoxNomeCadastroFuncionario.Text = row[1].ToString();
                    maskedTextBoxCpfCadastroFuncionario.Text = row[2].ToString();
                    textBoxMatriculaCadastroFuncionario.Text = row[3].ToString();
                    textBoxSenhaCadastroFuncionario.Text = row[4].ToString();
                    if (row[5].ToString()!.Equals("1"))
                    {
                        radioButtonAdministradorCadastroFuncionario.Checked = true;
                    }
                    else if (row[5].ToString()!.Equals("2"))
                    {
                        radioButtonAtendenteCadastroFuncionario.Checked = true;
                    }
                    else
                    {
                        radioButtonEntregadorCadastroFuncionario.Checked = true;
                    }
                    textBoxCarteiraMotoristaCadastroFuncionario.Text = row[6].ToString();
                    dateTimePickerCadastroFuncionario.Text = row[7].ToString();
                    richTextBoxObservacaoCadastroFuncionario.Text = row[8].ToString();
                    maskedTextBoxTelefoneCadastroFuncionario.Text = row[9].ToString();
                    textBoxEmailCadastroFuncionario.Text = row[10].ToString();
                    textBoxIdLogradouroCadastroFuncionario.Text = row[11].ToString();
                    maskedTextBoxCepCadastroFuncionario.Text = row[12].ToString();
                    textBoxLogradouroCadastroFuncionario.Text = row[13].ToString();
                    textBoxBairroCadastroFuncionario.Text = row[14].ToString();
                    comboBoxCidadeCadastroFuncionario.Text = row[16].ToString();
                    comboBoxUfCadastroFuncionario.Text = row[18].ToString();
                    comboBoxUfCadastroFuncionario.Text = row[20].ToString();
                    textBoxNumeroCadastroFuncionario.Text = row[21].ToString();
                    textBoxComplementoCadastroFuncionario.Text = row[22].ToString();
                }
                textBoxNomeCadastroFuncionario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaFuncionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListaFuncionarios.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = ListaFuncionarios.Rows[ListaFuncionarios.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void buttonEditarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroFuncionario.Text != "")
            {
                if (ValidForm())
                {
                    //Instância e Preenche o objeto com os dados da view
                    var funcionario = createFuncionario();

                    try
                    {
                        string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataEditWithSuccess")!;
                        // chama o método da model para editar
                        funcionarioDAO.Editar(funcionario);
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
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtSelectEmployeeToEdit")!;
                MessageBox.Show(txtMessageBox);
            }
        }

        private void buttonExcluirCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroFuncionario.Text.Length <= 0)
            {
                string txtMessageBox = Properties.Resources.ResourceManager.GetString("txtDataSelectOneEmployee")!;
                MessageBox.Show(txtMessageBox);
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(textBoxIdCadastroFuncionario.Text),
            };
            try
            {
                string txtMessageBoxQuestion = Properties.Resources.ResourceManager.GetString("txtQuestionDeleteEmployee")!;
                string txtMessageBoxAttention = Properties.Resources.ResourceManager.GetString("txtAttention")!;
                DialogResult dialog = MessageBox.Show(txtMessageBoxQuestion, txtMessageBoxAttention, MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    // chama o método da model para excluir
                    funcionarioDAO.Excluir(funcionario);
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

        /// <summary>
        /// Limpa o formulário e atualiza os ingredientes na lista
        /// </summary>
        private void cleanFormAndUpdateList()
        {
            cleanForm();
            SearchFuncionario();
        }

        /// <summary>
        /// Limpa o formulário
        /// </summary>
        private void cleanForm()
        {
            this.Controls.ClearControls();
            comboBoxCidadeCadastroFuncionario.SelectedIndex = -1;
            comboBoxPaisCadastroFuncionario.SelectedIndex = -1;
            comboBoxUfCadastroFuncionario.SelectedIndex = -1;
        }
    }
}

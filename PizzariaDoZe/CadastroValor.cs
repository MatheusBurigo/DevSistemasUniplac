using PizzariaDoZe.utils;
using PizzariaDoZe.DAO;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de valor
    /// </summary>
    public partial class CadastroValor : Form
    {
        private ValorDAO valorDAO;

        /// <summary>
        /// Formulário de cadastro de valor inicialização
        /// </summary>
        public CadastroValor()
        {
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);

            fillGrid();
        }

        private void buttonFecharCadastroValor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanhoCadastroValor.Items.Clear();
            listBoxTamanhoCadastroValor.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoriaCadastroValor.Items.Clear();
            listBoxCategoriaCadastroValor.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void buttonSalvarCadastroValor_Click(object sender, EventArgs e)
        {
            //Remove o texto do valor
            string valorNumbers = maskedTextBoxValorCadastroValor.Text.Replace("R$", "");
            string valorBordaNumbers = maskedTextBoxValorBordaCadastroValor.Text.Replace("R$", "");
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanhoCadastroValor.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoriaCadastroValor.Text),
                ValorPizza = decimal.Parse(valorNumbers.Replace(".", ",")),
                ValorBorda = decimal.Parse(valorBordaNumbers.Replace(".", ",")),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
                cleanForms();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditarCadastroValor_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroValor.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um valor!");
                return;
            }
            //Remove o texto do valor
            string valorNumbers = maskedTextBoxValorCadastroValor.Text.Replace("R$", "");
            string valorBordaNumbers = maskedTextBoxValorBordaCadastroValor.Text.Replace("R$", "");

            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = int.Parse(textBoxIdCadastroValor.Text),
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanhoCadastroValor.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoriaCadastroValor.Text),
                ValorPizza = decimal.Parse(valorNumbers.Replace(".", ",")),
                ValorBorda = decimal.Parse(valorBordaNumbers.Replace(".", ",")),
            };
            try
            {
                // chama o método para editar da camada model
                valorDAO.Editar(valor);
                MessageBox.Show("Dados editados com sucesso!");
                cleanForms();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirCadastroValor_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroValor.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um valor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = int.Parse(textBoxIdCadastroValor.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Excluir(valor);
                MessageBox.Show("Dados excluídos com sucesso!");
                cleanForms();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaValores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.ListaValores.NewRowIndex || e.Value!.ToString()!.Trim().Length == 0)
            {
                return;
            }
            if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()!));
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Valor") || this.ListaValores.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString()!);

                e.Value = d.ToString("N2");
            }
        }

        private void buttonPesquisaCadastroValor_Click(object sender, EventArgs e)
        {
            try
            {
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = valorDAO.Buscar(valor);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCadastroValor.Text = row[0].ToString();
                    listBoxTamanhoCadastroValor.Text = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(row[1].ToString()!));
                    listBoxCategoriaCadastroValor.Text = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(row[2].ToString()!));
                    maskedTextBoxValorCadastroValor.Text = row[3].ToString();
                    maskedTextBoxValorBordaCadastroValor.Text = row[4].ToString();
                }
                maskedTextBoxValorCadastroValor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaValores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaValores.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = ListaValores.Rows[ListaValores.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void fillGrid()
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0
            };

            //chama o método para buscar todos os dados da nossa camada model
            DataTable linhas = valorDAO.Buscar(valor);

            // seta o datasouce do dataGridView com os dados retornados
            ListaValores.Columns.Clear();
            ListaValores.AutoGenerateColumns = true;
            ListaValores.DataSource = linhas;
            ListaValores.Refresh();
        }

        private void cleanForms()
        {
            textBoxIdCadastroValor.Text = "";
            maskedTextBoxValorCadastroValor.Text = "";
            maskedTextBoxValorBordaCadastroValor.Text = "";
        }
    }
}

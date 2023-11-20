using PizzariaDoZe.DAO;
using PizzariaDoZe.utils;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de produto
    /// </summary>
    public partial class CadastroProduto : Form
    {
        private ProdutoDAO produtoDAO;

        /// <summary>
        /// Formulário de cadastro de produto inicialização
        /// </summary>
        public CadastroProduto()
        {
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);
            CarregaEnumListBox();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);
        }

        private void buttonSalvarCadastroProduto_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = textBoxNomeCadastroProduto.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipoCadastroProduto.Text),
                ML = listBoxMlCadastroProduto.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
                cleanForms();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditarCadastroProduto_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroProduto.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = int.Parse(textBoxIdCadastroProduto.Text),
                Descricao = textBoxNomeCadastroProduto.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipoCadastroProduto.Text),
                ML = listBoxMlCadastroProduto.Text,
            };
            try
            {
                // chama o método para editar da camada model
                produtoDAO.Editar(produto);
                MessageBox.Show("Dados editados com sucesso!");
                cleanForms();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirCadastroProduto_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroProduto.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = int.Parse(textBoxIdCadastroProduto.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Excluir(produto);
                MessageBox.Show("Dados excluídos com sucesso!");
                cleanForms();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFecharCadastroProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaProdutos.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = ListaProdutos.Rows[ListaProdutos.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                atualizaTelaEditar(id);
            }
        }

        private void ListaProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.ListaProdutos.NewRowIndex || e.Value!.ToString()!.Trim().Length == 0)
            {
                return;
            }
            if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()!));
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Tipo Produto"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Valor") || this.ListaProdutos.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString()!);
                e.Value = d.ToString("N2");
            }
        }

        private void buttonPesquisaCadastroProduto_Click(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void atualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    // tipo AS 'Tipo Produto', medida_unitaria AS ML
                    textBoxIdCadastroProduto.Text = row[0].ToString();
                    textBoxNomeCadastroProduto.Text = row[1].ToString();
                    textBoxValor.Text = row[2].ToString();
                    listBoxTipoCadastroProduto.Text = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(row[3].ToString()!));
                    listBoxMlCadastroProduto.Text = row[4].ToString();
                }
                textBoxNomeCadastroProduto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillGrid()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = textBoxPesquisaCadastroProduto.Text
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
                // seta o datasouce do dataGridView com os dados retornados
                ListaProdutos.Columns.Clear();
                ListaProdutos.AutoGenerateColumns = true;
                ListaProdutos.DataSource = linhas;
                ListaProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleanForms()
        {
            textBoxIdCadastroProduto.Text = "";
            textBoxNomeCadastroProduto.Text = "";
            textBoxValor.Text = "";
            buttonPesquisaCadastroProduto.Text = "";
        }

        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipoCadastroProduto.Items.Clear();
            listBoxTipoCadastroProduto.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
    }
}

using PizzariaDoZe.utils;
using PizzariaDoZe.DAO;
using System.Configuration;
using System;
using System.Data;
using System.Resources;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de cadastro de sabor
    /// </summary>
    public partial class CadastroSabor : Form
    {
        private IngredienteDAO ingredienteDAO;
        private SaborDAO saborDAO;

        /// <summary>
        /// Formulário de cadastro de sabor inicialização
        /// </summary>
        public CadastroSabor()
        {
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            CarregaIngredientesCheckedListBox();
            CarregaEnumListBox();
            fillGrid();
        }

        private void buttonFecharCadastroSabor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //pega a imagem escolhida e adiciona na tela
                    pictureBoxFotoCadastroSabor.Image = Image.FromFile(dlg.FileName);
                    //redimensiona a imagem
                    pictureBoxFotoCadastroSabor.Image = (Image)(new Bitmap(pictureBoxFotoCadastroSabor.Image, new Size(242, 242)));
                }
            }
        }

        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente, true);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredienteCadastroSabor.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredienteCadastroSabor.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()!), row["Nome"].ToString()!));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            listBoxCategoriaCadastroSabor.Items.Clear();
            listBoxCategoriaCadastroSabor.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            listBoxTipoCadastroSabor.Items.Clear();
            listBoxTipoCadastroSabor.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void buttonSalvarCadastroSabor_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            Sabor sabor = CreateSabor();
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Inserir(sabor);
                MessageBox.Show("Dados inseridos com sucesso!");
                cleanForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Sabor CreateSabor()
        {
            return new Sabor
            {
                Id = textBoxIdCadastroSabor.Text != "" ? int.Parse(textBoxIdCadastroSabor.Text) : 0,
                Descricao = textBoxNomeCadastroSabor.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxFotoCadastroSabor.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoriaCadastroSabor.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipoCadastroSabor.Text),
                SaborIngredientes = checkedListBoxIngredienteCadastroSabor.CheckedItems.OfType<Ingrediente>().ToList(),
            };
        }

        private void ListaSabores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.ListaSabores.NewRowIndex || e.Value!.ToString()!.Trim().Length == 0)
            {
                return;
            }
            if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()!));
            }
            else if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()!));
            }
            else if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.ListaSabores.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString()!);
                e.Value = d.ToString("N2");
            }
        }

        private void buttonPesquisaCadastroSabor_Click(object sender, EventArgs e)
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

        private void fillGrid()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = 0,
                Descricao = textBoxPesquisaCadastroSabor.Text
            };
            //chama o método para buscar todos os dados da nossa camada model
            DataTable linhas = saborDAO.Buscar(sabor);
            // seta o datasouce do dataGridView com os dados retornados
            ListaSabores.Columns.Clear();
            ListaSabores.AutoGenerateColumns = true;
            ListaSabores.DataSource = linhas;
            ListaSabores.Refresh();
        }

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCadastroSabor.Text = row[0].ToString();
                    textBoxNomeCadastroSabor.Text = row[1].ToString();
                    pictureBoxFotoCadastroSabor.Image = Funcoes.ConverteByteArrayParaImagem((byte[])row[2]);
                    listBoxCategoriaCadastroSabor.Text = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(row[3].ToString()!));
                    listBoxTipoCadastroSabor.Text = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(row[4].ToString()!));
                    // busca e seleciona os itens do sabor
                    DataTable linhasIngredientes = saborDAO.BuscarItensSabor(sabor);
                    foreach (DataRow dr in linhasIngredientes.Rows)
                    {
                        for (int i = 0; i < checkedListBoxIngredienteCadastroSabor.Items.Count; i++)
                        {
                            if (dr[1].ToString() == ((Ingrediente)checkedListBoxIngredienteCadastroSabor.Items[i]).Nome.ToString())
                            {
                                checkedListBoxIngredienteCadastroSabor.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                textBoxNomeCadastroSabor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaSabores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaSabores.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = ListaSabores.Rows[ListaSabores.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void buttonEditarCadastroSabor_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroSabor.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um sabor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = int.Parse(textBoxIdCadastroSabor.Text),
                Descricao = textBoxNomeCadastroSabor.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxFotoCadastroSabor.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoriaCadastroSabor.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipoCadastroSabor.Text),
                SaborIngredientes = checkedListBoxIngredienteCadastroSabor.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Editar(sabor);
                MessageBox.Show("Dados editados com sucesso!");
                cleanForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirCadastroSabor_Click(object sender, EventArgs e)
        {
            if (textBoxIdCadastroSabor.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um sabor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = int.Parse(textBoxIdCadastroSabor.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Excluir(sabor);
                MessageBox.Show("Dados excluídos com sucesso!");
                cleanForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleanForms()
        {
            textBoxIdCadastroSabor.Text = "";
            textBoxNomeCadastroSabor.Text = "";
            pictureBoxFotoCadastroSabor.BackgroundImage = Properties.Resources.addImagem;
        }
    }
}

using System.ComponentModel;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace PizzariaDoZe.utils
{
    internal static class Funcoes
    {
        // Dicionario para limpar todos os controles da tela
        private static Dictionary<Type, Action<Control>> controldefaults = new() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(MaskedTextBox), c => ((MaskedTextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).Items.Clear()},
            {typeof(RichTextBox), c => ((RichTextBox)c).Clear()},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).ResetText() },
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
            {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
            {typeof(Panel), c => ((Panel)c).Controls.ClearControls()}
        };

        /// <summary>
        /// Busca pelo controle e invoca a ação caso o tipo seja o certo
        /// </summary>
        /// <param name="type">tipo permitido</param>
        /// <param name="control">controle a ser invocado</param>
        private static void FindAndInvoke(Type type, Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        /// <summary>
        /// Limpa os controles em loop
        /// </summary>
        /// <param name="controls">Lista de controles</param>
        public static void ClearControls(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                FindAndInvoke(control.GetType(), control);
            }
        }

        /// <summary>
        /// Limpa os controles em loop
        /// </summary>
        /// <typeparam name="T">Tipo especifico de controle a ser apagado</typeparam>
        /// <param name="controls">Lista de controles</param>
        public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (Control control in controls)
            {
                if (control.GetType().Equals(typeof(T)))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }

        }

        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado, executando o método ApplyResources em cada um dos componentes localizados.
        /// O ApplyResources realiza a leitura do satellite assembly, ou seja, do arquivo de resource que foi ativo conforme o idioma escolhido pelo usuário,
        /// e com base no nome do campo ajusta todos os parâmetros contidos no resource para aquele campo, por exemplo Text, Font, Size, PasswordChar, Location etc.
        /// O objetivo principal aqui é ajustar o Control, por exemplo o Form, para o Idioma e Cultura escolhido pelo usuário.
        /// Deve possuir, em Properties, um arquivo de resources para cada idioma desejado, devendo ser alimentado na coluna nome o nome do campo e a propriedade que deseja ajustar.
        /// Por exemplo, em cadeias de caracteres labelLogin.Text, em outros textBoxSenha.PasswordChar, ou seja, todas as propriedades podem ser ajustadas conforme o idioma e região em uso.
        /// </summary>
        /// <param name="container">Informar o container inicial, geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.</param>
        public static void AjustaResourcesControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesControl(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }

        /// <summary>
        /// Configura o combo box adicionando as tr~es linhas traduzidas
        /// </summary>
        /// <param name="combobox">Combobox de idioma selecionado para ser usado para tradução</param>
        public static void configComboBox(ComboBox combobox)
        {
            combobox.Items.Add("English");
            combobox.Items.Add("Português");
            combobox.Items.Add("Español");
            string? currentLanguage = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ?
            ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            if (currentLanguage == "en-US")
            {
                combobox.SelectedIndex = 0;
            }
            else if (currentLanguage == "pt-BR")
            {
                combobox.SelectedIndex = 1;
            }
            else
            {
                combobox.SelectedIndex = 2;
            }
        }

        /// <summary>
        /// Pega o texto do combo box e retorna a língua como o arquivo espera
        /// </summary>
        /// <param name="combobox">Combobox de idioma selecionado para ser usado para tradução</param>
        public static string TranslateComboBoxValue(ComboBox combobox)
        {
            if (combobox.Text == "English")
            {
                return "en-US";
            }
            else if (combobox.Text == "Português")
            {
                return "pt-BR";
            }
            else
            {
                return "es";
            }
        }

        /// <summary>
        /// De forma recursiva procura pelo pai do elemento até chegar no "pai de todos"
        /// </summary>
        /// <param name="c">Control selecionado para buscar o pai</param>
        public static Form getControlPath(this Control c)
        {

            if (c.Parent != null)
            {
                Control parent = c.Parent;

                if (parent != null)
                {
                    parent = parent.Parent!;
                    while (parent.Parent != null)
                    {
                        parent = parent.Parent;
                    }
                    return (Form)parent;
                } else
                {
                    return (Form)c;
                }
            } else
            {
                return (Form)c;
            }
        }

        /// <summary>
        /// Faz a troca de idioma no arquivo de configuração
        /// </summary>
        public static void AjustaIdiomaArquivoConfig(ComboBox comboBox)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", TranslateComboBoxValue(comboBox));
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Altera a cor do BackGroud quando o campo ganha o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Enter += new System.EventHandler(ClassFuncoes.CampoEventoEnter); </example>
        public static void CampoEventoEnter(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightCyan;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightCyan;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightCyan;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGreen;
            }
        }
        /// <summary>
        /// Alterar a cor do BackGroup quando o campo perde o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Leave += new System.EventHandler(ClassFuncoes.CampoEventoLeave); </example>
        public static void CampoEventoLeave(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// adicionando nos tipos informados os eventos Enter e Leave,
        /// e vinculando aos manipuladores criados.
        /// </summary>
        /// <param name="container">Informar o container inicial,
        /// geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.
        /// </param>
        public static void EventoFocoCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                EventoFocoCampos(c);
                switch (c)
                {
                    case TextBoxBase:
                    case ComboBox:
                    case RadioButton:
                    case CheckBox:
                        //case ButtonBase:
                        //adiciona eventos ganhar e perder o foco
                        c.Enter += new EventHandler(CampoEventoEnter!);
                        c.Leave += new EventHandler(CampoEventoLeave!);
                        break;

                }
            }
        }

        /// <summary>
        /// Checa qual a tecla pressionada
        /// caso seja o enter ele foca no próximo input
        /// caso seja o esc fecha o formulário em questão
        /// </summary>
        /// <param name="e">informações sobre a tecla,
        /// </param>
        /// <param name="form">formulário clicado </param>
        public static void KeyDown(KeyEventArgs e, Form form)
        {
            if (e.KeyData == Keys.Enter)
            {
                form.SelectNextControl(form.ActiveControl, true, true, true, true);
            }

            if (e.KeyData == Keys.Escape)
            {
                form.Close();
            }
        }

        /// <summary>
        /// Os itens de menu do nosso menu suspenso fazem parte de uma Collection, ou seja,
        /// não estão diretamente em uma camada de Control e sim internamente no menu de contexto.
        /// Desta forma precisamos percorrer seus itens para poder ajustar os parâmetros via resources
        /// </summary>
        /// <param name="cmt">Menu strip a ser percorrido</param>
        public static void AjustaResourcesItem(ContextMenuStrip cmt)
        {
            ComponentResourceManager resources = new(typeof(Properties.Resources));
            foreach (ToolStripItem c in cmt.Items)
            {
                resources.ApplyResources(c, c.Name);
            }
        }

        /// string hash = ClassFuncoes.Sha256Hash(textBoxSenha.Text);
        public static string Sha256Hash(string senha)
        {
            // Create a new Stringbuilder to collect the bytes and create a string.
            var hash = new StringBuilder();
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    hash.Append(data[i].ToString("x2"));
                }
            }
            // retorna o hash SHA256.
            return hash.ToString();
        }

        /// <summary>
        /// byte[] byteImg = ConverteImagemParaByteArray(pictureBox.Image);
        /// </summary>
        /// <param name="img">Imagem para converter</param>
        /// <returns>Returna a imagem convertida em um array de bytes</returns>
        public static byte[] ConverteImagemParaByteArray(Image img)
        {
            MemoryStream ms = new();
            if (img != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }

        //pictureBoxCompanyLogo.Image = ConverteByteArrayParaImagem((byte[]) byteimage);
        public static Image? ConverteByteArrayParaImagem(byte[] pData)
        {
            try
            {
                ImageConverter imgConverter = new();
                return imgConverter.ConvertFrom(pData) as Image;
            }
            catch
            {
                return null;
            }
        }
    }
}

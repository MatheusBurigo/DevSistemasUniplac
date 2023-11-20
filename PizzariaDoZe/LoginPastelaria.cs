using PizzariaDoZe.utils;

namespace PizzariaDoZe
{
    public partial class LoginPastelaria : Form
    {
        public LoginPastelaria()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.configComboBox(comboBoxIdiomaLogin);
            this.StartPosition = FormStartPosition.CenterScreen;
            Funcoes.EventoFocoCampos(this);
        }
        private string txtOpenApplicaton = Properties.Resources.ResourceManager.GetString("txtOpenApplication")!;
        private string txtAbout = Properties.Resources.ResourceManager.GetString("txtAbout")!;
        private string txtExit = Properties.Resources.ResourceManager.GetString("txtExit")!;
        private string txtMessage = Properties.Resources.ResourceManager.GetString("txtCloseProgramQuestion")!;
        private string txtContinue = Properties.Resources.ResourceManager.GetString("txtContinue")!;
        private string txtSendToTray = Properties.Resources.ResourceManager.GetString("txtSendToTray")!;
        private string txtAboutMessage = Properties.Resources.ResourceManager.GetString("txtAboutMessage")!;

        /// <summary>
        /// Fica escutando o click do botão do login e chama o próximo formulário
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Closed += (s, args) => this.Show();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;
            form.ShowDialog();
        }

        /// <summary>
        /// Fica escutando o combobox e troca o idioma quando disparado
        /// </summary>
        private void comboBoxIdiomaLogin_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Funcoes.AjustaIdiomaArquivoConfig(comboBoxIdiomaLogin);

                //atualiza a cultura corrente
                Program.AjustaIdiomaRegiao();
                Funcoes.AjustaResourcesControl(this);
                _ = MessageBox.Show("Idioma/região alterada com sucesso!");
            }
        }

        /// <summary>
        /// Fica escutando as teclas e chama a função keydown
        /// </summary>
        private void checkKeyDown(object sender, KeyEventArgs e)
        {
            Funcoes.KeyDown(e, this);
        }

        /// <summary>
        /// Fica escutando o form esperando ele fechar, e abre uma caixa de opções
        /// Caso o usuário escolha "Continuar" ele cancela a ação de fechar
        /// Caso o usuário escolha "fechar" o form é fechado
        /// Caso o usuário escolha "bandeja" o form é escondido e abre o system tray
        /// </summary>
        private void ClosingForm(object sender, FormClosingEventArgs e)
        {

            Form Dialog = new CustomMessageBox(txtExit, txtMessage, txtContinue, txtExit, txtSendToTray);
            Dialog.ShowDialog();
            int result = CustomMessageBox.result; // 1 = não fechar, 2 = Fechar, 3 = system tray
            if (result == 1)
            {
                e.Cancel = true;
            }
            else if (result == 3)
            {
                e.Cancel = true;
                OpenSystemTray();
            }
        }

        /// <summary>
        /// Fica escutando o duplo clique click, e abre o formulário e esconde o system tray
        /// </summary>
        private void TrayDoubleClick(object sender, MouseEventArgs e)
        {
            closeSystemTray();
        }

        /// <summary>
        /// Fica escutando o click, e abre o menu strip que mostram as opções no system tray caso o clique seja com o botão esquerdo do mouse
        /// </summary>
        private void TrayClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me != MouseEventArgs.Empty)
            {
                configureMenuStrip();
            }
        }

        /// <summary>
        /// Configura o menu strip que são as opções do system tray
        /// </summary>
        private void configureMenuStrip()
        {
            contextMenuStrip.Show(Convert(MousePosition));
            contextMenuStrip.Items[0].Text = txtOpenApplicaton;
            contextMenuStrip.Items[1].Text = txtAbout;
            contextMenuStrip.Items[2].Text = txtExit;
        }

        /// <summary>
        /// Converte um valor para um ponto
        /// </summary>
        public Point Convert(object value)
        {
            Point dp = (Point)value;
            return new Point(dp.X, dp.Y);
        }

        /// <summary>
        /// Fica escutando o click, e dispara o evento dependendo da opção clicada no menu strip
        /// </summary>
        private void MenuStripItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem!.Text;


            if (itemText == txtOpenApplicaton)
            {
                closeSystemTray();
            }
            else if (itemText == txtAbout)
            {
                OpenAboutProgram();
            }
            else
            {
                // Unsubscribing o metódo da classe
                this.FormClosing -= ClosingForm!;
                this.Close();
            }
        }

        /// <summary>
        /// Esconde o formulário e abre o system tray
        /// </summary>
        private void OpenSystemTray()
        {
            Hide();
            systemTray.Visible = true;
            systemTray.ShowBalloonTip(1000);
        }

        /// <summary>
        /// Fecha o system tray
        /// Caso a boleana seja falsa ele abre o formulário de novo
        /// Se não ele fecha o formulário
        /// </summary>
        /// <param name="closeForm">Variavel usada para definir se a função vai fechar ou não a aplicação</param>
        private void closeSystemTray(bool closeForm = false)
        {
            if (closeForm)
            {
                this.Close();
            }
            else
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                systemTray.Visible = false;
            }
        }

        /// <summary>
        /// Abre um modal que disponibiliza a versão do software
        /// </summary>
        private void OpenAboutProgram()
        {
            MessageBox.Show(txtAboutMessage);
        }

        private void maskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelCpf_Click(object sender, EventArgs e)
        {
        }

        private void labelSenha_Click(object sender, EventArgs e)
        {
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxIdiomaLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelIdioma_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}

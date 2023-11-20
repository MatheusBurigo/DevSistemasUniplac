using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PizzariaDoZe
{
    /// <summary>
    /// Message box customizavel
    /// </summary>
    public partial class CustomMessageBox : Form
    {
        /// <summary>
        /// Resultado do click dos botões
        /// 1 = Continue
        /// 2 = Sair
        /// 3 = Bandeja
        /// </summary>
        public static int result = 0;
        /// <summary>
        /// Message box customizavel inicialização
        /// </summary>
        public CustomMessageBox(string title, string message, string buttonContinueText, string buttonExitText, string buttonTrayText)
        {
            InitializeComponent();
            labelTitle.Text = title;
            labelText.Text = message;
            labelText.AutoSize = false;
            labelText.TextAlign = ContentAlignment.MiddleCenter;
            labelText.Left = 10;
            labelText.Width = this.Width - 10;
            buttonContinue.Text = buttonContinueText;
            buttonExit.Text = buttonExitText;
            buttonTray.Text = buttonTrayText;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            result = 2;
            this.Close();
        }

        private void buttonTray_Click(object sender, EventArgs e)
        {
            result = 3;
            this.Close();
        }
    }
}

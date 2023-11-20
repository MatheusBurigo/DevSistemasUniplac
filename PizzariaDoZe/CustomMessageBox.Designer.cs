namespace PizzariaDoZe
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelText = new Label();
            buttonContinue = new Button();
            buttonExit = new Button();
            buttonTray = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ImageAlign = ContentAlignment.MiddleRight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(582, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "labelTitle";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(249, 73);
            labelText.Name = "labelText";
            labelText.Size = new Size(65, 28);
            labelText.TabIndex = 1;
            labelText.Text = "label2";
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(111, 158);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(94, 29);
            buttonContinue.TabIndex = 2;
            buttonContinue.Text = "button1";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(238, 158);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "button2";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonTray
            // 
            buttonTray.Location = new Point(361, 158);
            buttonTray.Name = "buttonTray";
            buttonTray.Size = new Size(94, 29);
            buttonTray.TabIndex = 4;
            buttonTray.Text = "button3";
            buttonTray.UseVisualStyleBackColor = true;
            buttonTray.Click += buttonTray_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(buttonTray);
            Controls.Add(buttonExit);
            Controls.Add(buttonContinue);
            Controls.Add(labelText);
            Controls.Add(labelTitle);
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sair";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelText;
        private Button buttonContinue;
        private Button buttonExit;
        private Button buttonTray;
    }
}
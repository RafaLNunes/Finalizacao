namespace Finailzacao_2024_1_tri
{
    partial class FrmAbertura
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
            button1 = new Button();
            CBSenha = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(930, 652);
            button1.Name = "button1";
            button1.Size = new Size(178, 93);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CBSenha
            // 
            CBSenha.FormattingEnabled = true;
            CBSenha.Location = new Point(943, 559);
            CBSenha.Name = "CBSenha";
            CBSenha.Size = new Size(151, 28);
            CBSenha.TabIndex = 1;
            // 
            // FrmAbertura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1913, 963);
            Controls.Add(CBSenha);
            Controls.Add(button1);
            Name = "FrmAbertura";
            Text = "FrmAbertura";
            FormClosed += FrmAbertura_FormClosed;
            Load += FrmAbertura_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox CBSenha;
    }
}
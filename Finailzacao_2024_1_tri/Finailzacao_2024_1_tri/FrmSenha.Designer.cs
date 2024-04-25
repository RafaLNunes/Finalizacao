namespace Finailzacao_2024_1_tri
{
    partial class FrmSenha
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSenha));
            textUser = new TextBox();
            textPass = new TextBox();
            Logar = new Button();
            PBescolha = new PictureBox();
            VisibleList = new ImageList(components);
            PBvisivel = new PictureBox();
            PBinvisvel = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PBescolha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBvisivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBinvisvel).BeginInit();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.Location = new Point(905, 238);
            textUser.Name = "textUser";
            textUser.Size = new Size(125, 27);
            textUser.TabIndex = 0;
            // 
            // textPass
            // 
            textPass.Location = new Point(887, 316);
            textPass.Name = "textPass";
            textPass.PasswordChar = '•';
            textPass.Size = new Size(125, 27);
            textPass.TabIndex = 1;
            // 
            // Logar
            // 
            Logar.Location = new Point(1065, 520);
            Logar.Name = "Logar";
            Logar.Size = new Size(94, 29);
            Logar.TabIndex = 2;
            Logar.Text = "Enter";
            Logar.UseVisualStyleBackColor = true;
            Logar.Click += Logar_Click;
            // 
            // PBescolha
            // 
            PBescolha.Image = Properties.Resources.wired_lineal_69_eye__1_;
            PBescolha.Location = new Point(980, 506);
            PBescolha.Name = "PBescolha";
            PBescolha.Size = new Size(79, 62);
            PBescolha.SizeMode = PictureBoxSizeMode.Zoom;
            PBescolha.TabIndex = 3;
            PBescolha.TabStop = false;
            PBescolha.Click += pictureBox1_Click;
            // 
            // VisibleList
            // 
            VisibleList.ColorDepth = ColorDepth.Depth32Bit;
            VisibleList.ImageStream = (ImageListStreamer)resources.GetObject("VisibleList.ImageStream");
            VisibleList.TransparentColor = Color.Transparent;
            VisibleList.Images.SetKeyName(0, "wired-lineal-69-eye (1).gif");
            VisibleList.Images.SetKeyName(1, "wired-lineal-69-eye.gif");
            // 
            // PBvisivel
            // 
            PBvisivel.Image = Properties.Resources.wired_lineal_69_eye;
            PBvisivel.Location = new Point(-4, 0);
            PBvisivel.Name = "PBvisivel";
            PBvisivel.Size = new Size(79, 62);
            PBvisivel.SizeMode = PictureBoxSizeMode.Zoom;
            PBvisivel.TabIndex = 4;
            PBvisivel.TabStop = false;
            PBvisivel.Visible = false;
            // 
            // PBinvisvel
            // 
            PBinvisvel.Image = Properties.Resources.wired_lineal_69_eye__1_;
            PBinvisvel.Location = new Point(81, 0);
            PBinvisvel.Name = "PBinvisvel";
            PBinvisvel.Size = new Size(79, 62);
            PBinvisvel.SizeMode = PictureBoxSizeMode.Zoom;
            PBinvisvel.TabIndex = 6;
            PBinvisvel.TabStop = false;
            PBinvisvel.Visible = false;
            // 
            // FrmSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1913, 963);
            Controls.Add(PBinvisvel);
            Controls.Add(PBvisivel);
            Controls.Add(PBescolha);
            Controls.Add(Logar);
            Controls.Add(textPass);
            Controls.Add(textUser);
            Name = "FrmSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += FrmSenha_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PBescolha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBvisivel).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBinvisvel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUser;
        private TextBox textPass;
        private Button Logar;
        private PictureBox PBescolha;
        private ImageList VisibleList;
        private PictureBox PBvisivel;
        private PictureBox PBinvisvel;
    }
}

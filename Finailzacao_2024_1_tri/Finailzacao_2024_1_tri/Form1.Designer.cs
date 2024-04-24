namespace Finailzacao_2024_1_tri
{
    partial class Form1
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
            textUser = new TextBox();
            textPass = new TextBox();
            Logar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wired_lineal_69_eye;
            pictureBox1.Location = new Point(980, 506);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.wired_lineal_69_eye__1_;
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1913, 963);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Logar);
            Controls.Add(textPass);
            Controls.Add(textUser);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUser;
        private TextBox textPass;
        private Button Logar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

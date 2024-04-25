using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finailzacao_2024_1_tri
{
    public partial class FrmAbertura : Form
    {
        int referencia_senha = 0;
        public FrmAbertura()
        {
            InitializeComponent();
        }

        private void FrmAbertura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmAbertura_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 3; i++)
            { 
                CBSenha.Items.Add(i+"° Senha");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(CBSenha.Text)
            {
                case "1° Senha":
                    referencia_senha = 1;
                    break;
                case "2° Senha":
                    referencia_senha = 2;
                    break;
                case "3° Senha":
                    referencia_senha = 3;
                    break;
            }
            FrmSenha senha = new FrmSenha(referencia_senha);
            this.Hide();
            senha.ShowDialog();
        }
    }
}

namespace Finailzacao_2024_1_tri
{
    public partial class FrmSenha : Form
    {
        bool passwordchard;
        int indexsenha;
        String senhaReal = "";
        public FrmSenha(int referencia)
        {
            InitializeComponent();
            indexsenha = referencia;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (passwordchard)
            {
                passwordchard = false;
                textPass.PasswordChar = '•';
                PBescolha.Image = PBinvisvel.Image;
            }
            else
            {
                passwordchard = true;
                textPass.PasswordChar = '\0';
                PBescolha.Image = PBvisivel.Image;

            }


        }

        private void FrmSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logar_Click(object sender, EventArgs e)
        {
            switch(indexsenha)
            {
                case 1:
                    senhaReal = "" + "" + "" + "" + "";
                    break;
                case 2:
                    senhaReal = "" + "" + "" + "" + "";
                    break;
                case 3:
                    senhaReal = "" + "" + "" + "" + "";
                    break;
            }
        }
    }
}

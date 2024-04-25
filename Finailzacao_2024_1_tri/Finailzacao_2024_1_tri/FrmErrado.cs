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
    public partial class FrmErrado : Form
    {
        public FrmErrado()
        {
            InitializeComponent();
        }

        private void FrmErrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLoja
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            //verificando se o valou da progressbar é menor q 100
            if( prgSplash.Value < 100)
            {
                //se for menor, aumenta o valor em 10
                prgSplash.Value = prgSplash.Value + 4;
            }
            else
            {
                // iniciando timer
                tmrSplash.Enabled = false;
                // ocultando timer
                this.Visible = false;

                //instancia do form Login
                frmLogin login = new frmLogin();
                //mostrando a tela de login
                login.Show();
                //ocultando a tela de carregamento
                this.Hide();

            }
        }
    }
}

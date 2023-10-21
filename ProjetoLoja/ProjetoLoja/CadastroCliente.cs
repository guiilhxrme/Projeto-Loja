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
    public partial class frmCadCli : Form
    {
        public frmCadCli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciando a tela de menu
            frmMenu menu = new frmMenu();
            //mostrando a tela de menu
            menu.Show();
            //ocultando a tela de login
            this.Hide();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {

        }
    }
}

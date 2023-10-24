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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            //instancia da tela de cadastro de clientes
            frmCadCli CadastroCliente = new frmCadCli();

            //mostrando tela de cadastro de cliente
            CadastroCliente.Show();

            //ocultando tela menu
            this.Hide();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            //instancia da tela de cadastro de produtos
            frmCadProd CadastroProduto = new frmCadProd();

            //mostrando tela de cadastro de produtos
            CadastroProduto.Show();

            //ocultando tela menu
            this.Hide();
        }

        private void btnConsCli_Click(object sender, EventArgs e)
        {
            //instancai da tela de consulta de clientes
            frmConsCli ConsultaCliente = new frmConsCli();

            //mostrando a tela de consulta de clientes
            ConsultaCliente.Show();

            //ocultando tela de menu
            this.Hide();
        }

        private void btnConsProd_Click(object sender, EventArgs e)
        {
            //instancia da tela de consulta de produtos
            frmConsProd ConsultaProduto = new frmConsProd();

            //mostrando a tela de consulta de produtos
            ConsultaProduto.Show();

            //ocultando tela de menu
            this.Hide();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia da tela de cadastro de clientes
            frmCadCli CadastroCliente = new frmCadCli();

            //mostrando tela de cadastro de cliente
            CadastroCliente.Show();

            //ocultando tela menu
            this.Hide();
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia da tela de cadastro de produtos
            frmCadProd CadastroProduto = new frmCadProd();

            //mostrando tela de cadastro de produtos
            CadastroProduto.Show();

            //ocultando tela menu
            this.Hide();
        }

        private void cLIENTESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //instancai da tela de consulta de clientes
            frmConsCli ConsultaCliente = new frmConsCli();

            //mostrando a tela de consulta de clientes
            ConsultaCliente.Show();

            //ocultando tela de menu
            this.Hide();
        }

        private void pEDIDOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //instancia da tela de consulta de produtos
            frmConsProd ConsultaProduto = new frmConsProd();

            //mostrando a tela de consulta de produtos
            ConsultaProduto.Show();

            //ocultando tela de menu
            this.Hide();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

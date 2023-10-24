using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLoja
{
    public partial class frmCadProd : Form
    {
        //caminho que os dados serão salvos
        string path = @"C:\Users\Guilherme\Documents\ETEC\PROJETOCITY\paths\produtos.txt";
        public frmCadProd()
        {
            InitializeComponent();
        }

        private void frmCadProd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEnd_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblObs_Click(object sender, EventArgs e)
        {

        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            //verifica se todos os dados foram inseridos
            if (txtNomeProd.Text == ""
                && txtDesc.Text == ""
                && txtQtd.Text == ""
                && txtVal.Text == "")
            {
                //mensagem de erro caso os dados nao forem inseridos corretamente
                MessageBox.Show("Preencha todos os dados necessários");
            }
            else
            {
                // instancia do codigo que escreve no arquivo onde os dados serao salvos
                StreamWriter sw = new StreamWriter(path, true);

                //codigos para salvar os dados no arquivo
                sw.WriteLine("Nome do Produto: " + txtNomeProd.Text);
                sw.WriteLine("Descrição: " + txtDesc.Text);
                sw.WriteLine("Quantidade: " + txtQtd.Text);
                sw.WriteLine("Valor: " + txtVal.Text);
                sw.WriteLine("OBS: " + txtObsProd.Text);
                sw.WriteLine("================================================");

                //caixa de mensagem de cadastro concluído
                MessageBox.Show("Cadastro de produto concluído!");

                //fechando o arquivo e salvando
                sw.Close();

                // limpando os campos para inserção de novos dados
                txtNomeProd.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                txtVal.Clear();
                txtObsProd.Clear();

            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //instanciando a tela de menu
            frmMenu menu = new frmMenu();
            //mostrando a tela de menu
            menu.Show();
            //ocultando a tela de login
            this.Hide();
        }
    }
}

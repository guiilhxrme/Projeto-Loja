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
    public partial class frmCadCli : Form
    {
        //caminho que os dados serão salvos
        string path = @"C:\Users\Guilherme\Documents\ETEC\PROJETOCITY\paths\clientes.txt";

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
            //verifica se todos os dados foram inseridos
            if (txtNome.Text == ""
                && txtEmail.Text == ""
                && mskTel.Text == ""
                && txtEnd.Text == "")
            {
                //mensagem de erro caso os dados nao forem inseridos corretamente
                MessageBox.Show("Preencha todos os dados necessários");
            } else
            {
                // instancia do codigo que escreve no arquivo onde os dados serao salvos
                StreamWriter sw = new StreamWriter(path, true);

                //codigos para salvar os dados no arquivo
                sw.WriteLine("Nome: " + txtNome.Text);
                sw.WriteLine("Email: " + txtEmail.Text);
                sw.WriteLine("Telefone: " + mskTel.Text);
                sw.WriteLine("Endereço: " + txtEnd.Text);
                sw.WriteLine("Obs: " + txtObs.Text);
                sw.WriteLine("================");

                //caixa de mensagem de cadastro concluído
                MessageBox.Show("Cadastro concluído!");

                //fechando o arquivo e salvando
                sw.Close();

                // limpando os campos para inserção de novos dados
                txtNome.Clear();
                txtEmail.Clear();
                mskTel.Clear();
                txtEnd.Clear();
                txtObs.Clear();
            }
        }

        private void frmCadCli_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

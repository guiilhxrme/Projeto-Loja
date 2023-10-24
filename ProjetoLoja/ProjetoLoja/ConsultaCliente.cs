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
    public partial class frmConsCli : Form
    {
        //caminho que os dados estão salvos
        string path = @"C:\Users\Guilherme\Documents\ETEC\PROJETOCITY\paths\clientes.txt";
        public frmConsCli()
        {
            InitializeComponent();
        }

        private void frmConsCli_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnConsCliente_Click(object sender, EventArgs e)
        {
            //instancia da lista de string
            List<string> lista = new List<string>();

            //declarando uma string vazia
            //na qual os dados serão inseridos
            string dado;

            //usando e instanciando o leitor de caminho aonde os dados estão salvos
            using (StreamReader sr = new StreamReader(path))
            {
                //enqunato a variavel dado for nula
                while ((dado = sr.ReadLine()) != null)
                {
                    //adicionando os dados à lista de string
                    lista.Add(dado);
                }

                //atribuindo os dados da lista à lista de cliente
                lsbCliente.DataSource = lista;
            }
        }
    }
}

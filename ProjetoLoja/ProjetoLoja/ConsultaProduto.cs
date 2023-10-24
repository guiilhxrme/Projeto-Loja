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
    public partial class frmConsProd : Form
    {
        //caminho que os dados serão salvos
        string path = @"C:\Users\Guilherme\Documents\ETEC\PROJETOCITY\paths\produtos.txt";
        public frmConsProd()
        {
            InitializeComponent();
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

        private void btnConsProduto_Click(object sender, EventArgs e)
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

                //atribuindo os dados da lista à lista de produto
                lsbProduto.DataSource = lista;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace ProjetoLoja
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //verificar se usuario e senha estao corretos para entrar no sistema
            if ( txtUser.Text == "BGAdmin" &&  txtPassword.Text == "Senha123")
            {
                //instanciando a tela de menu
                frmMenu menu = new frmMenu();
                //mostrando a tela de menu
                menu.Show();
                //ocultando a tela de login
                this.Hide();

            } else
            {
                //mensagem de texto falando q usuario e senha estao incorretos
                MessageBox.Show("Usuário e senha incorreto");
            }
        }
    }
}

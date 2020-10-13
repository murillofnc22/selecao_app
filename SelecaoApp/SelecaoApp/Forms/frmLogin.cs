using System;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LogaNoSistema();
        }

        private void LogaNoSistema()
        {
            HandleLogin login = new HandleLogin(txtUsuario.Text, txtSenha.Text);
            if (login.FazLogin())
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal(txtUsuario.Text);
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
            }            
        }
    }
}

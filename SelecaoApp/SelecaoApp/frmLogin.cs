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
            Login login = new Login(txtUsuario.Text, txtSenha.Text);
            if (login.HandleLogin())
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
            }
            this.Close();
        }
    }
}

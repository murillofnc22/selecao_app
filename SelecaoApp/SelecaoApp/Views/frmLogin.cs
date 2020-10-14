using SelecaoApp.Domain.Models.LoginModels;
using SelecaoApp.Services.Services.FornecedoresServices;
using SelecaoApp.Services.Services.LoginServices;
using SelecaoApp.Services.Services.ProdutosServices;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SelecaoApp
{
    public partial class frmLogin : Form
    {
        private ILoginRepository _loginRepository;
        private IFornecedoresRepository _fornecedoresRepository;
        private IProdutosRepository _produtosRepository;
        public frmLogin(ILoginRepository loginRepository, IFornecedoresRepository fornecedoresRepository, IProdutosRepository produtosRepository)
        {
            InitializeComponent();
            _loginRepository = loginRepository;
            _fornecedoresRepository = fornecedoresRepository;
            _produtosRepository = produtosRepository;
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
            if (FazLogin())
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal(txtUsuario.Text, _produtosRepository, _fornecedoresRepository);
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
            }            
        }
        public bool FazLogin()
        {
            VerificaUsuarios();
            if (LoginValido())
                return true;
            else
                return false;
        }

        private bool LoginValido()
        {
            var login = _loginRepository.FindLogin(txtUsuario.Text);
            if (login != null)
                return login.usuario == txtUsuario.Text && login.usrpass == MD5Hash(txtUsuario.Text.ToLower() + txtSenha.Text);
            else
                return false;
        }

        private void VerificaUsuarios()
        {
            if (_loginRepository.GetAll().Count() == 0)
                InsereLoginPadrao();
        }

        private void InsereLoginPadrao()
        {
            Login login = new Login();
            login.usuario = "Admin";
            login.usrpass = MD5Hash(login.usuario.ToLower() + "admin");
            _loginRepository.Add(login);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            byte[] bytes = MD5.Create().ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}

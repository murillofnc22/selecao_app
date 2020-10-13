using SelecaoApp.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SelecaoApp
{
    public class HandleLogin
    {
        private string Usuario { get; set; }
        private string Senha { get; set; }
        private RepositoryLogin db = new RepositoryLogin();

        public HandleLogin(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
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
            var login = db.FindLogin(Usuario);
            if (login != null)
                return login.usuario == Usuario && login.usrpass == MD5Hash(Usuario.ToLower() + Senha);
            else
                return false;
        }

        private void VerificaUsuarios()
        {
            if (db.List().Count == 0)
                InsereLoginPadrao();
        }

        private void InsereLoginPadrao()
        {
            Login login = new Login();
            login.usuario = "Administrador";
            login.usrpass = MD5Hash(login.usuario.ToLower()+"admin");
            db.Add(login);
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

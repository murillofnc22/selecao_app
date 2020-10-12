using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecaoApp
{
    public class Login
    {
        private string Usuario { get; set; }
        private string Senha { get; set; }

        public Login(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public bool HandleLogin()
        {
            return true;
        }
    }
}

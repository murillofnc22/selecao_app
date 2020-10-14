using SelecaoApp.Domain.Models.LoginModels;
using SelecaoApp.Services.Services.LoginServices;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SelecaoApp
{
    public class HandleLogin
    {
        private string Usuario { get; set; }
        private string Senha { get; set; }
        ILoginRepository db;

        public HandleLogin(string usuario, string senha, ILoginRepository loginRepository)
        {
            Usuario = usuario;
            Senha = senha;
            db = loginRepository;
        }

        
    }
}

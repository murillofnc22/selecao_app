using SelecaoApp.Domain.Models.Login;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic;
using System.Linq;

namespace SelecaoApp.Infra.DataAccess.Repositories.Specific.Login
{
    public class LoginRepository : GenericRepository<LoginModel>
    {
        public LoginModel FindLogin(string usuario)
        {
            using (DBEntities data = new DBEntities())
            {
                return data.Set<LoginModel>().AsNoTracking().Where(w => w.usuario == usuario).FirstOrDefault();
            }
        }
    }
}

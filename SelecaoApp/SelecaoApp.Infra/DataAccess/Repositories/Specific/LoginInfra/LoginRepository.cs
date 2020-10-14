using Microsoft.EntityFrameworkCore;
using SelecaoApp.Domain.Models.LoginModels;
using SelecaoApp.Infra.Configuration;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic;
using SelecaoApp.Services.Services.LoginServices;
using System.Linq;

namespace SelecaoApp.Infra.DataAccess.Repositories.Specific.LoginInfra
{
    public class LoginRepository : GenericRepository<Domain.Models.LoginModels.Login>, ILoginRepository
    {
        public Domain.Models.LoginModels.Login FindLogin(string usuario)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                return data.Set<Domain.Models.LoginModels.Login>().AsNoTracking().Where(w => w.usuario == usuario).FirstOrDefault();
            }
        }
    }
}

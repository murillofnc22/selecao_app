using SelecaoApp.Domain.Interfaces.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace SelecaoApp.Infra.Repository
{
    public class RepositoryLogin : RepositoryGeneric<Login>, IGeneric<Login>
    {
        public Login FindLogin(string usuario)
        {
            using (DBEntities data = new DBEntities())
            {
                return data.Set<Login>().AsNoTracking().Where(w => w.usuario == usuario).FirstOrDefault();
            }
        }
    }
}

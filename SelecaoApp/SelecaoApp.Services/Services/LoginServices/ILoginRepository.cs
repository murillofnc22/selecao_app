using SelecaoApp.Services.Services.Generic;
using SelecaoApp.Domain.Models.LoginModels;

namespace SelecaoApp.Services.Services.LoginServices
{
    public interface ILoginRepository : IGenericRepository<Login>
    {
        Login FindLogin(string usuario);
    }
}

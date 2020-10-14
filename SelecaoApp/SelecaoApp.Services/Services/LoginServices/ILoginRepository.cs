using SelecaoApp.Services.Services.Generic;
using SelecaoApp.Domain.Models.Login;

namespace SelecaoApp.Services.Services.LoginServices
{
    public interface ILoginRepository : IGenericRepository<LoginModel>
    {
    }
}

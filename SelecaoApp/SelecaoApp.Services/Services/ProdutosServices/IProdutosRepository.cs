using SelecaoApp.Domain.Models.ProdutosModels;
using SelecaoApp.Services.Services.Generic;
using System.Data;

namespace SelecaoApp.Services.Services.ProdutosServices
{
    public interface IProdutosRepository : IGenericRepository<Produtos>
    {
        DataTable BuscaProdutosADO(string busca);
        DataTable GetAllProdutosADO();
    }
}

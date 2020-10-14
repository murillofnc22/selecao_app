using SelecaoApp.Domain.Models.FornecedoresModels;
using SelecaoApp.Services.Services.Generic;
using System.Data;

namespace SelecaoApp.Services.Services.FornecedoresServices
{
    public interface IFornecedoresRepository : IGenericRepository<Fornecedores>
    {
        DataTable BuscaFornecedoresADO(string busca);
        DataTable GetAllFornecedoresADO();
        string GetNomeFornecedorById(int id);
        int GetIdFornecedorByName(string nome);
    }
}

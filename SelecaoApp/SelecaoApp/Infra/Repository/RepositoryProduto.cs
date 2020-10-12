using SelecaoApp.Domain.Interfaces;

namespace SelecaoApp.Infra.Repository
{
    public class RepositoryProduto : RepositoryGeneric<Entities.Produtos>, IProduto
    {
    }
}

namespace SelecaoApp.Domain.Models.ProdutosModels
{
    public interface IProdutos
    {
        int id { get; set; }
        int idFornecedor { get; set; }
        string nome { get; set; }
        int quantidade { get; set; }
    }
}
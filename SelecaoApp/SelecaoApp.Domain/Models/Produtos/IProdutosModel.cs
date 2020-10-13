namespace SelecaoApp.Domain.Models.Produtos
{
    public interface IProdutosModel
    {
        int id { get; set; }
        int idFornecedor { get; set; }
        string nome { get; set; }
        int quantidade { get; set; }
    }
}
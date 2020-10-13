namespace SelecaoApp.Domain.Models.Fornecedores
{
    public interface IFornecedoresModel
    {
        bool ativo { get; set; }
        string cnpj { get; set; }
        int id { get; set; }
        string nome { get; set; }
    }
}
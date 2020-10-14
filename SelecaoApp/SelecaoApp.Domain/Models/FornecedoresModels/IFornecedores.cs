namespace SelecaoApp.Domain.Models.FornecedoresModels
{
    public interface IFornecedores
    {
        bool ativo { get; set; }
        string cnpj { get; set; }
        int id { get; set; }
        string nome { get; set; }
    }
}
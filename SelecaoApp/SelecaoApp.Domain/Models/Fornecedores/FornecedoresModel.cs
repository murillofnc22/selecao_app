namespace SelecaoApp.Domain.Models.Fornecedores
{
    public class FornecedoresModel : IFornecedoresModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public bool ativo { get; set; }
    }
}

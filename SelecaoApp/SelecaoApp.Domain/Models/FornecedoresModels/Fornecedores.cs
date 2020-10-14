namespace SelecaoApp.Domain.Models.FornecedoresModels
{
    public class Fornecedores : IFornecedores
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public bool ativo { get; set; }
    }
}

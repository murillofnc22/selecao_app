namespace SelecaoApp.Entities
{
    public class Fornecedores : Base
    {
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
    }
}

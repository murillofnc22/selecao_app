using System;
using System.ComponentModel.DataAnnotations;

namespace SelecaoApp.Domain.Models.Produtos
{
    public class ProdutosModel : IProdutosModel
    {
        public int id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome do produto deve ser informado!")]
        public string nome { get; set; }
        public int idFornecedor { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "A quantidade deve ser maior que 0!")]
        public int quantidade { get; set; }
    }
}

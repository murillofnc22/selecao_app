//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelecaoApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fornecedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedores()
        {
            this.Produtos = new HashSet<Produtos>();
        }
    
        public long id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public bool ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produtos> Produtos { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaPetshop_2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAXAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAXAS()
        {
            this.PAGAMENTOS = new HashSet<PAGAMENTOS>();
        }
    
        public int ID_TAXAS { get; set; }
        public string DESCRICAOTX { get; set; }
        public decimal TAXACREDITO1 { get; set; }
        public decimal TAXACREDITO2 { get; set; }
        public decimal TAXACREDITO3 { get; set; }
        public decimal TAXACREDITO4 { get; set; }
        public decimal TAXACREDITO5 { get; set; }
        public decimal TAXACREDITO6 { get; set; }
        public decimal TAXACREDITO7 { get; set; }
        public decimal TAXACREDITO10 { get; set; }
        public decimal TAXADEBITO { get; set; }
        public decimal TAXABOLETO { get; set; }
        public bool P_DIV { get; set; }
        public bool ATIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGAMENTOS> PAGAMENTOS { get; set; }
    }
}
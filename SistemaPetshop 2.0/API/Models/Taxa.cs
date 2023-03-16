using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("TAXAS")]
    public partial class Taxa
    {
        public Taxa()
        {
            Pagamentos = new HashSet<Pagamento>();
        }

        [Key]
        [Column("ID_TAXAS")]
        public int IdTaxas { get; set; }
        [Required]
        [Column("DESCRICAOTX")]
        public string Descricaotx { get; set; }
        [Column("TAXACREDITO1", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito1 { get; set; }
        [Column("TAXACREDITO2", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito2 { get; set; }
        [Column("TAXACREDITO3", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito3 { get; set; }
        [Column("TAXACREDITO4", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito4 { get; set; }
        [Column("TAXACREDITO5", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito5 { get; set; }
        [Column("TAXACREDITO6", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito6 { get; set; }
        [Column("TAXACREDITO7", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito7 { get; set; }
        [Column("TAXACREDITO10", TypeName = "decimal(18, 2)")]
        public decimal Taxacredito10 { get; set; }
        [Column("TAXADEBITO", TypeName = "decimal(18, 2)")]
        public decimal Taxadebito { get; set; }
        [Column("TAXABOLETO", TypeName = "decimal(18, 2)")]
        public decimal Taxaboleto { get; set; }
        [Column("P_DIV")]
        public bool PDiv { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [InverseProperty(nameof(Pagamento.IdTaxasNavigation))]
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("PAGAMENTOS")]
    [Index(nameof(IdTaxas), Name = "IX_FK_TAXASPAGAMENTOS")]
    public partial class Pagamento
    {
        public Pagamento()
        {
            PagamentosAtendimentos = new HashSet<PagamentosAtendimento>();
            PagamentosInternacaos = new HashSet<PagamentosInternacao>();
        }

        [Key]
        [Column("ID_PAGAMENTOS")]
        public int IdPagamentos { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(20)]
        public string Nome { get; set; }
        [Column("TIPO_PAG")]
        public int? TipoPag { get; set; }
        [Column("ID_TAXAS")]
        public int IdTaxas { get; set; }
        [Column("Gera_Fin")]
        public bool GeraFin { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [ForeignKey(nameof(IdTaxas))]
        [InverseProperty(nameof(Taxa.Pagamentos))]
        public virtual Taxa IdTaxasNavigation { get; set; }
        [InverseProperty(nameof(PagamentosAtendimento.IdPagamentoNavigation))]
        public virtual ICollection<PagamentosAtendimento> PagamentosAtendimentos { get; set; }
        [InverseProperty(nameof(PagamentosInternacao.IdPagamentoNavigation))]
        public virtual ICollection<PagamentosInternacao> PagamentosInternacaos { get; set; }
    }
}

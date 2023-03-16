using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("TOTAL_INTERNACAO_CIRURGIA")]
    [Index(nameof(IdCirurgia), Name = "IX_FK_CIRURGIATOTAL_INTERNACAO_CIRURGIA", IsUnique = true)]
    [Index(nameof(IdInternacao), Name = "IX_FK_INTERNACAOTOTAL_INTERNACAO")]
    public partial class TotalInternacaoCirurgium
    {
        public TotalInternacaoCirurgium()
        {
            PagamentosInternacaos = new HashSet<PagamentosInternacao>();
        }

        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_INTERNACAO")]
        public int? IdInternacao { get; set; }
        [Column("ID_CIRURGIA")]
        public int? IdCirurgia { get; set; }
        [Column("SUBTOTAL", TypeName = "decimal(18, 2)")]
        public decimal Subtotal { get; set; }
        [Column("DESCONTO", TypeName = "decimal(18, 2)")]
        public decimal Desconto { get; set; }
        [Column("ACRESCIMO", TypeName = "decimal(18, 2)")]
        public decimal Acrescimo { get; set; }
        [Column("TOTAL", TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
        [Column("DATA_FINALIZACAO", TypeName = "datetime")]
        public DateTime DataFinalizacao { get; set; }

        [ForeignKey(nameof(IdCirurgia))]
        [InverseProperty(nameof(Cirurgium.TotalInternacaoCirurgium))]
        public virtual Cirurgium IdCirurgiaNavigation { get; set; }
        [ForeignKey(nameof(IdInternacao))]
        [InverseProperty(nameof(Internacao.TotalInternacaoCirurgia))]
        public virtual Internacao IdInternacaoNavigation { get; set; }
        [InverseProperty(nameof(PagamentosInternacao.IdTipoAtendimentoNavigation))]
        public virtual ICollection<PagamentosInternacao> PagamentosInternacaos { get; set; }
    }
}

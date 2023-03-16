using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("TOTAL_ATENDIMENTO")]
    [Index(nameof(IdAtendimento), Name = "IX_FK_ATENDIMENTO_VETTOTAL_ATENDIMENTO")]
    public partial class TotalAtendimento
    {
        public TotalAtendimento()
        {
            PagamentosAtendimentos = new HashSet<PagamentosAtendimento>();
        }

        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_ATENDIMENTO")]
        public int IdAtendimento { get; set; }
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

        [ForeignKey(nameof(IdAtendimento))]
        [InverseProperty(nameof(AtendimentoVet.TotalAtendimentos))]
        public virtual AtendimentoVet IdAtendimentoNavigation { get; set; }
        [InverseProperty(nameof(PagamentosAtendimento.IdTipoAtendimentoNavigation))]
        public virtual ICollection<PagamentosAtendimento> PagamentosAtendimentos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("PAGAMENTOS_INTERNACAO")]
    [Index(nameof(IdPagamento), Name = "IX_FK_PAGAMENTOSPAGAMENTOS_INTERNACAO")]
    [Index(nameof(IdTipoAtendimento), Name = "IX_FK_TOTAL_ATENDIMENTOPAGAMENTOS_ATENDIMENTO1")]
    public partial class PagamentosInternacao
    {
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_PAGAMENTO")]
        public int IdPagamento { get; set; }
        [Required]
        [Column("NOME_PAGAMENTO")]
        public string NomePagamento { get; set; }
        [Column("VALOR_PAGAMENTO", TypeName = "decimal(18, 2)")]
        public decimal ValorPagamento { get; set; }
        [Column("ID_TIPO_ATENDIMENTO")]
        public int IdTipoAtendimento { get; set; }
        [Column("DIVIDO_VEZES")]
        public int? DividoVezes { get; set; }
        [Column("DATA_FECHAMENTO", TypeName = "datetime")]
        public DateTime DataFechamento { get; set; }

        [ForeignKey(nameof(IdPagamento))]
        [InverseProperty(nameof(Pagamento.PagamentosInternacaos))]
        public virtual Pagamento IdPagamentoNavigation { get; set; }
        [ForeignKey(nameof(IdTipoAtendimento))]
        [InverseProperty(nameof(TotalInternacaoCirurgium.PagamentosInternacaos))]
        public virtual TotalInternacaoCirurgium IdTipoAtendimentoNavigation { get; set; }
    }
}

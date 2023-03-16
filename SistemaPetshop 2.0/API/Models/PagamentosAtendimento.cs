using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("PAGAMENTOS_ATENDIMENTOS")]
    [Index(nameof(IdPagamento), Name = "IX_FK_PAGAMENTOSPAGAMENTOS_ATENDIMENTO")]
    [Index(nameof(IdTipoAtendimento), Name = "IX_FK_TOTAL_ATENDIMENTOPAGAMENTOS_ATENDIMENTO")]
    public partial class PagamentosAtendimento
    {
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_PAGAMENTO")]
        public int IdPagamento { get; set; }
        [Required]
        [Column("NOME_PAGAMENTO")]
        public string NomePagamento { get; set; }
        [Column("VALOR_PAGAMENTO", TypeName = "decimal(18, 0)")]
        public decimal ValorPagamento { get; set; }
        [Column("ID_TIPO_ATENDIMENTO")]
        public int IdTipoAtendimento { get; set; }
        [Column("DIVIDO_VEZES")]
        public int? DividoVezes { get; set; }
        [Column("DATA_FECHAMENTO", TypeName = "datetime")]
        public DateTime DataFechamento { get; set; }

        [ForeignKey(nameof(IdPagamento))]
        [InverseProperty(nameof(Pagamento.PagamentosAtendimentos))]
        public virtual Pagamento IdPagamentoNavigation { get; set; }
        [ForeignKey(nameof(IdTipoAtendimento))]
        [InverseProperty(nameof(TotalAtendimento.PagamentosAtendimentos))]
        public virtual TotalAtendimento IdTipoAtendimentoNavigation { get; set; }
    }
}

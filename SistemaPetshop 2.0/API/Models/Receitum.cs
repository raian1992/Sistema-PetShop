using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("RECEITA")]
    [Index(nameof(IdAtendimento), Name = "IX_FK_ATENDIMENTO_VETRECEITA")]
    [Index(nameof(IdInternacao), Name = "IX_FK_INTERNACAORECEITA")]
    [Index(nameof(IdCirurgia), Name = "IX_FK_RECEITACIRURGIA")]
    public partial class Receitum
    {
        [Key]
        [Column("ID_RECEITA")]
        public int IdReceita { get; set; }
        [Column("ID_ATENDIMENTO")]
        public int? IdAtendimento { get; set; }
        [Column("ID_INTERNACAO")]
        public int? IdInternacao { get; set; }
        [Column("ID_CIRURGIA")]
        public int? IdCirurgia { get; set; }
        [Required]
        [Column("DESCRICAO_RECEITA")]
        public string DescricaoReceita { get; set; }
        [Required]
        [Column("DADOS_RECEITA")]
        public string DadosReceita { get; set; }
        [Column("DATA_RECEITA", TypeName = "datetime")]
        public DateTime DataReceita { get; set; }
        [Column("ATIVA")]
        public bool Ativa { get; set; }

        [ForeignKey(nameof(IdAtendimento))]
        [InverseProperty(nameof(AtendimentoVet.Receita))]
        public virtual AtendimentoVet IdAtendimentoNavigation { get; set; }
        [ForeignKey(nameof(IdCirurgia))]
        [InverseProperty(nameof(Cirurgium.Receita))]
        public virtual Cirurgium IdCirurgiaNavigation { get; set; }
        [ForeignKey(nameof(IdInternacao))]
        [InverseProperty(nameof(Internacao.Receita))]
        public virtual Internacao IdInternacaoNavigation { get; set; }
    }
}

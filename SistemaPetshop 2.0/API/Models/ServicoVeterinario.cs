using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("SERVICO_VETERINARIO")]
    [Index(nameof(IdAtendimento), Name = "IX_FK_ATENDIMENTO_VETSERVICO_VETERINARIO")]
    [Index(nameof(IdInternacao), Name = "IX_FK_INTERNACAOSERVICO_VETERINARIO")]
    [Index(nameof(IdServico), Name = "IX_FK_SERVICOSERVICO_VETERINARIO")]
    [Index(nameof(IdVet), Name = "IX_FK_VeterinariosSERVICO_VETERINARIO")]
    public partial class ServicoVeterinario
    {
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_SERVICO")]
        public int IdServico { get; set; }
        [Required]
        [Column("NOME_SERVICO")]
        public string NomeServico { get; set; }
        [Column("VALOR_SERVICO", TypeName = "decimal(18, 2)")]
        public decimal ValorServico { get; set; }
        [Column("ID_ATENDIMENTO")]
        public int? IdAtendimento { get; set; }
        [Column("ID_INTERNACAO")]
        public int? IdInternacao { get; set; }
        [Column("ID_VET")]
        public int IdVet { get; set; }
        [Column("DATA_EXECUCAO", TypeName = "datetime")]
        public DateTime DataExecucao { get; set; }

        [ForeignKey(nameof(IdAtendimento))]
        [InverseProperty(nameof(AtendimentoVet.ServicoVeterinarios))]
        public virtual AtendimentoVet IdAtendimentoNavigation { get; set; }
        [ForeignKey(nameof(IdInternacao))]
        [InverseProperty(nameof(Internacao.ServicoVeterinarios))]
        public virtual Internacao IdInternacaoNavigation { get; set; }
        [ForeignKey(nameof(IdServico))]
        [InverseProperty(nameof(Servico.ServicoVeterinarios))]
        public virtual Servico IdServicoNavigation { get; set; }
        [ForeignKey(nameof(IdVet))]
        [InverseProperty(nameof(Veterinario.ServicoVeterinarios))]
        public virtual Veterinario IdVetNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("ATENDIMENTO_VET")]
    [Index(nameof(IdCirurgia), Name = "IX_FK_CIRURGIAATENDIMENTO_VET")]
    [Index(nameof(IdCliente), Name = "IX_FK_ClienteATENDIMENTO_VET")]
    [Index(nameof(IdEmpresa), Name = "IX_FK_EMPRESAATENDIMENTO_VET")]
    [Index(nameof(IdPet), Name = "IX_FK_PETATENDIMENTO_VET")]
    [Index(nameof(IdVet), Name = "IX_FK_VeterinariosATENDIMENTO_VET")]
    public partial class AtendimentoVet
    {
        public AtendimentoVet()
        {
            Internacaos = new HashSet<Internacao>();
            Receita = new HashSet<Receitum>();
            ServicoVeterinarios = new HashSet<ServicoVeterinario>();
            TotalAtendimentos = new HashSet<TotalAtendimento>();
        }

        [Key]
        [Column("ID_ATENDIMENTO")]
        public int IdAtendimento { get; set; }
        [Column("ID_VET")]
        public int IdVet { get; set; }
        [Column("ID_PET")]
        public int IdPet { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("SINTOMAS")]
        public string Sintomas { get; set; }
        [Column("REQUISICAO_EXAMES")]
        public string RequisicaoExames { get; set; }
        [Column("PESO_PET")]
        public double PesoPet { get; set; }
        [Column("ID_INTERNACAO")]
        public int? IdInternacao { get; set; }
        [Column("ID_CIRURGIA")]
        public int? IdCirurgia { get; set; }
        [Column("TIPO_ATENDIMENTO")]
        public int TipoAtendimento { get; set; }
        [Column("TAXASID_TAXAS")]
        public int TaxasidTaxas { get; set; }

        [ForeignKey(nameof(IdCirurgia))]
        [InverseProperty(nameof(Cirurgium.AtendimentoVets))]
        public virtual Cirurgium IdCirurgiaNavigation { get; set; }
        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Proprietario.AtendimentoVets))]
        public virtual Proprietario IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        [InverseProperty(nameof(Empresa.AtendimentoVets))]
        public virtual Empresa IdEmpresaNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(Pet.AtendimentoVets))]
        public virtual Pet IdPetNavigation { get; set; }
        [ForeignKey(nameof(IdVet))]
        [InverseProperty(nameof(Veterinario.AtendimentoVets))]
        public virtual Veterinario IdVetNavigation { get; set; }
        [InverseProperty(nameof(Internacao.IdAtendimentoNavigation))]
        public virtual ICollection<Internacao> Internacaos { get; set; }
        [InverseProperty(nameof(Receitum.IdAtendimentoNavigation))]
        public virtual ICollection<Receitum> Receita { get; set; }
        [InverseProperty(nameof(ServicoVeterinario.IdAtendimentoNavigation))]
        public virtual ICollection<ServicoVeterinario> ServicoVeterinarios { get; set; }
        [InverseProperty(nameof(TotalAtendimento.IdAtendimentoNavigation))]
        public virtual ICollection<TotalAtendimento> TotalAtendimentos { get; set; }
    }
}

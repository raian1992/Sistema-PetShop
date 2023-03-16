using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("INTERNACAO")]
    [Index(nameof(IdAtendimento), Name = "IX_FK_ATENDIMENTO_VETINTERNACAO")]
    [Index(nameof(IdCirurgia), Name = "IX_FK_CIRURGIAINTERNACAO")]
    [Index(nameof(IdCliente), Name = "IX_FK_ClienteINTERNACAO")]
    [Index(nameof(IdEmpresa), Name = "IX_FK_EMPRESAINTERNACAO")]
    [Index(nameof(IdPet), Name = "IX_FK_PETINTERNACAO")]
    [Index(nameof(IdVet), Name = "IX_FK_VeterinariosINTERNACAO")]
    public partial class Internacao
    {
        public Internacao()
        {
            Receita = new HashSet<Receitum>();
            ServicoVeterinarios = new HashSet<ServicoVeterinario>();
            TotalInternacaoCirurgia = new HashSet<TotalInternacaoCirurgium>();
        }

        [Key]
        [Column("ID_INTERNACAO")]
        public int IdInternacao { get; set; }
        [Column("ID_VET")]
        public int IdVet { get; set; }
        [Column("ID_PET")]
        public int IdPet { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("PESO_PET")]
        public double PesoPet { get; set; }
        [Column("ID_ATENDIMENTO")]
        public int? IdAtendimento { get; set; }
        [Column("ID_CIRURGIA")]
        public int? IdCirurgia { get; set; }

        [ForeignKey(nameof(IdAtendimento))]
        [InverseProperty(nameof(AtendimentoVet.Internacaos))]
        public virtual AtendimentoVet IdAtendimentoNavigation { get; set; }
        [ForeignKey(nameof(IdCirurgia))]
        [InverseProperty(nameof(Cirurgium.Internacaos))]
        public virtual Cirurgium IdCirurgiaNavigation { get; set; }
        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Proprietario.Internacaos))]
        public virtual Proprietario IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        [InverseProperty(nameof(Empresa.Internacaos))]
        public virtual Empresa IdEmpresaNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(Pet.Internacaos))]
        public virtual Pet IdPetNavigation { get; set; }
        [ForeignKey(nameof(IdVet))]
        [InverseProperty(nameof(Veterinario.Internacaos))]
        public virtual Veterinario IdVetNavigation { get; set; }
        [InverseProperty(nameof(Receitum.IdInternacaoNavigation))]
        public virtual ICollection<Receitum> Receita { get; set; }
        [InverseProperty(nameof(ServicoVeterinario.IdInternacaoNavigation))]
        public virtual ICollection<ServicoVeterinario> ServicoVeterinarios { get; set; }
        [InverseProperty(nameof(TotalInternacaoCirurgium.IdInternacaoNavigation))]
        public virtual ICollection<TotalInternacaoCirurgium> TotalInternacaoCirurgia { get; set; }
    }
}

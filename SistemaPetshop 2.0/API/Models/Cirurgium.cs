using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("CIRURGIA")]
    [Index(nameof(IdCliente), Name = "IX_FK_ClienteCIRURGIA")]
    [Index(nameof(IdEmpresa), Name = "IX_FK_EMPRESACIRURGIA")]
    [Index(nameof(IdPet), Name = "IX_FK_PETCIRURGIA")]
    [Index(nameof(IdVetPrincipal), Name = "IX_FK_VeterinariosCIRURGIA")]
    public partial class Cirurgium
    {
        public Cirurgium()
        {
            AtendimentoVets = new HashSet<AtendimentoVet>();
            Internacaos = new HashSet<Internacao>();
            Receita = new HashSet<Receitum>();
            VetCirurgia = new HashSet<VetCirurgium>();
        }

        [Key]
        [Column("ID_CIRURGIA")]
        public int IdCirurgia { get; set; }
        [Column("ID_VET_PRINCIPAL")]
        public int IdVetPrincipal { get; set; }
        [Column("ID_PET")]
        public int IdPet { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("PESO_PET")]
        public double PesoPet { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Proprietario.Cirurgia))]
        public virtual Proprietario IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        [InverseProperty(nameof(Empresa.Cirurgia))]
        public virtual Empresa IdEmpresaNavigation { get; set; }
        [ForeignKey(nameof(IdPet))]
        [InverseProperty(nameof(Pet.Cirurgia))]
        public virtual Pet IdPetNavigation { get; set; }
        [ForeignKey(nameof(IdVetPrincipal))]
        [InverseProperty(nameof(Veterinario.Cirurgia))]
        public virtual Veterinario IdVetPrincipalNavigation { get; set; }
        [InverseProperty("IdCirurgiaNavigation")]
        public virtual TotalInternacaoCirurgium TotalInternacaoCirurgium { get; set; }
        [InverseProperty(nameof(AtendimentoVet.IdCirurgiaNavigation))]
        public virtual ICollection<AtendimentoVet> AtendimentoVets { get; set; }
        [InverseProperty(nameof(Internacao.IdCirurgiaNavigation))]
        public virtual ICollection<Internacao> Internacaos { get; set; }
        [InverseProperty(nameof(Receitum.IdCirurgiaNavigation))]
        public virtual ICollection<Receitum> Receita { get; set; }
        [InverseProperty(nameof(VetCirurgium.IdCirurgiaNavigation))]
        public virtual ICollection<VetCirurgium> VetCirurgia { get; set; }
    }
}

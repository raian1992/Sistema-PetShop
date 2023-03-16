using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("PETS")]
    [Index(nameof(CodCliente), Name = "IX_FK_PETCliente")]
    public partial class Pet
    {
        public Pet()
        {
            AtendimentoVets = new HashSet<AtendimentoVet>();
            Cirurgia = new HashSet<Cirurgium>();
            Internacaos = new HashSet<Internacao>();
        }

        [Key]
        [Column("ID_PET")]
        public int IdPet { get; set; }
        [Required]
        [Column("NOME_PET")]
        [StringLength(40)]
        public string NomePet { get; set; }
        [Column("COD_CLIENTE")]
        public int CodCliente { get; set; }
        [Required]
        [Column("RACA_PET")]
        [StringLength(20)]
        public string RacaPet { get; set; }
        [Required]
        [Column("SEXO_PET")]
        [StringLength(20)]
        public string SexoPet { get; set; }
        [Column("DATANASC_PET", TypeName = "datetime")]
        public DateTime? DatanascPet { get; set; }
        [Column("IDADE")]
        [StringLength(20)]
        public string Idade { get; set; }
        [Column("ESPECIE_PET")]
        [StringLength(40)]
        public string EspeciePet { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [ForeignKey(nameof(CodCliente))]
        [InverseProperty(nameof(Proprietario.Pets))]
        public virtual Proprietario CodClienteNavigation { get; set; }
        [InverseProperty(nameof(AtendimentoVet.IdPetNavigation))]
        public virtual ICollection<AtendimentoVet> AtendimentoVets { get; set; }
        [InverseProperty(nameof(Cirurgium.IdPetNavigation))]
        public virtual ICollection<Cirurgium> Cirurgia { get; set; }
        [InverseProperty(nameof(Internacao.IdPetNavigation))]
        public virtual ICollection<Internacao> Internacaos { get; set; }
    }
}

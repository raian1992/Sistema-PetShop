using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("VET_CIRURGIA")]
    [Index(nameof(IdCirurgia), Name = "IX_FK_CIRURGIAVET_CIRURGIA")]
    [Index(nameof(IdVet), Name = "IX_FK_VeterinariosVET_CIRURGIA")]
    public partial class VetCirurgium
    {
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_VET")]
        public int IdVet { get; set; }
        [Column("ID_CIRURGIA")]
        public int IdCirurgia { get; set; }
        [Column("DIVIDIR_CIRURGIA")]
        public bool DividirCirurgia { get; set; }

        [ForeignKey(nameof(IdCirurgia))]
        [InverseProperty(nameof(Cirurgium.VetCirurgia))]
        public virtual Cirurgium IdCirurgiaNavigation { get; set; }
        [ForeignKey(nameof(IdVet))]
        [InverseProperty(nameof(Veterinario.VetCirurgia))]
        public virtual Veterinario IdVetNavigation { get; set; }
    }
}

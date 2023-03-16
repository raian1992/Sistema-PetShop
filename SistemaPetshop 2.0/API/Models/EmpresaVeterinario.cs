using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("EMPRESA_VETERINARIO")]
    [Index(nameof(IdEmpresa), Name = "IX_FK_EMPRESAEMPRESA_VETERINARIO")]
    [Index(nameof(IdVet), Name = "IX_FK_VeterinariosEMPRESA_VETERINARIO")]
    public partial class EmpresaVeterinario
    {
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Column("ID_VET")]
        public int IdVet { get; set; }

        [ForeignKey(nameof(IdEmpresa))]
        [InverseProperty(nameof(Empresa.EmpresaVeterinarios))]
        public virtual Empresa IdEmpresaNavigation { get; set; }
        [ForeignKey(nameof(IdVet))]
        [InverseProperty(nameof(Veterinario.EmpresaVeterinarios))]
        public virtual Veterinario IdVetNavigation { get; set; }
    }
}

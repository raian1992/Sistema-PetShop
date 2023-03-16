using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("EMPRESA_EMAIL")]
    [Index(nameof(IdEmail), Name = "IX_FK_EMAILEMPRESA_EMAIL")]
    [Index(nameof(IdEmpresa), Name = "IX_FK_EMPRESA_EMAIL1")]
    public partial class EmpresaEmail
    {
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Column("ID_EMAIL")]
        public int IdEmail { get; set; }

        [ForeignKey(nameof(IdEmail))]
        [InverseProperty(nameof(Email.EmpresaEmails))]
        public virtual Email IdEmailNavigation { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        [InverseProperty(nameof(Empresa.EmpresaEmails))]
        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}

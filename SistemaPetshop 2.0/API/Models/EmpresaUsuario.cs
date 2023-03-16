using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("EMPRESA_USUARIO")]
    [Index(nameof(IdEmpresa), Name = "IX_FK_EMPRESAEMPRESA_USUARIO")]
    [Index(nameof(IdUsuario), Name = "IX_FK_USUARIOSEMPRESA_USUARIO")]
    public partial class EmpresaUsuario
    {
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Key]
        [Column("ID_ASSOCIACAO")]
        public int IdAssociacao { get; set; }

        [ForeignKey(nameof(IdEmpresa))]
        [InverseProperty(nameof(Empresa.EmpresaUsuarios))]
        public virtual Empresa IdEmpresaNavigation { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Usuario.EmpresaUsuarios))]
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

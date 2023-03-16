using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("USUARIOS")]
    [Index(nameof(IdPerfil), Name = "IX_FK_PERFILUSUARIOS")]
    public partial class Usuario
    {
        public Usuario()
        {
            EmpresaUsuarios = new HashSet<EmpresaUsuario>();
        }

        [Key]
        [Column("Id_USUARIO")]
        public int IdUsuario { get; set; }
        [Required]
        [Column("NOME")]
        public string Nome { get; set; }
        [Required]
        [Column("lOGIN")]
        public string LOgin { get; set; }
        [Required]
        [Column("SENHA")]
        public string Senha { get; set; }
        [Required]
        [Column("CONTRA_SENHA")]
        public string ContraSenha { get; set; }
        [Required]
        public string Email { get; set; }
        [Column("ID_PERFIL")]
        public int IdPerfil { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [ForeignKey(nameof(IdPerfil))]
        [InverseProperty(nameof(Perfil.Usuarios))]
        public virtual Perfil IdPerfilNavigation { get; set; }
        [InverseProperty(nameof(EmpresaUsuario.IdUsuarioNavigation))]
        public virtual ICollection<EmpresaUsuario> EmpresaUsuarios { get; set; }
    }
}

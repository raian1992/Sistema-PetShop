using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("PERFIL")]
    public partial class Perfil
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
        }

        [Key]
        [Column("ID_PERFIL")]
        public int IdPerfil { get; set; }
        [Required]
        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [InverseProperty(nameof(Usuario.IdPerfilNavigation))]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}

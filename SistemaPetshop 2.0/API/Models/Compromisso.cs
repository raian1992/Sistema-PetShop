using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    public partial class Compromisso
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Data { get; set; }
        public TimeSpan? Hora { get; set; }
        public string Descricao { get; set; }
        [Column("USUARIO_CRIOU_COMP")]
        public int UsuarioCriouComp { get; set; }
        [Column("USUARIO_P_COMP")]
        public int? UsuarioPComp { get; set; }
        [Column("Entidade_Registro")]
        public string EntidadeRegistro { get; set; }
        [Column("ID_REGISTRO")]
        public int? IdRegistro { get; set; }
        public bool? Concluido { get; set; }
    }
}

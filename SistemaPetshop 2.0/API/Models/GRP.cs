using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("GRP")]
    public partial class Grp
    {
        [Key]
        [Column("COD_GRP")]
        public int CodGrp { get; set; }
        [Required]
        [Column("nome_grupo")]
        [StringLength(50)]
        public string NomeGrupo { get; set; }
        [Required]
        [Column("Prod_Vend")]
        [StringLength(1)]
        public string ProdVend { get; set; }
    }
}

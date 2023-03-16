using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("CFOP")]
    public partial class Cfop
    {
        [Key]
        [Column("ID_CFOP")]
        public int IdCfop { get; set; }
        [Required]
        [Column("CFOP1")]
        [StringLength(5)]
        public string Cfop1 { get; set; }
        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }
        [Required]
        [Column("MOV_ESTQ")]
        [StringLength(1)]
        public string MovEstq { get; set; }
        [Required]
        [Column("ATUALIZA_CUSTO")]
        [StringLength(1)]
        public string AtualizaCusto { get; set; }
        [Required]
        [Column("TIPO_MOV")]
        [StringLength(1)]
        public string TipoMov { get; set; }
        [Required]
        [Column("ATIVO")]
        [StringLength(1)]
        public string Ativo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("CEP")]
    public partial class Cep
    {
        [Key]
        [Column("ID_CEP")]
        public int IdCep { get; set; }
        [Required]
        [Column("NUM_CEP")]
        [StringLength(10)]
        public string NumCep { get; set; }
        [Column("ENDERECO")]
        [StringLength(40)]
        public string Endereco { get; set; }
        [Column("COMPLEMENTO")]
        [StringLength(40)]
        public string Complemento { get; set; }
        [Required]
        [Column("BAIRRO")]
        [StringLength(40)]
        public string Bairro { get; set; }
        [Required]
        [Column("CIDADE")]
        [StringLength(40)]
        public string Cidade { get; set; }
        [Required]
        [Column("ESTADO")]
        [StringLength(20)]
        public string Estado { get; set; }
        [Column("PAIS")]
        [StringLength(40)]
        public string Pais { get; set; }
        [Column("IBGE")]
        [StringLength(25)]
        public string Ibge { get; set; }
        [Column("COD_CEP")]
        public int CodCep { get; set; }
    }
}

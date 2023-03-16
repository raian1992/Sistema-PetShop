using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("Tributacao")]
    public partial class Tributacao
    {
        [Key]
        [Column("ID_TRIB")]
        public int IdTrib { get; set; }
        [Required]
        [Column("TRBID")]
        [StringLength(3)]
        public string Trbid { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [Column("CST_ENTRADA")]
        [StringLength(3)]
        public string CstEntrada { get; set; }
        [Required]
        [Column("CSOSN_ENTRADA")]
        [StringLength(4)]
        public string CsosnEntrada { get; set; }
        [Required]
        [Column("CFOP_ENTRADA_DE")]
        [StringLength(5)]
        public string CfopEntradaDe { get; set; }
        [Required]
        [Column("CFOP_ENTRADA_DEV_DE")]
        [StringLength(5)]
        public string CfopEntradaDevDe { get; set; }
        [Required]
        [Column("CFOP_ENTRADA_DEV_FE")]
        [StringLength(5)]
        public string CfopEntradaDevFe { get; set; }
        [Required]
        [Column("CFOP_ENTRADA_FE")]
        [StringLength(5)]
        public string CfopEntradaFe { get; set; }
        [Required]
        [Column("CST_SAIDA")]
        [StringLength(3)]
        public string CstSaida { get; set; }
        [Required]
        [Column("CSOSN_SAIDA")]
        [StringLength(4)]
        public string CsosnSaida { get; set; }
        [Required]
        [Column("CFOP_SAIDA_DE")]
        [StringLength(5)]
        public string CfopSaidaDe { get; set; }
        [Required]
        [Column("CFOP_SAIDA_FE")]
        [StringLength(5)]
        public string CfopSaidaFe { get; set; }
        [Required]
        [Column("CFOP_SAIDA_DEV_DE")]
        [StringLength(5)]
        public string CfopSaidaDevDe { get; set; }
        [Required]
        [Column("CFOP_SAIDA_DEV_FE")]
        [StringLength(5)]
        public string CfopSaidaDevFe { get; set; }
        [Required]
        [Column("ATIVO")]
        [StringLength(1)]
        public string Ativo { get; set; }
    }
}

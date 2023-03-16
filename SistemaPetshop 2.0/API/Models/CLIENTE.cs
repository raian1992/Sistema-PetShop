using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("CLIENTES")]
    public partial class Cliente
    {
        [Key]
        [Column("COD_CLIENTE")]
        public int CodCliente { get; set; }
        [Column("CPF")]
        [StringLength(14)]
        public string Cpf { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(40)]
        public string Nome { get; set; }
        [Column("TELEFONE")]
        [StringLength(11)]
        public string Telefone { get; set; }
        [Column("CELULAR")]
        [StringLength(11)]
        public string Celular { get; set; }
        [Column("EMAIL")]
        [StringLength(40)]
        public string Email { get; set; }
        [Column("CEP")]
        [StringLength(20)]
        public string Cep { get; set; }
        [Column("RUA")]
        [StringLength(40)]
        public string Rua { get; set; }
        [Column("NUMERO")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("BAIRRO")]
        [StringLength(40)]
        public string Bairro { get; set; }
        [Column("CIDADE")]
        [StringLength(40)]
        public string Cidade { get; set; }
        [Column("ESTADO")]
        [StringLength(10)]
        public string Estado { get; set; }
        [Column("ATIVO")]
        [StringLength(1)]
        public string Ativo { get; set; }
    }
}

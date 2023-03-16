using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Keyless]
    public partial class BPessoasEmpresa
    {
        [Required]
        [Column("NOME_PROPRIETARIO")]
        [StringLength(40)]
        public string NomeProprietario { get; set; }
        [Column("CELULAR")]
        [StringLength(24)]
        public string Celular { get; set; }
        [Column("FIXO")]
        [StringLength(22)]
        public string Fixo { get; set; }
        [Column("CIDADE_PROP")]
        [StringLength(40)]
        public string CidadeProp { get; set; }
        [Column("ESTADO_PROP")]
        [StringLength(40)]
        public string EstadoProp { get; set; }
        [Column("FANTASIA")]
        public string Fantasia { get; set; }
        [Required]
        [Column("RAZAO_SOCIAL")]
        public string RazaoSocial { get; set; }
        [Column("ID_PROPRIETARIO")]
        public int IdProprietario { get; set; }
        [Column("EMAIL")]
        [StringLength(30)]
        public string Email { get; set; }
        [Column("CEP")]
        [StringLength(8)]
        public string Cep { get; set; }
        [Column("RUA_AVENIDA")]
        [StringLength(40)]
        public string RuaAvenida { get; set; }
        [Column("NUMERO")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("BAIRRO")]
        [StringLength(40)]
        public string Bairro { get; set; }
        [Column("PROP_ATIVO")]
        public bool PropAtivo { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
    }
}

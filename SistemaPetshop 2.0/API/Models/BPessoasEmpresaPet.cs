using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Keyless]
    public partial class BPessoasEmpresaPet
    {
        [Required]
        [Column("NOME_PET")]
        [StringLength(40)]
        public string NomePet { get; set; }
        [Column("ESPECIE_PET")]
        [StringLength(40)]
        public string EspeciePet { get; set; }
        [Column("ID_PET")]
        public int IdPet { get; set; }
        [Column("IDADE")]
        [StringLength(20)]
        public string Idade { get; set; }
        [Required]
        [Column("RACA_PET")]
        [StringLength(20)]
        public string RacaPet { get; set; }
        [Required]
        [Column("SEXO_PET")]
        [StringLength(20)]
        public string SexoPet { get; set; }
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
        [Column("DATANASC_PET", TypeName = "datetime")]
        public DateTime? DatanascPet { get; set; }
        [Column("PET_ATIVO")]
        public bool PetAtivo { get; set; }
        [Column("PROP_ATIVO")]
        public bool PropAtivo { get; set; }
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
    }
}

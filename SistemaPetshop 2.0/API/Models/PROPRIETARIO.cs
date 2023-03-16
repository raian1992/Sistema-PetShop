using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("PROPRIETARIOS")]
    public partial class Proprietario
    {
        public Proprietario()
        {
            AtendimentoVets = new HashSet<AtendimentoVet>();
            Cirurgia = new HashSet<Cirurgium>();
            Internacaos = new HashSet<Internacao>();
            Pets = new HashSet<Pet>();
        }

        [Key]
        [Column("ID_PROPRIETARIO")]
        public int IdProprietario { get; set; }
        [Required]
        [Column("NOME_PROPRIETARIO")]
        [StringLength(40)]
        public string NomeProprietario { get; set; }
        [Column("EMAIL")]
        [StringLength(30)]
        public string Email { get; set; }
        [Column("CELULAR")]
        [StringLength(13)]
        public string Celular { get; set; }
        [Column("FIXO")]
        [StringLength(11)]
        public string Fixo { get; set; }
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
        [Column("CIDADE")]
        [StringLength(40)]
        public string Cidade { get; set; }
        [Column("ESTADO")]
        [StringLength(40)]
        public string Estado { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [InverseProperty(nameof(AtendimentoVet.IdClienteNavigation))]
        public virtual ICollection<AtendimentoVet> AtendimentoVets { get; set; }
        [InverseProperty(nameof(Cirurgium.IdClienteNavigation))]
        public virtual ICollection<Cirurgium> Cirurgia { get; set; }
        [InverseProperty(nameof(Internacao.IdClienteNavigation))]
        public virtual ICollection<Internacao> Internacaos { get; set; }
        [InverseProperty(nameof(Pet.CodClienteNavigation))]
        public virtual ICollection<Pet> Pets { get; set; }
    }
}

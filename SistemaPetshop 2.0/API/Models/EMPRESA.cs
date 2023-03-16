using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("EMPRESA")]
    [Index(nameof(IdConfig), Name = "IX_FK_EMPRESACONFIG")]
    public partial class Empresa
    {
        public Empresa()
        {
            AtendimentoVets = new HashSet<AtendimentoVet>();
            Cirurgia = new HashSet<Cirurgium>();
            EmpresaEmails = new HashSet<EmpresaEmail>();
            EmpresaUsuarios = new HashSet<EmpresaUsuario>();
            EmpresaVeterinarios = new HashSet<EmpresaVeterinario>();
            Internacaos = new HashSet<Internacao>();
        }

        [Key]
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }
        [Required]
        [Column("RAZAO_SOCIAL")]
        public string RazaoSocial { get; set; }
        [Column("FANTASIA")]
        public string Fantasia { get; set; }
        [Column("CNPJ_CPF")]
        public string CnpjCpf { get; set; }
        [Column("IE_RG")]
        public string IeRg { get; set; }
        [Column("CEP")]
        [StringLength(10)]
        public string Cep { get; set; }
        [Column("ENDERECO")]
        [StringLength(40)]
        public string Endereco { get; set; }
        [Column("NUMERO")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("COMPLEMENTO")]
        [StringLength(40)]
        public string Complemento { get; set; }
        [Column("BAIRRO")]
        [StringLength(40)]
        public string Bairro { get; set; }
        [Column("CIDADE")]
        [StringLength(40)]
        public string Cidade { get; set; }
        [Column("ESTADO")]
        [StringLength(40)]
        public string Estado { get; set; }
        [Column("PAIS")]
        [StringLength(40)]
        public string Pais { get; set; }
        [Column("TELEFONE")]
        public string Telefone { get; set; }
        [Column("CELULAR")]
        public string Celular { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("CHV")]
        public string Chv { get; set; }
        [Column("ID_CONFIG")]
        public int IdConfig { get; set; }
        [Column("IMAGEM")]
        public byte[] Imagem { get; set; }
        [Column("TIPO_EMPRESA")]
        public int TipoEmpresa { get; set; }
        [Column("Tipo_juros")]
        [StringLength(1)]
        public string TipoJuros { get; set; }
        [Column("Cobr_juros")]
        [StringLength(1)]
        public string CobrJuros { get; set; }
        [Column("P_juros", TypeName = "decimal(18, 0)")]
        public decimal? PJuros { get; set; }
        [Column("P_MULTA", TypeName = "decimal(18, 0)")]
        public decimal? PMulta { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [ForeignKey(nameof(IdConfig))]
        [InverseProperty(nameof(Config.Empresas))]
        public virtual Config IdConfigNavigation { get; set; }
        [InverseProperty(nameof(AtendimentoVet.IdEmpresaNavigation))]
        public virtual ICollection<AtendimentoVet> AtendimentoVets { get; set; }
        [InverseProperty(nameof(Cirurgium.IdEmpresaNavigation))]
        public virtual ICollection<Cirurgium> Cirurgia { get; set; }
        [InverseProperty(nameof(EmpresaEmail.IdEmpresaNavigation))]
        public virtual ICollection<EmpresaEmail> EmpresaEmails { get; set; }
        [InverseProperty(nameof(EmpresaUsuario.IdEmpresaNavigation))]
        public virtual ICollection<EmpresaUsuario> EmpresaUsuarios { get; set; }
        [InverseProperty(nameof(EmpresaVeterinario.IdEmpresaNavigation))]
        public virtual ICollection<EmpresaVeterinario> EmpresaVeterinarios { get; set; }
        [InverseProperty(nameof(Internacao.IdEmpresaNavigation))]
        public virtual ICollection<Internacao> Internacaos { get; set; }
    }
}

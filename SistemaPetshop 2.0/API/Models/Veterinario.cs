using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    public partial class Veterinario
    {
        public Veterinario()
        {
            AtendimentoVets = new HashSet<AtendimentoVet>();
            Cirurgia = new HashSet<Cirurgium>();
            EmpresaVeterinarios = new HashSet<EmpresaVeterinario>();
            Internacaos = new HashSet<Internacao>();
            ServicoVeterinarios = new HashSet<ServicoVeterinario>();
            VetCirurgia = new HashSet<VetCirurgium>();
        }

        [Key]
        [Column("ID_VET")]
        public int IdVet { get; set; }
        [Required]
        [Column("NOME_VET")]
        [StringLength(40)]
        public string NomeVet { get; set; }
        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required]
        [Column("CRMV")]
        [StringLength(20)]
        public string Crmv { get; set; }
        [Column("TELEFONE")]
        [StringLength(11)]
        public string Telefone { get; set; }
        [Column("CELULAR")]
        [StringLength(13)]
        public string Celular { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [InverseProperty(nameof(AtendimentoVet.IdVetNavigation))]
        public virtual ICollection<AtendimentoVet> AtendimentoVets { get; set; }
        [InverseProperty(nameof(Cirurgium.IdVetPrincipalNavigation))]
        public virtual ICollection<Cirurgium> Cirurgia { get; set; }
        [InverseProperty(nameof(EmpresaVeterinario.IdVetNavigation))]
        public virtual ICollection<EmpresaVeterinario> EmpresaVeterinarios { get; set; }
        [InverseProperty(nameof(Internacao.IdVetNavigation))]
        public virtual ICollection<Internacao> Internacaos { get; set; }
        [InverseProperty(nameof(ServicoVeterinario.IdVetNavigation))]
        public virtual ICollection<ServicoVeterinario> ServicoVeterinarios { get; set; }
        [InverseProperty(nameof(VetCirurgium.IdVetNavigation))]
        public virtual ICollection<VetCirurgium> VetCirurgia { get; set; }
    }
}

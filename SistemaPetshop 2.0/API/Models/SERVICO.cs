using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("SERVICO")]
    public partial class Servico
    {
        public Servico()
        {
            ServicoVeterinarios = new HashSet<ServicoVeterinario>();
        }

        [Key]
        [Column("ID_SERVICO")]
        public int IdServico { get; set; }
        [Required]
        [Column("NOME_SERVICO")]
        public string NomeServico { get; set; }
        [Column("VALOR_SERVICO", TypeName = "decimal(18, 2)")]
        public decimal ValorServico { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [InverseProperty(nameof(ServicoVeterinario.IdServicoNavigation))]
        public virtual ICollection<ServicoVeterinario> ServicoVeterinarios { get; set; }
    }
}

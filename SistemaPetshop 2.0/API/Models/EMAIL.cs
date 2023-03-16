using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("EMAIL")]
    public partial class Email
    {
        public Email()
        {
            EmpresaEmails = new HashSet<EmpresaEmail>();
        }

        [Key]
        [Column("ID_EMAIL")]
        public int IdEmail { get; set; }
        [Required]
        [Column("END_EMAIL")]
        public string EndEmail { get; set; }
        [Required]
        [Column("SENHA")]
        public string Senha { get; set; }
        [Required]
        [Column("SMTP")]
        public string Smtp { get; set; }
        [Required]
        [Column("PORTA")]
        public string Porta { get; set; }
        [Column("Req_AUT")]
        public bool ReqAut { get; set; }
        [Column("Req_SSL")]
        public bool ReqSsl { get; set; }

        [InverseProperty(nameof(EmpresaEmail.IdEmailNavigation))]
        public virtual ICollection<EmpresaEmail> EmpresaEmails { get; set; }
    }
}

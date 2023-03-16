using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("CONFIG")]
    public partial class Config
    {
        public Config()
        {
            Empresas = new HashSet<Empresa>();
        }

        [Key]
        [Column("ID_CONFIG")]
        public int IdConfig { get; set; }
        [Column("AT_CHV")]
        public short AtChv { get; set; }
        [Column("DT_INST", TypeName = "datetime")]
        public DateTime DtInst { get; set; }
        [Column("DT_VAL", TypeName = "datetime")]
        public DateTime DtVal { get; set; }
        [Column("MOV_ESTOQUE")]
        public bool MovEstoque { get; set; }
        [Column("UT_BANHOETOSA")]
        public bool UtBanhoetosa { get; set; }
        [Column("UT_FIN")]
        public bool UtFin { get; set; }
        [Column("UT_VENDA")]
        public bool UtVenda { get; set; }
        [Column("AT_ESTQ")]
        public bool AtEstq { get; set; }
        [Column("Val_CPF_CNPJ")]
        public bool ValCpfCnpj { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }

        [InverseProperty(nameof(Empresa.IdConfigNavigation))]
        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}

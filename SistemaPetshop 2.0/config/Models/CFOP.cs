using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CFOP
    {
        [Key]
        public int ID_CFOP  { get; set; } 
        public string CFOP1 { get; set; }
        public string Descricao { get; set; }
        public string MOV_ESTQ { get; set; }
        public string ATUALIZA_CUSTO { get; set; }
        public string TIPO_MOV { get; set; }
        public string ATIVO { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CLIENTE
    {
        [Key]
        public int COD_CLIENTE { get; set; }
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string TELEFONE { get; set; }
        public string CELULAR { get; set; }
        public string EMAIL { get; set; }
        public string CEP { get; set; }
        public string RUA { get; set; }
        public string NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public string ATIVO { get; set; }
    }
}

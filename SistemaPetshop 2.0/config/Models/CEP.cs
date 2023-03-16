using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class CEP
    {
        [Key]
        public int ID_CEP { get; set; }
        public string NUM_CEP { get; set; }
        public string ENDERECO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public string PAIS { get; set; }
        public string IBGE { get; set; }
        public int COD_CEP { get; set; }
    }
}

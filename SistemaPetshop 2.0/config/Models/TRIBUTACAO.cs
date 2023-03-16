using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class Tributacao
    {
        public int ID_TRIB { get; set; }
        public string TRBID { get; set; }
        public string NOME { get; set; }
        public string CST_ENTRADA { get; set; }
        public string CSOSN_ENTRADA { get; set; }
        public string CFOP_ENTRADA_DE { get; set; }
        public string CFOP_ENTRADA_DEV_DE { get; set; }
        public string CFOP_ENTRADA_DEV_FE { get; set; }
        public string CFOP_ENTRADA_FE { get; set; }
        public string CST_SAIDA { get; set; }
        public string CSOSN_SAIDA { get; set; }
        public string CFOP_SAIDA_DE { get; set; }
        public string CFOP_SAIDA_FE { get; set; }
        public string CFOP_SAIDA_DEV_DE { get; set; }
        public string CFOP_SAIDA_DEV_FE { get; set; }
        public string ATIVO { get; set; }
    }
}

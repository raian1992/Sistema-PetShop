using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class RECEITA
    {
        public int ID_RECEITA { get; set; }
        public Nullable<int> ID_ATENDIMENTO { get; set; }
        public Nullable<int> ID_INTERNACAO { get; set; }
        public Nullable<int> ID_CIRURGIA { get; set; }
        public string DESCRICAO_RECEITA { get; set; }
        public string DADOS_RECEITA { get; set; }
        public System.DateTime DATA_RECEITA { get; set; }
        public bool ATIVA { get; set; }

        public virtual ATENDIMENTO_VET ATENDIMENTO_VET { get; set; }
        public virtual CIRURGIA CIRURGIA { get; set; }
        public virtual INTERNACAO INTERNACAO { get; set; }
    }
}

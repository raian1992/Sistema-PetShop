using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class SERVICO_VETERINARIO
    {
        public int ID_ASSOCIACAO { get; set; }
        public int ID_SERVICO { get; set; }
        public string NOME_SERVICO { get; set; }
        public decimal VALOR_SERVICO { get; set; }
        public Nullable<int> ID_ATENDIMENTO { get; set; }
        public Nullable<int> ID_INTERNACAO { get; set; }
        public int ID_VET { get; set; }
        public System.DateTime DATA_EXECUCAO { get; set; }

        public virtual ATENDIMENTO_VET ATENDIMENTO_VET { get; set; }
        public virtual INTERNACAO INTERNACAO { get; set; }
        public virtual SERVICO SERVICO { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}

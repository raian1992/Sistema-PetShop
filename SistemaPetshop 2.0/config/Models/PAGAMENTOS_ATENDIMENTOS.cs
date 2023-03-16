using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class PAGAMENTOS_ATENDIMENTOS
    {
        public int ID_ASSOCIACAO { get; set; }
        public int ID_PAGAMENTO { get; set; }
        public string NOME_PAGAMENTO { get; set; }
        public decimal VALOR_PAGAMENTO { get; set; }
        public int ID_TIPO_ATENDIMENTO { get; set; }
        public Nullable<int> DIVIDO_VEZES { get; set; }
        public System.DateTime DATA_FECHAMENTO { get; set; }

        public virtual PAGAMENTOS PAGAMENTOS { get; set; }
        public virtual TOTAL_ATENDIMENTO TOTAL_ATENDIMENTO { get; set; }
    }
}


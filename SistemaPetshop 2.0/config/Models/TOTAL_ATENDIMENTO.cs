﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class TOTAL_ATENDIMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOTAL_ATENDIMENTO()
        {
            this.PAGAMENTOS_ATENDIMENTOS = new HashSet<PAGAMENTOS_ATENDIMENTOS>();
        }

        public int ID_ASSOCIACAO { get; set; }
        public int ID_ATENDIMENTO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal DESCONTO { get; set; }
        public decimal ACRESCIMO { get; set; }
        public decimal TOTAL { get; set; }
        public System.DateTime DATA_FINALIZACAO { get; set; }

        public virtual ATENDIMENTO_VET ATENDIMENTO_VET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGAMENTOS_ATENDIMENTOS> PAGAMENTOS_ATENDIMENTOS { get; set; }
    }
}

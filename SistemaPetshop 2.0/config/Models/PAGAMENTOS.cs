﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class PAGAMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAGAMENTOS()
        {
            this.PAGAMENTOS_ATENDIMENTOS = new HashSet<PAGAMENTOS_ATENDIMENTOS>();
            this.PAGAMENTOS_INTERNACAO = new HashSet<PAGAMENTOS_INTERNACAO>();
        }

        public int ID_PAGAMENTOS { get; set; }
        public string NOME { get; set; }
        public Nullable<int> TIPO_PAG { get; set; }
        public int ID_TAXAS { get; set; }
        public bool Gera_Fin { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGAMENTOS_ATENDIMENTOS> PAGAMENTOS_ATENDIMENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGAMENTOS_INTERNACAO> PAGAMENTOS_INTERNACAO { get; set; }
        public virtual TAXAS TAXAS { get; set; }
    }
}

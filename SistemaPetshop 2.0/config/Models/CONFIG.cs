﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class CONFIG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONFIG()
        {
            this.EMPRESA = new HashSet<EMPRESA>();
        }

        public int ID_CONFIG { get; set; }
        public short AT_CHV { get; set; }
        public System.DateTime DT_INST { get; set; }
        public System.DateTime DT_VAL { get; set; }
        public bool MOV_ESTOQUE { get; set; }
        public bool UT_BANHOETOSA { get; set; }
        public bool UT_FIN { get; set; }
        public bool UT_VENDA { get; set; }
        public bool AT_ESTQ { get; set; }
        public bool Val_CPF_CNPJ { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
    }
}

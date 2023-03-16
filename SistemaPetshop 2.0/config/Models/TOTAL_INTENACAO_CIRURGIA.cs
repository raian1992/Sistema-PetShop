using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class TOTAL_INTERNACAO_CIRURGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOTAL_INTERNACAO_CIRURGIA()
        {
            this.PAGAMENTOS_INTERNACAO = new HashSet<PAGAMENTOS_INTERNACAO>();
        }

        public int ID_ASSOCIACAO { get; set; }
        public Nullable<int> ID_INTERNACAO { get; set; }
        public Nullable<int> ID_CIRURGIA { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal DESCONTO { get; set; }
        public decimal ACRESCIMO { get; set; }
        public decimal TOTAL { get; set; }
        public System.DateTime DATA_FINALIZACAO { get; set; }

        public virtual CIRURGIA CIRURGIA { get; set; }
        public virtual CIRURGIA CIRURGIA1 { get; set; }
        public virtual INTERNACAO INTERNACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGAMENTOS_INTERNACAO> PAGAMENTOS_INTERNACAO { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICO()
        {
            this.SERVICO_VETERINARIO = new HashSet<SERVICO_VETERINARIO>();
        }

        public int ID_SERVICO { get; set; }
        public string NOME_SERVICO { get; set; }
        public decimal VALOR_SERVICO { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICO_VETERINARIO> SERVICO_VETERINARIO { get; set; }
    }
}

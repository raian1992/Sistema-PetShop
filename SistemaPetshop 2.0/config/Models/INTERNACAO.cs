using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class INTERNACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INTERNACAO()
        {
            this.RECEITA = new HashSet<RECEITA>();
            this.SERVICO_VETERINARIO = new HashSet<SERVICO_VETERINARIO>();
            this.TOTAL_INTERNACAO_CIRURGIA = new HashSet<TOTAL_INTERNACAO_CIRURGIA>();
        }

        public int ID_INTERNACAO { get; set; }
        public int ID_VET { get; set; }
        public int ID_PET { get; set; }
        public int ID_EMPRESA { get; set; }
        public int ID_CLIENTE { get; set; }
        public double PESO_PET { get; set; }
        public Nullable<int> ID_ATENDIMENTO { get; set; }
        public Nullable<int> ID_CIRURGIA { get; set; }

        public virtual ATENDIMENTO_VET ATENDIMENTO_VET { get; set; }
        public virtual CIRURGIA CIRURGIA { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual PROPRIETARIO PROPRIETARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEITA> RECEITA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICO_VETERINARIO> SERVICO_VETERINARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOTAL_INTERNACAO_CIRURGIA> TOTAL_INTERNACAO_CIRURGIA { get; set; }
        public virtual PET PETS { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}

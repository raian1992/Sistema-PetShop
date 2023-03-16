using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class CIRURGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIRURGIA()
        {
            this.ATENDIMENTO_VET = new HashSet<ATENDIMENTO_VET>();
            this.INTERNACAO = new HashSet<INTERNACAO>();
            this.TOTAL_INTERNACAO_CIRURGIA = new HashSet<TOTAL_INTERNACAO_CIRURGIA>();
            this.TOTAL_INTERNACAO_CIRURGIA1 = new HashSet<TOTAL_INTERNACAO_CIRURGIA>();
            this.VET_CIRURGIA = new HashSet<VET_CIRURGIA>();
            this.RECEITA = new HashSet<RECEITA>();
        }

        public int ID_CIRURGIA { get; set; }
        public int ID_VET_PRINCIPAL { get; set; }
        public int ID_PET { get; set; }
        public int ID_EMPRESA { get; set; }
        public int ID_CLIENTE { get; set; }
        public double PESO_PET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO_VET> ATENDIMENTO_VET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERNACAO> INTERNACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOTAL_INTERNACAO_CIRURGIA> TOTAL_INTERNACAO_CIRURGIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOTAL_INTERNACAO_CIRURGIA> TOTAL_INTERNACAO_CIRURGIA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VET_CIRURGIA> VET_CIRURGIA { get; set; }
        public virtual PROPRIETARIO PROPRIETARIOS { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual PET PETS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEITA> RECEITA { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}

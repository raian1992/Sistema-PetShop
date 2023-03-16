using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class PET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET()
        {
            this.ATENDIMENTO_VET = new HashSet<ATENDIMENTO_VET>();
            this.CIRURGIA = new HashSet<CIRURGIA>();
            this.INTERNACAO = new HashSet<INTERNACAO>();
        }

        public int ID_PET { get; set; }
        public string NOME_PET { get; set; }
        public int COD_CLIENTE { get; set; }
        public string RACA_PET { get; set; }
        public string SEXO_PET { get; set; }
        public Nullable<System.DateTime> DATANASC_PET { get; set; }
        public string IDADE { get; set; }
        public string ESPECIE_PET { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO_VET> ATENDIMENTO_VET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIRURGIA> CIRURGIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERNACAO> INTERNACAO { get; set; }
        public virtual PROPRIETARIO PROPRIETARIOS { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class PROPRIETARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPRIETARIO()
        {
            this.ATENDIMENTO_VET = new HashSet<ATENDIMENTO_VET>();
            this.CIRURGIA = new HashSet<CIRURGIA>();
            this.INTERNACAO = new HashSet<INTERNACAO>();
            this.PETS = new HashSet<PET>();
        }

        public int ID_PROPRIETARIO { get; set; }
        public string NOME_PROPRIETARIO { get; set; }
        public string EMAIL { get; set; }
        public string CELULAR { get; set; }
        public string FIXO { get; set; }
        public string CEP { get; set; }
        public string RUA_AVENIDA { get; set; }
        public string NUMERO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO_VET> ATENDIMENTO_VET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIRURGIA> CIRURGIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERNACAO> INTERNACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET> PETS { get; set; }
    }
}

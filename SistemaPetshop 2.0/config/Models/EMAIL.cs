using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class EMAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMAIL()
        {
            this.EMPRESA_EMAIL = new HashSet<EMPRESA_EMAIL>();
        }

        public int ID_EMAIL { get; set; }
        public string END_EMAIL { get; set; }
        public string SENHA { get; set; }
        public string SMTP { get; set; }
        public string PORTA { get; set; }
        public bool Req_AUT { get; set; }
        public bool Req_SSL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_EMAIL> EMPRESA_EMAIL { get; set; }
    }
}


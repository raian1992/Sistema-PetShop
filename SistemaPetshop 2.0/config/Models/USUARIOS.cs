using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.EMPRESA_USUARIO = new HashSet<EMPRESA_USUARIO>();
        }

        public int Id_USUARIO { get; set; }
        public string NOME { get; set; }
        public string lOGIN { get; set; }
        public string SENHA { get; set; }
        public string CONTRA_SENHA { get; set; }
        public string Email { get; set; }
        public int ID_PERFIL { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_USUARIO> EMPRESA_USUARIO { get; set; }
        public virtual PERFIL PERFIL { get; set; }
    }
}

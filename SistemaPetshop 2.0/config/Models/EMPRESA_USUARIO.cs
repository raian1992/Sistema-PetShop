using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class EMPRESA_USUARIO
    {
        public int ID_EMPRESA { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_ASSOCIACAO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}

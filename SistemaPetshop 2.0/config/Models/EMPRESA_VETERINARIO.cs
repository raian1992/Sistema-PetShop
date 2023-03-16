using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class EMPRESA_VETERINARIO
    {
        public int ID_ASSOCIACAO { get; set; }
        public int ID_EMPRESA { get; set; }
        public int ID_VET { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}

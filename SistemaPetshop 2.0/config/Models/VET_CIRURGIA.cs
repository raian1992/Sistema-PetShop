using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class VET_CIRURGIA
    {
        public int ID_ASSOCIACAO { get; set; }
        public int ID_VET { get; set; }
        public int ID_CIRURGIA { get; set; }
        public bool DIVIDIR_CIRURGIA { get; set; }

        public virtual CIRURGIA CIRURGIA { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}

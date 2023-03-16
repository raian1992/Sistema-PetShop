using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class Compromissos
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public string Descricao { get; set; }
        public int USUARIO_CRIOU_COMP { get; set; }
        public Nullable<int> USUARIO_P_COMP { get; set; }
        public string Entidade_Registro { get; set; }
        public Nullable<int> ID_REGISTRO { get; set; }
        public Nullable<bool> Concluido { get; set; }
    }
}

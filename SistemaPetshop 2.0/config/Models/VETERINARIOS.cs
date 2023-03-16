﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class Veterinarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Veterinarios()
        {
            this.ATENDIMENTO_VET = new HashSet<ATENDIMENTO_VET>();
            this.CIRURGIA = new HashSet<CIRURGIA>();
            this.EMPRESA_VETERINARIO = new HashSet<EMPRESA_VETERINARIO>();
            this.INTERNACAO = new HashSet<INTERNACAO>();
            this.SERVICO_VETERINARIO = new HashSet<SERVICO_VETERINARIO>();
            this.VET_CIRURGIA = new HashSet<VET_CIRURGIA>();
        }

        public int ID_VET { get; set; }
        public string NOME_VET { get; set; }
        public string CPF { get; set; }
        public string CRMV { get; set; }
        public string TELEFONE { get; set; }
        public string CELULAR { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO_VET> ATENDIMENTO_VET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIRURGIA> CIRURGIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_VETERINARIO> EMPRESA_VETERINARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERNACAO> INTERNACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICO_VETERINARIO> SERVICO_VETERINARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VET_CIRURGIA> VET_CIRURGIA { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public partial class EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA()
        {
            this.ATENDIMENTO_VET = new HashSet<ATENDIMENTO_VET>();
            this.CIRURGIA = new HashSet<CIRURGIA>();
            this.EMPRESA_EMAIL = new HashSet<EMPRESA_EMAIL>();
            this.EMPRESA_USUARIO = new HashSet<EMPRESA_USUARIO>();
            this.EMPRESA_VETERINARIO = new HashSet<EMPRESA_VETERINARIO>();
            this.INTERNACAO = new HashSet<INTERNACAO>();
        }

        public int ID_EMPRESA { get; set; }
        public string RAZAO_SOCIAL { get; set; }
        public string FANTASIA { get; set; }
        public string CNPJ_CPF { get; set; }
        public string IE_RG { get; set; }
        public string CEP { get; set; }
        public string ENDERECO { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public string PAIS { get; set; }
        public string TELEFONE { get; set; }
        public string CELULAR { get; set; }
        public string EMAIL { get; set; }
        public string CHV { get; set; }
        public int ID_CONFIG { get; set; }
        public byte[] IMAGEM { get; set; }
        public int TIPO_EMPRESA { get; set; }
        public string Tipo_juros { get; set; }
        public string Cobr_juros { get; set; }
        public Nullable<decimal> P_juros { get; set; }
        public Nullable<decimal> P_MULTA { get; set; }
        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO_VET> ATENDIMENTO_VET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIRURGIA> CIRURGIA { get; set; }
        public virtual CONFIG CONFIG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_EMAIL> EMPRESA_EMAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_USUARIO> EMPRESA_USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_VETERINARIO> EMPRESA_VETERINARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERNACAO> INTERNACAO { get; set; }
    }
}

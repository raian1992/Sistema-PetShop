//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaPetshop_2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPRESA_VETERINARIO
    {
        public int ID_ASSOCIACAO { get; set; }
        public int ID_EMPRESA { get; set; }
        public int ID_VET { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}
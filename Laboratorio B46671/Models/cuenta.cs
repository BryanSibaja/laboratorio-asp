//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio_B46671.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cuenta
    {
        public string numero { get; set; }
        public string tipo { get; set; }
        public string cedula { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}

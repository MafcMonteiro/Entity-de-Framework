//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OficinaEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Veiculo = new HashSet<Veiculo>();
        }
    
        public int Codigo_cli { get; set; }
        public string Nome_cli { get; set; }
        public string Email_cli { get; set; }
        public System.DateTime Nascimento_cli { get; set; }
    
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AttackBonus { get; set; }
        public int DefenseBonus { get; set; }
        public Nullable<int> CharacterId { get; set; }
    
        public virtual Characters Characters { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Treatment
    {
        public int TreatmentId { get; set; }
        public int ProcedureId { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int OwnerId { get; set; }
        public System.DateTime Dates { get; set; }
        public string Notes { get; set; }
        public decimal Price { get; set; }
    
        public virtual Pet Pet { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}

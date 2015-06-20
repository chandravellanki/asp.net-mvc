//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Defect
    {
        public int Id { get; set; }
        public int Prod_Id { get; set; }
        public int Rel_Id { get; set; }
        public string Defect_Description { get; set; }
        public string Developer { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
        public Nullable<System.DateTime> Closed_Date { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Release Release { get; set; }
    }
}

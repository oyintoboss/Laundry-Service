//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DT
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_tblDuration
    {
        public int DurationID { get; set; }
        public string Months { get; set; }
        public bool Twilight { get; set; }
        public string Weekly { get; set; }
        public int UserID { get; set; }
    
        public virtual C_tblUser C_tblUser { get; set; }
    }
}
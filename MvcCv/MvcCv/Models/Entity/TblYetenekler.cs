//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblYetenekler
    {
        public int Id { get; set; }
        public string yetenek_ismi { get; set; }
        public Nullable<decimal> yetenek_yuzdesi { get; set; }
        public string yetenek_renk { get; set; }
    }
}

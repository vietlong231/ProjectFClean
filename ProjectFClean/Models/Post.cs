//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectFClean.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public string PID { get; set; }
        public string ServiceID { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Experience { get; set; }
        public string Note { get; set; }
        public string RID { get; set; }
        public string HID { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
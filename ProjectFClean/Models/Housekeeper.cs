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
    
    public partial class Housekeeper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Housekeeper()
        {
            this.Compacts = new HashSet<Compact>();
            this.Feedbacks = new HashSet<Feedback>();
        }
    
        public string HID { get; set; }
        public string Gmail { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Price { get; set; }
        public string Distrinct { get; set; }
        public string Address { get; set; }
        public string Skill { get; set; }
        public string Experiment { get; set; }
        public string Discription { get; set; }
        public string AccountID { get; set; }
        public decimal Money { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compact> Compacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}

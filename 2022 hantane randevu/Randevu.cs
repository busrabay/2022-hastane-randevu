//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2022_hantane_randevu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Randevu
    {
        public int randevuId { get; set; }
        public Nullable<int> usersId { get; set; }
        public Nullable<int> doktorId { get; set; }
        public Nullable<int> poliklinikId { get; set; }
        public Nullable<int> sehirId { get; set; }
        public Nullable<int> hastaneId { get; set; }
    
        public virtual Doktorlar Doktorlar { get; set; }
        public virtual Hastaneadi Hastaneadi { get; set; }
        public virtual Poliklinikler Poliklinikler { get; set; }
        public virtual Users Users { get; set; }
        public virtual Sehir Sehir { get; set; }
    }
}
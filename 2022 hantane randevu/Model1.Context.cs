﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doktorlar> Doktorlar { get; set; }
        public virtual DbSet<Hastaneadi> Hastaneadi { get; set; }
        public virtual DbSet<Poliklinikler> Poliklinikler { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

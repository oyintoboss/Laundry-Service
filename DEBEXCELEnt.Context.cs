﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEBEXCELEntities : DbContext
    {
        public DEBEXCELEntities()
            : base("name=DEBEXCELEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_tblAmount> C_tblAmount { get; set; }
        public virtual DbSet<C_tblDuration> C_tblDuration { get; set; }
        public virtual DbSet<C_tblSavingMethod> C_tblSavingMethod { get; set; }
        public virtual DbSet<C_tblUser> C_tblUser { get; set; }
        public virtual DbSet<C_tblUserAdmin> C_tblUserAdmin { get; set; }
        public virtual DbSet<C_tblWithdraw> C_tblWithdraw { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}

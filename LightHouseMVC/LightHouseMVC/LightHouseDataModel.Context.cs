﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightHouseMVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LightHouseDatabaseEntities : DbContext
    {
        public LightHouseDatabaseEntities()
            : base("name=LightHouseDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Parent_Profile> Parent_Profile { get; set; }
        public DbSet<School_Profile> School_Profile { get; set; }
        public DbSet<Student_Profile> Student_Profile { get; set; }
        public DbSet<Teacher_Profile> Teacher_Profile { get; set; }
    }
}

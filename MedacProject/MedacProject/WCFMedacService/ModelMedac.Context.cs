﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFMedacService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelMedacContainer : DbContext
    {
        public ModelMedacContainer()
            : base("name=ModelMedacContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> PatientSet { get; set; }
        public virtual DbSet<Measurement> MeasurementSet { get; set; }
        public virtual DbSet<Doctor> DoctorSet { get; set; }
    }
}

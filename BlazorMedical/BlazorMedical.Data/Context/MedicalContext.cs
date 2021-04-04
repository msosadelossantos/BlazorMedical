using BlazorMedical.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Context
{
    public partial class MedicalContext: DbContext 
    {
        public MedicalContext(DbContextOptions <MedicalContext> options) : base(options) {}

        public virtual DbSet<Medico> Medicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.MedicoId);
                entity.Property(e => e.MedicoId).HasColumnName("medicoId");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }
}

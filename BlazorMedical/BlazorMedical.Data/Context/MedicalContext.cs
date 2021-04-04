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
            entity.Property(e => e.Nombre).HasColumnName("nombre").IsRequired();
            entity.Property(e => e.Nombre2).HasColumnName("nombre2");
            entity.Property(e => e.Apellido).HasColumnName("apellido").IsRequired();
            entity.Property(e => e.Apellido2).HasColumnName("apellido2");
            entity.Property(e => e.Dni).HasColumnName("dni").HasMaxLength(8).IsRequired();
            entity.Property(e => e.Cuit).HasColumnName("cuit").HasMaxLength(11).IsRequired();            
            entity.Property(e => e.DireccionCalle).HasColumnName("direccionCalle").IsRequired();
            entity.Property(e => e.DireccionNumero).HasColumnName("direccionNumero").IsRequired();
            entity.Property(e => e.DireccionLocalidad).HasColumnName("direccionLocalidad").IsRequired();
            entity.Property(e => e.DireccionCp).HasColumnName("direccionCp");
            entity.Property(e => e.DireccionProvincia).HasColumnName("direccionProvincia").IsRequired();
            entity.Property(e => e.DireccionPais).HasColumnName("direccionPais").IsRequired();
            entity.Property(e => e.PaisNacimiento).HasColumnName("paisNacimiento").IsRequired();
            entity.Property(e => e.FechaDeNacimiento).HasColumnName("FechaDeNacimiento").HasColumnType("timestamp without time zone");
               




    });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.EspecialidadId);
                entity.Property(e => e.EspecialidadId).HasColumnName("especialidadId");
                entity.Property(e => e.Nombre).HasColumnName("nombre").IsRequired();

                entity.Property(e => e.Descripcion).HasColumnName("descripcion").IsRequired();

              




            });

            modelBuilder.Entity<MedicoEspecialidad>(entity =>
            {
                entity.HasKey(e => e.MedicoEspecialidadId);
                entity.Property(e => e.MedicoEspecialidadId).HasColumnName("medicoEspecialidadId");

                entity.Property(e => e.MedicoId).HasColumnName("medicoId").IsRequired();

                entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadId").IsRequired();

                entity.HasOne(e => e.Medico).WithMany(p => p.MedicoEspecialidades).HasForeignKey(e => e.MedicoId).HasConstraintName("FK_MedicoEspecialidades_Medico");

                entity.HasOne(e => e.Especialidad).WithMany(p => p.MedicoEspecialidades).HasForeignKey(e => e.EspecialidadId).HasConstraintName("FK_MedicoEspecialidades_Especialidades");




            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }
}

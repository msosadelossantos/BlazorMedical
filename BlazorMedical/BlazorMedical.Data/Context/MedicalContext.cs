using BlazorMedical.Data.Entities;
using BlazorMedical.Data.Utils;
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
        public virtual DbSet<Especialidad> Especialidades { get; set; }
        public virtual DbSet<MedicoEspecialidad> MedicoEspecialidades { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Medico>(entity =>
            {
    
            entity.HasKey(e => e.MedicoId);
            entity.Property(e => e.MedicoId).HasColumnName("medicoId").ValueGeneratedNever();                 
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
            entity.Property(e => e.DireccionPaisId).HasColumnName("direccionPaisId").IsRequired();
            entity.Property(e => e.FechaDeNacimiento).HasColumnName("FechaDeNacimiento").HasColumnType("timestamp without time zone");
           
            entity.Property(e => e.DireccionProvinciaId).HasColumnName("direccionProvinciaId").IsRequired();
            entity.Property(e => e.PaisNacimientoId).HasColumnName("paisNacimientoId").IsRequired();

                entity.HasOne(e => e.PaisNacimiento)
                   .WithMany(x => x.Medicos)
                   .HasForeignKey(e => e.PaisNacimientoId)
                   .HasConstraintName("FK_Medicos_Paises");

                entity.HasOne(e => e.DireccionProvincia)
                 .WithMany(x => x.Medicos)
                 .HasForeignKey(e => e.DireccionProvinciaId)
                 .HasConstraintName("FK_Medicos_Provincias");

                entity.HasOne(e => e.DireccionPais)
                   .WithMany(x => x.MedicosRecidencia)
                   .HasForeignKey(e => e.DireccionPaisId)
                   .HasConstraintName("FK_Medicos_PaisesRecidencia");

            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.EspecialidadId);
                entity.Property(e => e.EspecialidadId).HasColumnName("especialidadId").ValueGeneratedNever();
                entity.Property(e => e.Nombre).HasColumnName("nombre").IsRequired();
                entity.Property(e => e.Descripcion).HasColumnName("descripcion").IsRequired();

            });

            modelBuilder.Entity<MedicoEspecialidad>(entity =>
            {
                entity.HasKey(e => e.MedicoEspecialidadId);
                entity.Property(e => e.MedicoEspecialidadId).HasColumnName("medicoEspecialidadId").ValueGeneratedNever();
                entity.Property(e => e.MedicoId).HasColumnName("medicoId").IsRequired();
                entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadId").IsRequired();

                entity.HasOne(e => e.Medico)
                .WithMany(p => p.MedicoEspecialidades)
                .HasForeignKey(e => e.MedicoId)
                .HasConstraintName("FK_MedicoEspecialidades_Medico");

                entity.HasOne(e => e.Especialidad)
                .WithMany(p => p.MedicoEspecialidades)
                .HasForeignKey(e => e.EspecialidadId)
                .HasConstraintName("FK_MedicoEspecialidades_Especialidades");

            });


            modelBuilder.Entity<Paciente>(entity =>
            {

                entity.HasKey(e => e.PacienteId);
                entity.Property(e => e.PacienteId).HasColumnName("pacienteId").ValueGeneratedNever();
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
                entity.Property(e => e.DireccionPaisId).HasColumnName("direccionPaisId").IsRequired();
                entity.Property(e => e.FechaDeNacimiento).HasColumnName("FechaDeNacimiento").HasColumnType("timestamp without time zone");

                entity.Property(e => e.DireccionProvinciaId).HasColumnName("direccionProvinciaId").IsRequired();
                entity.Property(e => e.PaisNacimientoId).HasColumnName("paisNacimientoId").IsRequired();


                entity.HasOne(e => e.PaisNacimiento)
                   .WithMany(x => x.Pacientes)
                   .HasForeignKey(e => e.PaisNacimientoId)
                   .HasConstraintName("FK_Pacientes_Paises");

                entity.HasOne(e => e.DireccionProvincia)
                 .WithMany(x => x.Pacientes)
                 .HasForeignKey(e => e.DireccionProvinciaId)
                 .HasConstraintName("FK_Pacientes_Provincias");

                entity.HasOne(e => e.DireccionPais)
                   .WithMany(x => x.PacientesRecidencia)
                   .HasForeignKey(e => e.DireccionPaisId)
                   .HasConstraintName("FK_Pacientes_PaisesRecidencia");
            });


            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.PaisId);
                entity.Property(e => e.PaisId).HasColumnName("paisId").ValueGeneratedNever();
                entity.Property(e => e.Nombre).HasColumnName("nombre").IsRequired();
                entity.Property(e => e.Descripcion).HasColumnName("descripcion").IsRequired();


               

            });
            modelBuilder.Entity<Pais>().HasData(
                
                new Pais { PaisId = IdGenerator.Generate(), Nombre = "Argentina", Descripcion = ""},
                new Pais { PaisId = IdGenerator.Generate(), Nombre = "Uruguay", Descripcion = "" },
                new Pais { PaisId = IdGenerator.Generate(), Nombre = "Brasil", Descripcion = "" },
                new Pais { PaisId = IdGenerator.Generate(), Nombre = "Paraguay", Descripcion = "" },
                new Pais { PaisId = IdGenerator.Generate(), Nombre = "Chile", Descripcion = "" },
                new Pais { PaisId = IdGenerator.Generate(), Nombre = "Bolivia", Descripcion = "" }
                );


            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.ProvinciaId);
                entity.Property(e => e.ProvinciaId).HasColumnName("provinciaId").ValueGeneratedNever();
                entity.Property(e => e.Nombre).HasColumnName("nombre").IsRequired();
                entity.Property(e => e.Descripcion).HasColumnName("descripcion").IsRequired();

            });

            modelBuilder.Entity<Provincia>().HasData(

               new Provincia { ProvinciaId = IdGenerator.Generate(), Nombre = "Buenos Aires", Descripcion = "" },
               new Provincia { ProvinciaId = IdGenerator.Generate(), Nombre = "C.A.B.A", Descripcion = "" },
               new Provincia { ProvinciaId = IdGenerator.Generate(), Nombre = "Córdoba", Descripcion = "" },
               new Provincia { ProvinciaId = IdGenerator.Generate(), Nombre = "Entre Rios", Descripcion = "" }

               );


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EscuelaEntities.DBEntities
{
    public partial class EscuelaBDContext : DbContext
    {
        public EscuelaBDContext()
        {
        }

        public EscuelaBDContext(DbContextOptions<EscuelaBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;
        public virtual DbSet<Nota> Notas { get; set; } = null!;
        public virtual DbSet<Profesor> Profesores { get; set; } = null!;        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.ToTable("Estudiante");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.ToTable("Nota");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdEstudianteNavigation)
                    .WithMany(p => p.Notas)
                    .HasForeignKey(d => d.IdEstudiante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nota_Estudiante");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany(p => p.Notas)
                    .HasForeignKey(d => d.IdProfesor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nota_Profesor");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.ToTable("Profesor");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

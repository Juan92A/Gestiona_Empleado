using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_Empleados.Models;

public partial class AdminEContext : DbContext
{
    public AdminEContext()
    {
    }

    public AdminEContext(DbContextOptions<AdminEContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //    => optionsBuilder.UseSqlServer("Server=DESKTOP-AJCCUAT\\SQLEXPRESS;Database=adminE;Trusted_Connection=True;Encrypt=False");

        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__empleado__3213E83F5D15131D");

            entity.ToTable("empleados");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Correo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("date")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

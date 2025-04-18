using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace curdApi.Models;

public partial class CrudApiContext : DbContext
{
    public CrudApiContext()
    {
    }

    public CrudApiContext(DbContextOptions<CrudApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__students__3213E83F5032EC58");

            entity.ToTable("students");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sage).HasColumnName("sage");
            entity.Property(e => e.Semail)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("semail");
            entity.Property(e => e.Sname)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

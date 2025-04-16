using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIcrud.Models;

public partial class DbApiContext : DbContext
{
    public DbApiContext()
    {
    }

    public DbApiContext(DbContextOptions<DbApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__students__3213E83FB6572182");

            entity.ToTable("students");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Sage).HasColumnName("sage");
            entity.Property(e => e.Sname)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

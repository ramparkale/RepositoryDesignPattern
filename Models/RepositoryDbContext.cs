using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RepositoryDesignPattern.Models;

public partial class RepositoryDbContext : DbContext
{
    public RepositoryDbContext()
    {
    }

    public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-9HOKHQ6;Database=RepositoryDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8C4709B92");

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Customername)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Students__CA1E5D784F9E1FD7");

            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sname)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DonutsNDexsBackend.Models;

public partial class DonutsNdevsContext : DbContext
{
    public DonutsNdevsContext()
    {
    }

    public DonutsNdevsContext(DbContextOptions<DonutsNdevsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dev> Devs { get; set; }

    public virtual DbSet<Donut> Donuts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DonutsNDevs;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dev>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Devs__3213E83FD55996A2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(16)
                .HasColumnName("firstName");
            entity.Property(e => e.Innovation)
                .HasMaxLength(60)
                .HasColumnName("innovation");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("lastName");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Donut>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Donuts__3213E83FED7C84C3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calories).HasColumnName("calories");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");
            entity.Property(e => e.Photo)
                .HasMaxLength(250)
                .HasColumnName("photo");
            entity.Property(e => e.PhotoAttribution)
                .HasMaxLength(250)
                .HasColumnName("photo_attribution");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IntroToFullStack.Models;

public partial class Movies2Context : DbContext
{
    public Movies2Context()
    {
    }

    public Movies2Context(DbContextOptions<Movies2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Movies2;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movies__3213E83FD3A91B87");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Genre)
                .HasMaxLength(20)
                .HasColumnName("genre");
            entity.Property(e => e.Runtime).HasColumnName("runtime");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

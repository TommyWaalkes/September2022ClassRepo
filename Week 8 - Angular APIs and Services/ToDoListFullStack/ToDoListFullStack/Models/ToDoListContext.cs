using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoListFullStack.Models;

public partial class ToDoListContext : DbContext
{
    public ToDoListContext()
    {
    }

    public ToDoListContext(DbContextOptions<ToDoListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ToDo> ToDos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ToDoList;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ToDos__3213E83F77D0BD72");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .HasColumnName("description");
            entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

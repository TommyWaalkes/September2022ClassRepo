using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityRelationships.Models;

public partial class School2Context : DbContext
{
    public School2Context()
    {
    }

    public School2Context(DbContextOptions<School2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<IdCard> IdCards { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentGrade> StudentGrades { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=school2;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Grades__3214EC072190F8BD");

            entity.Property(e => e.Grade1)
                .HasMaxLength(1)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<IdCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IdCards__3214EC07EEE6BF4E");

            entity.HasIndex(e => e.StudentId, "UQ__IdCards__32C52B983CBFD9AA").IsUnique();

            entity.HasOne(d => d.Student).WithOne(p => p.IdCard)
                .HasForeignKey<IdCard>(d => d.StudentId)
                .HasConstraintName("FK__IdCards__Student__398D8EEE");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC0769FCA135");

            entity.Property(e => e.FName)
                .HasMaxLength(15)
                .HasColumnName("fName");
            entity.Property(e => e.LName)
                .HasMaxLength(20)
                .HasColumnName("lName");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Students)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK__Students__Teache__3C69FB99");
        });

        modelBuilder.Entity<StudentGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudentG__3214EC075FF8F3B6");

            entity.Property(e => e.Subject).HasMaxLength(15);

            entity.HasOne(d => d.Grade).WithMany(p => p.StudentGrades)
                .HasForeignKey(d => d.GradeId)
                .HasConstraintName("FK__StudentGr__Grade__4222D4EF");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentGrades)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__StudentGr__Stude__412EB0B6");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teacher__3214EC071D8C6C95");

            entity.ToTable("Teacher");

            entity.Property(e => e.LName)
                .HasMaxLength(20)
                .HasColumnName("lName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

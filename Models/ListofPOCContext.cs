using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ListofPOC.Models
{
    public partial class ListofPOCContext : DbContext
    {
        public ListofPOCContext()
        {
        }

        public ListofPOCContext(DbContextOptions<ListofPOCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookStudent> BookStudent { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.IsNew)
                    .HasColumnName("isNew")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsUpdate)
                    .HasColumnName("isUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BookStudent>(entity =>
            {
                entity.ToTable("Book_Student");

                entity.Property(e => e.BookId).HasColumnName("Book_id");

                entity.Property(e => e.StudentId).HasColumnName("Student_id");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Class1)
                    .HasColumnName("Class")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.IdClass).HasColumnName("Id_Class");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Class");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

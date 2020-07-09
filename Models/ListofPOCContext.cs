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

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Class)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

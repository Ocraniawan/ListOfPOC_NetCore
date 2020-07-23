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
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Cohive> Cohives { get; set; }
        public virtual DbSet<Quantum> Quantum { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Address1)
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Quantum>(entity =>
            {
                entity.HasOne<Cohive>(q => q.Cohive)
                    .WithMany(c => c.Quantum)
                    .HasForeignKey(q => q.CohiveId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(q => q.Name)
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BookStudent>(entity =>
            {
                entity.HasKey(bs => new { bs.StudentId, bs.BookId });

                entity.HasOne<Student>(bs => bs.Student)
                    .WithMany(bS => bS.BookStudents)
                    .HasForeignKey(bs => bs.StudentId);

                entity.HasOne<Book>(bs => bs.Book)
                    .WithMany(bS => bS.BookStudents)
                    .HasForeignKey(bs => bs.BookId);

            });

            modelBuilder.Entity<Student>(entity =>
            {

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne<Address>(s => s.Address)
                    .WithOne(ad => ad.Student)
                    .HasForeignKey<Address>(ad => ad.StudentId);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

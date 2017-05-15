using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SePracticeDemo.Models
{
    public partial class CollegeDataContext : DbContext
    {
        public CollegeDataContext(DbContextOptions<CollegeDataContext> options) : base(options) {  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.ObjeId)
                    .HasName("PK_School");

                entity.Property(e => e.Header).HasColumnType("nchar(10)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(30)");

                entity.Property(e => e.Place).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK_Student");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.TheSchool).HasColumnName("theSchool");

                entity.HasOne(d => d.TheSchoolNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.TheSchool)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Student_School");
            });
        }

        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
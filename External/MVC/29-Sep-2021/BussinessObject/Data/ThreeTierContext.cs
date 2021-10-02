using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model.Model;

#nullable disable

namespace Model.Data
{
    public partial class ThreeTierContext : DbContext
    {
        public ThreeTierContext()
        {
        }

        public ThreeTierContext(DbContextOptions<ThreeTierContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Break> Breaks { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRoll> EmployeeRolls { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Roll> Rolls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRAINEE-05;Database=ThreeTier;User Id=SA;Password=harant@26031999");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Break>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Breaks)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Break__EntryID__00200768");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__Employee__Gender__76969D2E");
            });

            modelBuilder.Entity<EmployeeRoll>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Employee___Emplo__7B5B524B");

                entity.HasOne(d => d.Roll)
                    .WithMany()
                    .HasForeignKey(d => d.RollId)
                    .HasConstraintName("FK__Employee___RollI__7A672E12");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Presentation.Models;

#nullable disable

namespace Presentation.Data
{
    public partial class NTireAppContext : DbContext
    {
        public NTireAppContext()
        {
        }

        public NTireAppContext(DbContextOptions<NTireAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<Break> Breaks { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRAINEE-05; Database=NTireApp;User Id=SA; Password=harant@26031999;Trusted_Connection=false;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
            });

            modelBuilder.Entity<Break>(entity =>
            {
                entity.Property(e => e.TotalBreakTime).HasComputedColumnSql("(datediff(minute,[BreakIn],[BreakOut]))", false);

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Breaks)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Break__EntryID__2CF2ADDF");
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.Property(e => e.TotalWorkingTime).HasComputedColumnSql("(datediff(minute,[InTime],[OutTime]))", false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Entry__EmployeeI__2739D489");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

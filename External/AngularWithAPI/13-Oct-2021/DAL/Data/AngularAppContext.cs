using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Models;

#nullable disable

namespace DAL.Data
{
    public partial class AngularAppContext : DbContext
    {
        public AngularAppContext()
        {
        }

        public AngularAppContext(DbContextOptions<AngularAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
        public virtual DbSet<InterviewerReview> InterviewerReviews { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillRating> SkillRatings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRAINEE-05; Database=AngularApp;User Id=SA; Password=harant@26031999;Trusted_Connection=false;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.Property(e => e.Resume).IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Applicants)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Applicant__Creat__267ABA7A");
            });

            modelBuilder.Entity<EmployeeRole>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmployeeR__Emplo__30F848ED");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__EmployeeR__RoleI__300424B4");
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK__Interview__Appli__2B3F6F97");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.AssessmentId)
                    .HasConstraintName("FK__Interview__Asses__2C3393D0");
            });

            modelBuilder.Entity<InterviewerReview>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Interview__Emplo__3C69FB99");

                entity.HasOne(d => d.Interview)
                    .WithMany()
                    .HasForeignKey(d => d.InterviewId)
                    .HasConstraintName("FK__Interview__Inter__3B75D760");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Skill__ParentID__33D4B598");
            });

            modelBuilder.Entity<SkillRating>(entity =>
            {
                entity.HasOne(d => d.Interview)
                    .WithMany()
                    .HasForeignKey(d => d.InterviewId)
                    .HasConstraintName("FK__SkillRati__Inter__37A5467C");

                entity.HasOne(d => d.Rating)
                    .WithMany()
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK__SkillRati__Ratin__398D8EEE");

                entity.HasOne(d => d.Skill)
                    .WithMany()
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__SkillRati__Skill__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

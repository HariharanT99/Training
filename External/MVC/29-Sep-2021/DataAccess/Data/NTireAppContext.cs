using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Models;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Linq;

#nullable disable

namespace DAL.Data
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

        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Break> Breaks { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRAINEE-05; Database=NTireApp; User Id=SA; Password=harant@26031999");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<Break>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Breaks)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Break__EntryID__4D94879B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public IQueryable<AspNetUser> GetUser(string name)
        {
            SqlParameter pName = new SqlParameter("@Email", name);
            var user = AspNetUsers.FromSqlRaw("EXECUTE uspGetEmployee @Email", pName);
            return user;
        }
    }
}

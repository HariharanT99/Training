using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    [Table("Entry")]
    [Index(nameof(Date), Name = "UQ__Entry__77387D0787BDF0A8", IsUnique = true)]
    public partial class Entry
    {
        public Entry()
        {
            Breaks = new HashSet<Break>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [StringLength(450)]
        public string EmployeeId { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? InTime { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? OutTime { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(AspNetUser.Entries))]
        public virtual AspNetUser Employee { get; set; }

        [InverseProperty(nameof(Break.Entry))]
        public virtual ICollection<Break> Breaks { get; set; }
    }
}

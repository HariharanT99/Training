using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    [Table("Entry")]
    public partial class Entry
    {
        public Entry()
        {
            Breaks = new HashSet<Break>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "InTime is required")]
        public DateTime? InTime { get; set; }
        [Column(TypeName = "datetime")]

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "OutTime is required")]
        public DateTime? OutTime { get; set; }

        [InverseProperty(nameof(Break.Entry))]
        public virtual ICollection<Break> Breaks { get; set; }
    }
}

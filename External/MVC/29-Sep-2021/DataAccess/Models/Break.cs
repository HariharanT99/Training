using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    [Table("Break")]
    public partial class Break
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("EntryID")]
        public int? EntryId { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? BreakIn { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? BreakOut { get; set; }

        [ForeignKey(nameof(EntryId))]
        [InverseProperty("Breaks")]
        public virtual Entry Entry { get; set; }
    }
}

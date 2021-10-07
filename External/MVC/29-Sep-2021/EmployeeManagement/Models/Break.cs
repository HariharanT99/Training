using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Presentation.Models
{
    [Table("Break")]
    public partial class Break
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EntryID")]
        public int? EntryId { get; set; }
        public TimeSpan? BreakIn { get; set; }
        public TimeSpan? BreakOut { get; set; }
        public int? TotalBreakTime { get; set; }

        [ForeignKey(nameof(EntryId))]
        [InverseProperty("Breaks")]
        public virtual Entry Entry { get; set; }
    }
}

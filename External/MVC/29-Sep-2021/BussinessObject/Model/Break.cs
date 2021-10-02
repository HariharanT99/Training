using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Model.Model
{
    [Table("Break")]
    public partial class Break
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EntryID")]
        public int? EntryId { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.Time)]
        public DateTime? BreakIn { get; set; }
        [Column(TypeName = "datetime")]
        [DataType(DataType.Time)]
        public DateTime? BreakOut { get; set; }

        [ForeignKey(nameof(EntryId))]
        [InverseProperty("Breaks")]
        public virtual Entry Entry { get; set; }
    }
}

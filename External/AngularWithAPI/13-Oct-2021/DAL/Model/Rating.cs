using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Model
{
    [Table("Rating")]
    public partial class Rating
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int? Value { get; set; }
        [StringLength(20)]
        public string Category { get; set; }
    }
}

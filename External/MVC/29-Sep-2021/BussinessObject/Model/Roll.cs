using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Model.Model
{
    [Table("Roll")]
    public partial class Roll
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int? Type { get; set; }
    }
}

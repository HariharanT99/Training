using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Model
{
    [Table("Role")]
    public partial class Role
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(150)]
        public string Type { get; set; }
    }
}

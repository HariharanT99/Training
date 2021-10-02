using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Model.Model
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("GenderID")]
        public int? GenderId { get; set; }
        [Column("Date_Of_Birth", TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        [StringLength(200)]
        public string Address { get; set; }

        [ForeignKey(nameof(GenderId))]
        [InverseProperty("Employees")]
        public virtual Gender Gender { get; set; }
    }
}

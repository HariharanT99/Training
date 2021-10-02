using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Model.Model
{
    [Table("Gender")]
    public partial class Gender
    {
        public Gender()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Gender")]
        [StringLength(6)]
        public string Gender1 { get; set; }

        [InverseProperty(nameof(Employee.Gender))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

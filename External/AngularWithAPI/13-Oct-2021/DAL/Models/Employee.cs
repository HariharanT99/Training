using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            Applicants = new HashSet<Applicant>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }

        [InverseProperty(nameof(Applicant.CreatedByNavigation))]
        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}

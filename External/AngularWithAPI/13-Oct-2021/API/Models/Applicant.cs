using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("Applicant")]
    public partial class Applicant
    {
        public Applicant()
        {
            Interviews = new HashSet<Interview>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string LastEmployer { get; set; }
        [StringLength(250)]
        public string LastDesignation { get; set; }
        [StringLength(200)]
        public string AppliedFor { get; set; }
        [StringLength(150)]
        public string ReferedBy { get; set; }
        [StringLength(500)]
        public string MedicalStatus { get; set; }
        public int? NoticePeriod { get; set; }
        [StringLength(200)]
        public string Resume { get; set; }
        public int? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column("ModifiedBY")]
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(CreatedBy))]
        [InverseProperty(nameof(Employee.Applicants))]
        public virtual Employee CreatedByNavigation { get; set; }
        [InverseProperty(nameof(Interview.Applicant))]
        public virtual ICollection<Interview> Interviews { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    [Table("Interview")]
    public partial class Interview
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ApplicantID")]
        public int? ApplicantId { get; set; }
        [Column("AssessmentID")]
        public int? AssessmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Result { get; set; }

        [ForeignKey(nameof(ApplicantId))]
        [InverseProperty("Interviews")]
        public virtual Applicant Applicant { get; set; }
        [ForeignKey(nameof(AssessmentId))]
        [InverseProperty("Interviews")]
        public virtual Assessment Assessment { get; set; }
    }
}

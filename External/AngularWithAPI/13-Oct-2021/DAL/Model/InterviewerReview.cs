using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Model
{
    [Keyless]
    [Table("InterviewerReview")]
    public partial class InterviewerReview
    {
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }
        [Column("InterviewID")]
        public int? InterviewId { get; set; }
        [StringLength(500)]
        public string Pros { get; set; }
        [StringLength(500)]
        public string Cons { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [Column("SkillID")]
        public int? SkillId { get; set; }
        [Column("RatingID")]
        public int? RatingId { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(InterviewId))]
        public virtual Interview Interview { get; set; }
        [ForeignKey(nameof(RatingId))]
        public virtual Rating Rating { get; set; }
        [ForeignKey(nameof(SkillId))]
        public virtual Skill Skill { get; set; }
    }
}

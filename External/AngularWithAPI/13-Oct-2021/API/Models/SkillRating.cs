using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Keyless]
    [Table("SkillRating")]
    public partial class SkillRating
    {
        [Column("InterviewID")]
        public int? InterviewId { get; set; }
        [Column("SkillID")]
        public int? SkillId { get; set; }
        [Column("RatingID")]
        public int? RatingId { get; set; }

        [ForeignKey(nameof(InterviewId))]
        public virtual Interview Interview { get; set; }
        [ForeignKey(nameof(RatingId))]
        public virtual Rating Rating { get; set; }
        [ForeignKey(nameof(SkillId))]
        public virtual Skill Skill { get; set; }
    }
}

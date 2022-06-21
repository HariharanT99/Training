using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("Skill")]
    public partial class Skill
    {
        public Skill()
        {
            InverseParent = new HashSet<Skill>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [Column("ParentID")]
        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(Skill.InverseParent))]
        public virtual Skill Parent { get; set; }
        [InverseProperty(nameof(Skill.Parent))]
        public virtual ICollection<Skill> InverseParent { get; set; }
    }
}

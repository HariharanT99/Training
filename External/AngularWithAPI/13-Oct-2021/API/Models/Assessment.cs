using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace API.Models
{
    [Table("Assessment")]
    public partial class Assessment
    {
        public Assessment()
        {
            Interviews = new HashSet<Interview>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }

        [InverseProperty(nameof(Interview.Assessment))]
        public virtual ICollection<Interview> Interviews { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Model.Model
{
    [Keyless]
    [Table("Employee_Roll")]
    public partial class EmployeeRoll
    {
        [Column("RollID")]
        public int? RollId { get; set; }
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(RollId))]
        public virtual Roll Roll { get; set; }
    }
}

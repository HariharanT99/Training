using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        [Required(ErrorMessage ="Name of the skill is required")]
        public string SkillName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

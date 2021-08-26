using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [StringLength(20, ErrorMessage = "Name can not exceed 20 characters")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "The Department ID is required")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]

        [Required(ErrorMessage = "The Hire Date is required")]
        public DateTime HireDate { get; set; }

        public bool StatusActive { get; set; }
    }
}

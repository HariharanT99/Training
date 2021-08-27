using EmployeeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.ViewModel
{
    public class EmployeeView
    {
        public List<Employee> Emp { get; set; }
        public List<Department> Dept { get; set; }
    }
}

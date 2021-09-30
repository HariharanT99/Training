using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Model
{
    public partial class Employee
    {
        public Employee()
        {
            Admins = new HashSet<Admin>();
            TimeEntries = new HashSet<TimeEntry>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
    }
}

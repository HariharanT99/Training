using System;
using System.Collections.Generic;

#nullable disable

namespace Presentation.Models
{
    public partial class Entry
    {
        public Entry()
        {
            Breaks = new HashSet<Break>();
        }

        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }

        public virtual AspNetUser Employee { get; set; }
        public virtual ICollection<Break> Breaks { get; set; }
    }
}

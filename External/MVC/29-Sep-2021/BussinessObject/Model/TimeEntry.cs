using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Model
{
    public partial class TimeEntry
    {
        public int TeId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public DateTime? BreakIn { get; set; }
        public DateTime? BreakOut { get; set; }
        public TimeSpan? TotalBreak { get; set; }
        public TimeSpan? TotalWorking { get; set; }

        public virtual Employee Employee { get; set; }
    }
}

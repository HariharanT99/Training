using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataViewModel
{
    public class AdminDashboardViewModel
    {
        public string Name { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public float? TotalBreakTime { get; set; }

        public float? TotalWorkingTime { get; set; }
    }
}

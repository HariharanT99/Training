using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataViewModel
{
    public class EntryInptViewModel
    {

        public int Id { get; set; }

        public string EmployeeId { get; set; }

        public int Month { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        public TimeSpan? InTime { get; set; }


        public TimeSpan? OutTime { get; set; }

        public float? TotalWorkingTime { get; set; }

        public TimeSpan? BreakIn { get; set; }

        public TimeSpan? BreakOut { get; set; }

        public float? TotalBreakTime { get; set; }

    }
}

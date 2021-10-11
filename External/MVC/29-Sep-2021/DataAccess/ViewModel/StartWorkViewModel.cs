using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class StartWorkViewModel
    {
        public string EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public List<BreakViewModel> BreakList { get; set; } = new List<BreakViewModel>();
    }
}

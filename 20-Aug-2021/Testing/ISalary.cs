using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    interface ISalary
    {
        double salary { get; set; }
        double IncreasePay(double percent);

    }
}

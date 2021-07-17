using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtMethod
    {

        //Extension Method
        public static TimeSpan GetDueDays(this Insurance IObj)
        {
            var dueDate = IObj.DueDate;
            TimeSpan DaysLeft = dueDate - DateTime.Now;
            return DaysLeft;
        }
    }
}

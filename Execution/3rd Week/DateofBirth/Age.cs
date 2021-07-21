using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateofBirth
{
    class Age
    {
        public static void Calculate(DateTime dateofBirth)
        {
            TimeSpan difference = DateTime.Now - dateofBirth;
            DateTime age = DateTime.MinValue.AddDays(difference.Days);
            Console.WriteLine($"You are {Age.Years - 1}");
        }
    }
}

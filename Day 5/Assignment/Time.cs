using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    class Time
    {
        public static void TimeCheck()
        {
            // Try to convert the time - If it is successfully converted, It prints "Valid Time" or It prints "Invalid Time"
            Console.WriteLine("Enter the time in 24 hours format [hh:mm]");
            var Time = Console.ReadLine();
            var Result = DateTime.TryParse(Time, out DateTime result);
            if (Result == true)
                Console.WriteLine($"{Time} is a Valid Time");
            else
                Console.WriteLine($"{Time} is a Invalid Time");
        }
    }
}

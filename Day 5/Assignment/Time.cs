using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Time
    {
        public static void TimeCheck()
        {

            try
            {
                Console.WriteLine("Enter the time in 24 hours format [hh:mm]");
                var Time = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Valid Time");
            }
            catch
            {
                Console.WriteLine("Invalid Time");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    class CountryState
    {
        enum Value { India, Kerala };
        public static bool Country()
        {
            //User Input
            Console.WriteLine("Enter the country name");
            var Country = Console.ReadLine();
            Console.WriteLine("Enter the State name");
            var State = Console.ReadLine();

            //Case Insensitive
            var CountryCode = ((Country == "India") || (Country == "INDIA")) ? 0 : 1;
            var StateCode = ((State == "kerala") || (State == "KERALA")) ? 0 : 1;

            //Conditions
            if (CountryCode == (int)Value.India)
            {
                var Result = (StateCode == (int)Value.Kerala) ? true : false;
                return Result;
            }
            else
                return false;

        }
    }
}

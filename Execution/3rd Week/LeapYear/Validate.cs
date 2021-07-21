using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Validate
    {
        public static int validateYear(string year)
        {
            int _year;
            var result = int.TryParse(year, out _year);
            if (year.Length == 4 && result == true)
                return _year;
            else
                throw new InvalidYearException
                    (
                    "\nEntered year is invalid , " +
                    "\nYear must contain 4 digit numeric characters only " +
                    "\nTry again with valid input " +
                    "\nPress any key to Exit"
                    );
        }
    }

    class InvalidYearException : Exception
    {
        public InvalidYearException(string message) : base(message)
        {

        }
    }
}

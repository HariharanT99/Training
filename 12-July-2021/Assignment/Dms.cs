using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    /*
    class Dms
    {
        public double Number = 156.742;
        public static void Degrees(double number)
        {
            double Degree = Math.Floor(number);
            double minutes = Degree - number;
            double Min = Minutes((float)minutes);
            Math.Abs(minutes);
            Console.WriteLine(Sec);
        }
        public static float Minutes(float number)
        {
            double Minute = 60 * number;
            double Minutes = Math.Floor(Minute);
            double seconds = Minutes - Minute;
            int Sec = Seconds(seconds);
            return Math.Abs((float)seconds);
        }
        public static int Seconds(double number)
        {
            double Seconds = Math.Round(60 * number);
            return (int)Seconds;
        }
    }
    */

    class Dms
    {
        public static int Degree(double number)
        {
            return (int)number;
        }

        public static void Minutes(double number)
        {
            double Degree = Dms.Degree(number);
            double minutes = number - Degree;
            double Min = minutes * 60;
            int Minutes = (int)Min;
            double seconds = Min - Minutes;
            int Seconds = Dms.Seconds(seconds);
            Console.WriteLine($"Decimal degrees {number} converts to {Degree} degrees, {Minutes} minutes and {Seconds} seconds, or {Degree}° {Minutes}' { Seconds}\".");
        }
        public static int Seconds(double number)
        {
            double Seconds = Math.Round(60 * number);
            return (int)Seconds;
        }

    }
    
}

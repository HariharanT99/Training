using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tThis Applicaton helps you to find the entered year is Leap Year or Not");
            Console.WriteLine("Enter the Year");
            var inputYear = Console.ReadLine();         //Getting input
            int Year; 

            // Validate user enter valid year or not
            try
            {
                var year = Validate.validateYear(inputYear);
                Year = year;
            }
            catch (Exception message)
            {
                Year = 0;
                Console.WriteLine(message.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }

            // Check for Leap Year
            var result = LeapYear.Validate(Year);

            if (result == true)
                Console.WriteLine($"{Year} is a Leap Year");
            else
                Console.WriteLine($"{Year} is not a Leap Year");

            Console.WriteLine("\nPress any key to Exit");
            Console.ReadLine();
        }
    }
}

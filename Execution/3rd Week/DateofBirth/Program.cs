using System;

namespace DateofBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Date of Birth in the given format eg.[yyyy/MM/dd]");
            string inputDate = Console.ReadLine();
            DateTime dateofBirth;
            try
            {
                DateTime.TryParse(inputDate, out dateofBirth);
            }
            catch
            {
                Console.WriteLine("Invalid date Please enter the date in the mentioned format and Try Again \nPress any key to Exit");
                Console.ReadLine();
                Environment.Exit(0);
            }

        }
    }
}

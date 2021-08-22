using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Enter the length of the side 1");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the side 2");
            float side2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the side 3");
            float side3 = float.Parse(Console.ReadLine());*/

            Logic Obj = new Logic();
            Console.WriteLine(Obj.ConverToCelsius(10));

            Employee Obj1 = new Employee()
            {
                employeeName = "Hari",
            };
        }
    }
}

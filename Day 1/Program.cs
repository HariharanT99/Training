using System;

namespace assign
{
    class Program
    {

        public static void name()
        {
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Welcome " + firstName + " " + lastName);
            Console.WriteLine("Welcome {0} {1}" , firstName , lastName);
        }

        public static void sum()
        {
            Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of a and b is " + (a+b));
        }

        public static void divide()
        {
            Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of a and b is " + (a/b));
        }

    }
    class Mainclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Name is " + args[0]);
            Console.WriteLine("Last Name is " + args[1]);
            Console.ReadLine();
            assign.Program.name();
            assign.Program.sum();
            assign.Program.divide();
        }
    }
}
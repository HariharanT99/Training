using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci Series
            int n1 = 0;
            int n2 = 1;
            int count = 0;
            int number;
            Console.WriteLine("Enter the number of elements");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                number = num;
            }
            catch
            {
                number = 0;
                Console.WriteLine("It Accepts only number");
                Environment.Exit(0);
            }
            Fibonacci.FibonacciSeries(n1, n2, count, number);


            //String Reverse
            Console.WriteLine("Enter the String");
            string text = Console.ReadLine();
            int length = text.Length;

            Reverse.ReverseString(length, text);
        }
    }
}

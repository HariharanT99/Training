using System;

namespace Recursion
{
    class Fibonacci
    {
        public int n1 = 0;
        public int n2 = 1;
        public static void FibonacciSeries(int n1, int n2,int count,int number)
        {
            if (count < number)
            {
                Console.Write($"{n1} ");
                FibonacciSeries(n2, n1 + n2, count + 1, number); //Recursive Function
            }
        }
    }
}
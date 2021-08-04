using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int size = 0;
            try
            {
                size = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter only numbers and try again");
                Environment.Exit(0);
                Console.ReadLine();
            }
            int[] myArr = new int[size];
            int[] result =new int[myArr.Length];
            
            Console.WriteLine("Enter the elements");
            for(int i = 0; i < size; i++)
            {
                try
                {
                    int ele = Convert.ToInt32(Console.ReadLine());
                    myArr[i] = ele;
                }
                catch
                {
                    Console.WriteLine("Enter only numbers and try again");
                    Environment.Exit(0);
                    Console.ReadLine();
                }
            }

            int sum = myArr.Sum();

            for(int i = 0; i < myArr.Length; i++)
            {
                int res = sum - myArr[i];
                result[i] = res;
            }

            Console.WriteLine("\nResult elements");
            foreach (var item in result)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}

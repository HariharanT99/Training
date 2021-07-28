using System;

namespace SecondLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 1, 4, 5, 10, 12, 31 };

            int[] sortedArray = Sort.SortArr(myArray);

            Console.WriteLine($"The second largest number is {sortedArray[1]}");
        }
    }
}

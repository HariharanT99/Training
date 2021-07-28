using System;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 4, 3, 5 };
            int key = 4;

            int[] sortedArray = Sort.SortArr(myArray);

            int index = Search(sortedArray, key);
            
            if (index == -1)
                Console.WriteLine("Key not present");
            else
                Console.WriteLine($"{key} is present");
        }

        public static int Search(int[] arr, int key)
        {
            int midValue = arr[0] + arr[arr.Length - 1] / 2;
            if (midValue == key)
                return key;

            else if (key < midValue)
            {
                for (int i = 0; i < midValue; i++)
                {
                    if (arr[i] == key)
                    {
                        return i;
                    }
                }
            }

            else if (key > midValue)
            {
                for (int i = midValue; i < arr.Length; i++)
                {
                    if (arr[i] == key)
                    {
                        return i;
                    }
                }
            }

            return -1;

        }
    }
}

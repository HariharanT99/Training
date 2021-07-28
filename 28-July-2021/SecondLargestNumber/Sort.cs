using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNumber
{
    class Sort
    {
        public static int[] SortArr(int[] myArray)
        {
            int[] sortedArray = myArray;
            int temp;
            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                for (int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] < sortedArray[j])
                    {
                        temp = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }

            return sortedArray;
        }
    }
}

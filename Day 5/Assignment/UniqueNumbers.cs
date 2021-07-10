using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class UniqueNumbers
    {
        public static void Unique()
        {
            var Numbers = new List<int>();
            var Duplicates = new List<int>();
            var UniqueList = new List<int>();

            // Get the input from user, till the user enter 'Quit'
            while (true)
            {
                Console.WriteLine("Enter the number or Enter 'Quit'");
                var Number = Console.ReadLine();
                if (Number == "Quit")
                    break;
                else
                    Numbers.Add(Int32.Parse(Number));
            }
            /*
            foreach(var i in Numbers)
            {
                var index = Numbers.BinarySearch(i); ---> This BinarySearch method gives the Last occurance of the element. Is there any way to get the first occurence?

                for (var j = index+1; j <= Numbers.Count; j++ )
                {
                    if (Numbers[i].Equals(Numbers[j]))
                    {
                        Duplicates.Add(Numbers[i]);
                    }
                }
            }*/

            //Seperate Duplicate values to another list
            for (var i = 0; i < Numbers.Count; i++)
            {
                for(var j = i+1; j < Numbers.Count; j++)
                {
                    if (Numbers[i].Equals(Numbers[j]))
                    {
                        Duplicates.Add(Numbers[i]);
                    }
                }
            }

            // Add unique values to UniqueList
            foreach(var n in Numbers)
            {
                if (Duplicates.Contains(n))
                    continue;
                else
                    UniqueList.Add(n);
            }

           
            Console.WriteLine("Unique Values are");
            foreach (var element in UniqueList)
            {
                Console.WriteLine(element);
            }
        }
    }
}

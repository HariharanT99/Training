using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    class Duplicate
    {
        public static void ArrayInt()
        {
            //Getting the length of the array
            Console.WriteLine("Enter the length of the array");
            int ArrayLength = Convert.ToInt32(Console.ReadLine());

            //Empty array
            var myArray = new ArrayList();
            var myNewArray = new ArrayList();

            //Get values from the user
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Enter the Element of the array");
                int ArrayElement = Convert.ToInt32(Console.ReadLine());
                myArray.Add(ArrayElement);
            }

            //Comparision for duplicate values
            foreach(var n in myArray)
            {
                int i = myArray.IndexOf(n)+1;
                while (i < ArrayLength)
                {
                    if ((int)n == (int)myArray[i])
                    {
                        myNewArray.Add(n);
                    }
                    i++;
                }
            }
            Console.WriteLine("Duplicate Values are");

            //Print the Duplicate values
            foreach(var element in myNewArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}

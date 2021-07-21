using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> genericObj1 = new MyDictionary<string, int>();
            genericObj1.Add("Hari", 12);
            genericObj1.Add("Arun", 20);
            genericObj1.Add("Raj", 25);
            genericObj1.Add("Ramu", 30);

            Console.WriteLine("\nAdded List");
            genericObj1.Sort();                // Sorting and Printing

            genericObj1.Remove("Raj");      //Remove Element

            Console.WriteLine("\nList after removing one element");
            genericObj1.Sort();



            MyDictionary<int, string> genericObj2 = new MyDictionary<int, string>();
            genericObj2.Add(1, "Ram");
            genericObj2.Add(40, "Vinoth");
            genericObj2.Add(10, "Andy");
            genericObj2.Add(5, "Hannah");

            Console.WriteLine("\nAdded List");
            genericObj2.Sort();                 //Sorting and Printing

            genericObj2.Remove(40);         //Remove One Element

            Console.WriteLine("\nList after removing one element");
            genericObj2.Sort();

        }
    }
}

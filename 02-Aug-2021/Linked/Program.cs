using System;

namespace Linked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the List before adding elements");
            LList lListObj = new LList();
            lListObj.PrintNodes();
            Console.WriteLine();

            Console.WriteLine("Print the List after adding elements");
            lListObj.AddLast(10);
            lListObj.AddLast(40);
            lListObj.AddLast(20);
            lListObj.PrintNodes();
            Console.WriteLine();

            Console.WriteLine("Print the List with Data added at First Index");
            lListObj.AddFirst(32);
            lListObj.PrintNodes();
            Console.WriteLine();

            Console.WriteLine("Printing the List with Data removed at First Index");
            lListObj.RemoveFromStart();
            lListObj.PrintNodes();
            Console.ReadLine();
        }
    }
}

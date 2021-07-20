using System;
using Domain;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string subText = "sample";
                var result = MyClass.SearchOccurrence(subText);
                Console.WriteLine($"{subText} is Found");
            }
            catch (TextNotFoundException msg)
            {
                Console.WriteLine(msg.Message);
            }
        }
    }
}

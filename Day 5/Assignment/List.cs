using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class List
    {
        public static void Likes()
        {
            var Names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter the name or Press Enter to exit");
                var Name = Console.ReadLine();
                if (String.IsNullOrEmpty(Name) == true)
                    break;
                Names.Add(Name);
            }
            var Length = Names.Count;
            if (Names.Count > 2)
                Console.WriteLine($"{Names[0]}, {Names[1]} and {Names.Count - 2} people like your Post");
            else
            {
                switch (Length)
                {
                    case 1:
                        Console.WriteLine($"{Names[0]} likes your Post");
                        break;
                    case 2:
                        Console.WriteLine($"{Names[0]} and {Names[1]} likes your Post");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }

        }
    }
}

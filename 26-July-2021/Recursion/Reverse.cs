using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Reverse
    {
        public static void ReverseString(int length, string text)
        {
            if (length != 0)
            {
                Console.Write($"{text[length-1]}");
                ReverseString(length - 1, text);     //Recursive Function
            }
        }
    }
}

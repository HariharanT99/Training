using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "HaaH";

            int length = text.Length;
            Char[] myStr = text.ToCharArray();

            foreach (var i in myStr)
            {
                myStr[length-1] = i;
                length--;
            }

            Char[] str = text.ToCharArray();

            if (str.Equals(myStr))
                Console.WriteLine($"{text} is a palindrome");
            else
                Console.WriteLine($"{text} is not a palindrome");
        }

    }
}

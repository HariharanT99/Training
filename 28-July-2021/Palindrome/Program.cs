using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text,str = "";

            text = "HaaH";
            int length = text.Length;

            for (int i = text.Length-1; i >= 0; i--)
            {
                str += text[i].ToString();
            }

            if (str.Equals(text))
                Console.WriteLine($"{text} is a palindrome");
            else
                Console.WriteLine($"{text} is not a palindrome");
        }

    }
}

using System;
using System.Text;

namespace Domain
{
    public class MyClass
    {
        public static string SearchOccurrence(string subText)
        {
            StringBuilder Text = new StringBuilder("This is my sample text occurance");
            if (Text.ToString().Contains(subText))
            {
                return "Found";
            }
            else
            {
                throw new TextNotFoundException("Sub Text Not Found");
            } 
        }
    }

    public class TextNotFoundException : Exception
    {
        public TextNotFoundException(string message) : base(message)
        {
        }
    }
}

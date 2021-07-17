using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MyBaseClass
    {
        public void WriteNum()
        {
            int Number = 10;
            Console.WriteLine($"The number is {Number}");
        }

        public virtual void WriteStr()
        {
            string String = "Hello";
            Console.WriteLine($"The string is {String}");
        }
    }
}

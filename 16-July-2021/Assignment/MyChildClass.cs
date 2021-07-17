using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MyChildClass : MyBaseClass
    {
        public new void WriteNum()
        {
            int NewNumber = 20;
            Console.WriteLine($"The new number is {NewNumber}");
        }
        public override void WriteStr()
        {
            string NewString = "Hello World!";
            Console.WriteLine($"The new string is {NewString}");
        }
    }
}

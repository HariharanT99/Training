using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class StringManipulation
    {

        // Replace method
        public void ReplaceSpace(object obj, StringArgs myStrArgs)
        {
            Console.WriteLine("\nReplace Space by underscore\n");

            var str = myStrArgs.MyFirstString.Replace(' ', '_');
            Console.WriteLine(str);
        }

        //Reverse Method
        public void Reverse(object obj, StringArgs myStrArgs)
        {
            Console.WriteLine("\n\nReverse the string\n");

            char[] chars = new char[myStrArgs.MyFirstString.Length];
            for (int i = 0, j = myStrArgs.MyFirstString.Length - 1; i <= j; i++, j--)
            {
                chars[i] = myStrArgs.MyFirstString[j];
                chars[j] = myStrArgs.MyFirstString[i];
            }

            foreach (var i in chars)
            {
                Console.Write(i);
            }
        }

        //Join Method
        public void StringJoin(object obj, StringArgs myStrArgs)
        {
            Console.WriteLine("\n\nJoin String\n");

            var strJoin = myStrArgs.MyFirstString + myStrArgs.MySecondString;
            Console.WriteLine(strJoin);
        }


        //Occurrence method
        public void Occurrence(object obj, StringArgs myStrArgs)
        {
            Console.WriteLine("\n\nFind the Occurance\n");

            int count = 0;
            int index;
            var myStringList = myStrArgs.MyFirstString.ToCharArray();

            if (myStrArgs.MyFirstString.Contains(myStrArgs.MyChar))
            {
                index = myStrArgs.MyFirstString.IndexOf(myStrArgs.MyChar);
                Console.WriteLine($"Char: {myStrArgs.MyChar},Position: {index}");
            }

            foreach (var c in myStringList)
            {
                if (c == myStrArgs.MyChar)
                    count += 1;
                else
                    continue;
            }
            Console.WriteLine($"Char: {myStrArgs.MyChar}, Occurences: {count}");
        }

    }
}

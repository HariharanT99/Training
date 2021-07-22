using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulation assignObj = new StringManipulation();

            assignObj.MyString = "This is my demo string";
            assignObj.AddString = "My second demo";
            assignObj.CharOccurence = 's';


            // Adding methods to delegate
            Console.WriteLine("\nReplace Space by underscore\n");
            StringManipulation.StringDelegate stringDelegate = assignObj.ReplaceSpace;

            Console.WriteLine("\n\nReverse the string\n");
            stringDelegate += assignObj.Reverse;

            Console.WriteLine("\n\nJoin String\n");
            stringDelegate += assignObj.StringJoin;

            Console.WriteLine("\n\nFind the Occurance\n");
            stringDelegate += assignObj.Occurrence;


            assignObj.StringProcess(stringDelegate);
        }
    }
}

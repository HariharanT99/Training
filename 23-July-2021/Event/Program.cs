using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Process processObj = new Process();

            StringManipulation manipulateObj = new StringManipulation();

            // Adding methods to Event
            processObj.ManipulateString += manipulateObj.ReplaceSpace;

            processObj.ManipulateString += manipulateObj.Reverse;

            processObj.ManipulateString += manipulateObj.Occurrence;

            processObj.ManipulateString += manipulateObj.StringJoin;

            processObj.StringProcess();
        }
    }
}

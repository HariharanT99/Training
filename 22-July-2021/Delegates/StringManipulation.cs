using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class StringManipulation
    {
        public delegate void StringDelegate();          //Deligate

        private string _myString;
        private string _addString;
        private char _charOccurence;
        public string MyString 
        { 
            set { this._myString = value; } 
        }

        public string AddString 
        { 
            set { this._addString = value; }
        }

        public char CharOccurence 
        {  
            set { this._charOccurence = value; }
        }

        public void ReplaceSpace()
        {
            var str = _myString.Replace(' ', '_');
            Console.WriteLine(str);
        }

        public void Reverse()
        {
            char[] chars = new char[_myString.Length];
            for (int i = 0, j = _myString.Length - 1; i <= j; i++, j-- )
            {
                chars[i] = _myString[j];
                chars[j] = _myString[i];
            }

            foreach (var i in chars)
            {
                Console.Write(i);
            }
        }

        public void StringJoin()
        {
            var strJoin = _myString + _addString;
            Console.WriteLine(strJoin);
        }

        public void Occurrence()
        {
            int count = 0;
            int index;
            var myStringList = _myString.ToCharArray();

            if (_myString.Contains(_charOccurence))
            {
                index = _myString.IndexOf(_charOccurence);
                Console.WriteLine($"Char: {_charOccurence},Position: {index}");
            }

            foreach (var c in myStringList)
            {
                if (c == _charOccurence)
                    count += 1;
                else
                    continue;
            }
            Console.WriteLine($"Char: {_charOccurence}, Occurences: {count}");
        }
        public void StringProcess(StringDelegate stringDelegate)                    //Method for invoke delegate
        {
            stringDelegate();
        }
    }
}

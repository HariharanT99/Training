using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class MyDictionary<Key, Value>
    {
        private Dictionary<Key, Value> _myDictionary = new Dictionary<Key, Value>();

        public void Add(Key key, Value value)         //Add method
        {
            _myDictionary.Add(key, value);
        }

        public void Remove(Key key)                  //Remove method
        {
            _myDictionary.Remove(key);
        }

        public void Sort()                          //Sort method
        {
            var keyList = _myDictionary.Keys.ToList();
            keyList.Sort();

            foreach (var key in keyList)
            {
                Console.WriteLine($"{key} : {_myDictionary[key]}");
            }
        }
    }
}

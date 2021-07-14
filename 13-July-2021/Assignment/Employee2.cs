using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Employee2
    {
        Hashtable EmployeeDetails = new Hashtable(); 
        public int Id { get; set; }
        public string Name { get; set; }

        public int this[int id]   //Indexers --> having issues on calling indexers in main method
        {
            set
            {
                EmployeeDetails[id] = Name;
            }
        }
        public void Print()
        {

            foreach (DictionaryEntry i in EmployeeDetails)
            {
                Console.WriteLine($"Id:{i.Key}, Name: {i.Value}");
            }
        }
    }
}

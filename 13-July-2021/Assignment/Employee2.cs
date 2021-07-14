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

        public DictionaryEntry this[int id]   //Indexers --> having issues on calling indexers in main method
        {
            get
            {
                foreach (DictionaryEntry i in EmployeeDetails)
                {
                    return i;
                }
                return (DictionaryEntry)EmployeeDetails[0];
            }
            set
            {
                EmployeeDetails[id] = Name;
            }
        }
    }
}

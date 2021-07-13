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

        public object[] this[int id, string name]   //Indexers --> having issues on calling indexers in main method
        {
            set
            {
                EmployeeDetails.Add(id, name);
            }
        }
    }
}

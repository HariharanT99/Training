using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Employee
    {
        private double _salary;
        public Employee(double salary)     //Constructor
        {
            this._salary = salary;
        }

        
        public double Salary 
        {
            get { return _salary; }
        }

        //Increment salary by 10%
        private double IncreasePay()
        {
            _salary += (_salary* 10) / 100;
            return _salary;

        }

        //Acess increment by promote method
        public void Promote(bool value)
        {
            if (value == true)
            {
                var salary = IncreasePay();
                _salary = salary;
            }
        }

        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }
    }
}

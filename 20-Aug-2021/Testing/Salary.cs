using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Salary : ISalary
    {
        private double _salary;
        private double _finalSalary;
        

        public double salary 
        {
            get => _salary;                
            set => _salary = value;  
        }
        public double IncreasePay(double percent)
        {
            var salary = _salary * (percent / 100);

            _finalSalary = salary + _salary;
            return _finalSalary;
        }
    }
}

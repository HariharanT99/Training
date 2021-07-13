using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student
    {
        private DateTime _dateofBirth;
        public Student(DateTime dob) 
        {
            this._dateofBirth = dob;
        }
        public DateTime DateofBirth 
        {
            get { return DateofBirth; } 
        }


        //Age Calculation
        public int Age
        {
            get
            {
                int dob = _dateofBirth.Year;
                int now = DateTime.Now.Year;
                int age = now - dob;
                return age;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

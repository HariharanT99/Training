using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee salary
            Console.WriteLine("Enter the Salary of the Employee");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Employee Obj = new Employee(Salary);
            Console.WriteLine("Enter the Id of the Employee");
            Obj.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of the Employee");
            Obj.Name = Console.ReadLine();
            Console.WriteLine("Enter the Destination of the Employee");
            Obj.Designation = Console.ReadLine();
            Console.WriteLine("Enter true, If the salary hike for this Employee else Enter false");
            Obj.Promote(Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine($"Employee: \n Id: {Obj.EmployeeId} \n Name: {Obj.Name} \n Designation: {Obj.Designation} \n Salary: {Obj.Salary}");


            //HashObject
            Employee2 HashObject = new Employee2();
            HashObject.Id = 1;
            HashObject.Name = "Hari;";
            HashObject.Id = 2;
            HashObject.Name = "Haran;";
           // HashObject[0, "Hari"] = (1, "Hari");
            

            //Student Class
            DateTime DOB = new DateTime(1999, 03, 26);
            Student StudentObject = new Student(DOB);
            StudentObject.Id = 1;
            StudentObject.Name = "Hari";
            Console.WriteLine($"Student Id: {StudentObject.Id} \n Name: {StudentObject.Name} \n Age: {StudentObject.Age}");
            
        }
    }
}

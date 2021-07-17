using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager access
            Console.WriteLine("These are accessible by Manager");
            Manager ManagerObj = new Manager();
            ManagerObj.Access();

            Console.WriteLine("\n\n\n");

            //Employee access
            Console.WriteLine("These are accessible by Employee");
            Employee EmployeeObj = new Employee();
            EmployeeObj.Access();
        }
    }
}

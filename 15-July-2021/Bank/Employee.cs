using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Employee
    {

        public void Access()
        {
            
            //CustomersInfo();
            //CustomersTransactionDetails();
            BankInfo.CustomersAccountDetails(); // Customer Account Details are accessed by both manager and employee, It is a Internal Method
            EmployeeDetails();                  // Employee Details are accessed by both manager and employee, It is a Internal Method
        }
        internal static void EmployeeDetails() // Accessed by Same assembly, Which means it is able to accessed br both Employee and manager
        {
            Console.WriteLine("Details of the bank employees");
        }

    }
}

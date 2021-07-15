using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Manager : BankInfo
    {
        public void Access()
        {
            Meeting = new DateTime(2021, 07, 23); //Meeting only set by manager, It is a Protected property

            CustomersAccountDetails();   // Customer Account Details are accessed by both manager and employee, It is a Internal Method
            BankImportantDetails();      // Bank Important Details are only accessed by manager , It is a Protected Method
            Employee.EmployeeDetails();  // Employee Details are accessed by both manager and employee, It is a Internal Method
            ManagerDetails();            // Manager Details are only accessed by manger, It is a private method
        }
        private static void ManagerDetails()   //Only accessed by manager
        {
            Console.WriteLine("Manager Details");
        }
    }
}

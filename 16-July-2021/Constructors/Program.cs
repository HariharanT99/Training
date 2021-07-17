using System;
using System.Text.RegularExpressions;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting input for the type of account
            Console.WriteLine("Enter the type of account you want to create [ Enter 's' for salary Account or Enter 'ds' for Demat Salaer Account");
            var type = Console.ReadLine();

            //Salary Account
            if (type == "s")
            {
                Console.WriteLine("Enter the following credentials without any mistake");
                Console.WriteLine("Enter the Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Balance");
                double balance = Convert.ToDouble((Console.ReadLine()));
                SalaryAccount SalaryObj = new SalaryAccount(id, name, balance);
                SalaryObj.SalaryAccountStatus();
            }

            //Salary-Demat account
            else if (type == "ds")
            {

                Console.WriteLine("Enter the following credentials without any mistake");
                Console.WriteLine("Enter the Id");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Balance");
                double balance = Convert.ToDouble((Console.ReadLine()));

                //Pan Number
                Console.WriteLine("Enter the Pan Number");
                string panNumber = Console.ReadLine();
                PanValidation panObj = new PanValidation();     //Validation Object
                panObj.Panvalidate = panNumber;                 // Pan validation
                string pan = panObj.Panvalidate;

                DematAccount dematObj = new DematAccount(id, name, balance, pan);
                dematObj.DematAccountStatus();
            }
        }
    }
}

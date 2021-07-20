using System;

namespace Interfaces
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
                int id;
                double balance;
                Console.WriteLine("Enter the following credentials");

                try
                {
                    Console.WriteLine("Enter the Id");
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    id = 0;
                    Console.WriteLine("Your Id is Invalid, Id must be in numeric characters.\nPlease Try again with valid Id");
                    Environment.Exit(0);
                }

                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();

                try
                {
                    Console.WriteLine("Enter the Balance");
                    balance = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    balance = 0;
                    Console.WriteLine("Account balance must be in numeric characters.\nPlease try agian with valid Input");
                    Environment.Exit(0);
                }

                Console.WriteLine("Enter 'Yes' If you want Demand Draft , otherwise 'No'");
                var dDStatus = Console.ReadLine();

                Console.WriteLine("Enter 'Yes' If you want to storage Locker, otherwise 'No'");
                var storageLocker = Console.ReadLine();

                SalaryAccount SalaryObj = new SalaryAccount(id, name, balance, dDStatus, storageLocker);
                SalaryObj.SalaryAccountStatus();
            }

            //Salary-Demat account
            else if (type == "ds")
            {
                int id;
                double balance;
                Console.WriteLine("Enter the following credentials");

                try
                {
                    Console.WriteLine("Enter the Id");
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    id = 0;
                    Console.WriteLine("Your Id is Invalid, Id must be in numeric characters.\nPlease Try again with valid Id");
                    Environment.Exit(0);
                }

                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();

                try
                {
                    Console.WriteLine("Enter the Balance");
                    balance = Convert.ToDouble((Console.ReadLine()));
                }
                catch
                {
                    balance = 0;
                    Console.WriteLine("Account balance must be in numeric characters.\nPlease try agian with valid Input");
                    Environment.Exit(0);
                }

                //Pan Number
                Console.WriteLine("Enter the Pan Number");
                string panNumber = Console.ReadLine();
                PanValidation panObj = new PanValidation();     //Validation Object
                panObj.Panvalidate = panNumber;                 // Pan validation
                string pan = panObj.Panvalidate;


                Console.WriteLine("Enter 'Yes' If you want Demand Draft , otherwise 'No'");
                var dDStatus = Console.ReadLine();

                Console.WriteLine("Enter 'Yes' If you want to storage Locker, otherwise 'No'");
                var storageLocker = Console.ReadLine();

                DematAccount dematObj = new DematAccount(id, name, balance, dDStatus, storageLocker, pan, storageLocker);
                dematObj.DematAccountStatus();
            }

            else
                Console.WriteLine("Invalid Input");

            Console.WriteLine("\nPress any key to Exit");
            Console.ReadLine();
        }
    }
}

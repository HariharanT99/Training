using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class DematAccount : SalaryAccount, IDematBenefits
    {
        private string _panNumber;
        private string _stockUpdates;
        public DematAccount(int id, string name, double salary, string dDStatus, string storageLocker, string panNumber, string stockUpdates) : base(id, name, salary, dDStatus, storageLocker)
        {
            this._panNumber = panNumber;
            this._stockUpdates = stockUpdates;
        }
        public void DematAccountStatus()
        {
            SalaryAccountStatus();
            Console.WriteLine($"\n\nDemat account created successfully.\nAccount information \n\t Pan Number: {_panNumber}");
            AvailFreeCreditScoreCheck();
            GetDailyStockUpdates();
        }

        public void AvailFreeCreditScoreCheck()
        {
            Console.WriteLine("\nCredit Score Added to your account");
        }
        public void GetDailyStockUpdates()
        {
            var updates = (_stockUpdates == "Yes") ? "You will get the daily Stock updates" : "You won't gat the stock updates";
            Console.WriteLine("\n" + updates);
        }
    }
}

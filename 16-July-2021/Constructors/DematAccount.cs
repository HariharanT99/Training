using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Constructors
{
    class DematAccount : SalaryAccount
    {
        private string _panNumber;
        public DematAccount(int id , string name, double salary, string panNumber) : base(id, name, salary)
        {
            this._panNumber = panNumber;
        }
        public void DematAccountStatus()
        {
            SalaryAccountStatus();
            Console.WriteLine($"\n\nDemat account created successfully.\nAccount information \n\t Pan Number: {_panNumber}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class SalaryAccount
    {
        private int _id;
        private string _name;
        private double _balance;
        public SalaryAccount(int id, string name, double balance)
        {
            this._id = id;
            this._name = name;
            this._balance = balance;
        }

        public void SalaryAccountStatus()
        {
            Console.WriteLine($"Salary account created successfully.\nAccount information \n\t Id: {_id} \n\t Name: {_name} \n\t Balance: {_balance}");
        }
    }
}

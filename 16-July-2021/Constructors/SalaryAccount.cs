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
            Console.WriteLine($"Salary account created successfully with the following information \n Id: {_id} \n Name: {_name} \n Balance: {_balance}");
        }
    }
}

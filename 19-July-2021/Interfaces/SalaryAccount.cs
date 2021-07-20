using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SalaryAccount : IBenefits
    {
        private int _id;
        private string _name;
        private double _balance;
        private string _dDStatus;
        private string _storageLocker;
        public SalaryAccount(int id, string name, double balance, string dDStatus, string storageLacker)
        {
            this._id = id;
            this._name = name;
            this._balance = balance;
            this._dDStatus = dDStatus;
            this._storageLocker = storageLacker;
        }

        public void SalaryAccountStatus()
        {
            Console.WriteLine($"Salary account created successfully.\nAccount information \n\t Id: {_id} \n\t Name: {_name} \n\t Balance: {_balance}");
            AvailFreeDemandDraft();
            AvailFreeLocker();
        }

        public void AvailFreeDemandDraft()
        {
            var ddStatus = (_dDStatus == "Yes") ? "Demand Draft will be provided in a weeks" : "You have not applied for the Demand Draft";
            Console.WriteLine("\n" + ddStatus);
        }

        public void AvailFreeLocker()
        {
            var lockerStatus = (_storageLocker == "Yes") ? "Locker available" : "Locker is not available";
            Console.WriteLine("\n" + lockerStatus);
        }

        public void AvaiFreeLocker()
        {
            throw new NotImplementedException();
        }
    }
}
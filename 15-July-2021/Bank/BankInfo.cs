using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankInfo
    {
        private DateTime _meeting;

        protected DateTime Meeting   
        {
            get
            {
                return _meeting;
            }
            set
            {
                this._meeting = Meeting;
            }
        }
        internal static void CustomersAccountDetails() // Accessed by Same assembly, Which means it is able to accessed br both Employee and manager
        {
            Console.WriteLine("Customers account details");
        }
        protected static void BankImportantDetails() // Accessed by only derived classes, So, Only Manager access this method.
        {
            Console.WriteLine("Bank's Important details");
        }
    }
}

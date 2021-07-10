using System;
using Assignment.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Duplicate.ArrayInt();
            Console.WriteLine(CountryState.Country());
            Image ImageObject = new Image();
            ImageObject.Frame();
            Customer CustomerObject = new Customer();
            CustomerObject.PlaceOrder();
            Customer.GetCustomerTimeZone();
        }
    }
}

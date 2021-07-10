using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    class Customer
    {
        //Properties
        public string CustomerName;
        public int CustomerId;

        //method
        public void PlaceOrder()
        {
            //Get Input from Customer 
            Console.WriteLine("Enter the Name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the Id");
            CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Order Placed Successfully");
        }

        //static method
        public static void GetCustomerTimeZone()
        {
            Console.WriteLine("Enter your time zone");
            var TimeZone = Console.ReadLine();
            Console.WriteLine(TimeZone);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Insurance
    {
        public DateTime DueDate { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public double AadharCardNumber { get; set; }

        public void PayPremium()
        {
            DateTime PayDate = DateTime.Now;
            DueDate = PayDate.AddDays(30);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurence
{
    class LifeInsurance
    {
        public int CustomerId { get; set; }
        public double PremiumAmount { get; set; }
        public String Nominee { get; set; }
        public DateTime MaturityDate { get; set; }
    }
}

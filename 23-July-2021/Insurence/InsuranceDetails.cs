using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurence
{
    class InsuranceDetails
    {
        public int InsuranceId { get; set; }
        public DateTime Validity { get; set; }
        public int CustomerId { get; set; }
        public int Age { get; set; }
        public bool MedicalInsurance { get; set; }
        public bool LifeInsurance { get; set; }



        /*
        class MedicalInsurance
        {
            public double PremiumAmount { get; set; }
            public int ListofAppointmentsCompleted { get; set; }
        }

        class LifeInsurance
        {
            public double PremiumAmount { get; set; }
            public String Nominee { get; set; }
            public DateTime Maturity { get; set; }
        }
        */
    }
}

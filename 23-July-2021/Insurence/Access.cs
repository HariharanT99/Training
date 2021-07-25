using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurence
{
    class Access
    {
        public  List<Customer> AddCustomer() 
        {
            List<Customer> customerList = new List<Customer>
            {
                new Customer { CustomerId = 1, Name = "Ram", Age = 46, BloodGroup="O+"},
                new Customer { CustomerId = 2, Name = "Ragu", Age = 60, BloodGroup="A+"},
                new Customer { CustomerId = 3, Name = "Sam", Age = 55, BloodGroup="B-"},
                new Customer { CustomerId = 4, Name = "Janu", Age = 69, BloodGroup="AB-"},
                new Customer { CustomerId = 5, Name = "Julie", Age = 39, BloodGroup="A+"}
            };
            return customerList;
        }


        public List<InsuranceDetails> AddInsurence()
        {
            List<InsuranceDetails> InsuranceList = new List<InsuranceDetails>()
            {
                new InsuranceDetails { InsuranceId =12, CustomerId = 1, Validity = new DateTime(2022/03/13), MedicalInsurance = true, LifeInsurance = true},
                new InsuranceDetails { InsuranceId =09, CustomerId = 3, Validity = new DateTime(2023/01/03), MedicalInsurance = false, LifeInsurance = true},
                new InsuranceDetails { InsuranceId =15, CustomerId = 5, Validity = new DateTime(2021/12/28), MedicalInsurance = false, LifeInsurance = false},
                new InsuranceDetails { InsuranceId =21, CustomerId = 2, Validity = new DateTime(2022/05/13), MedicalInsurance = true, LifeInsurance = false},
                new InsuranceDetails { InsuranceId =21, CustomerId = 4, Validity = new DateTime(2022/05/13), MedicalInsurance = false, LifeInsurance = true}
            };
            return InsuranceList;
        }

        public void Group()
        {
            MedicalInsurance[] medicalInsure =
            {
                new MedicalInsurance { CustomerId= 1, PremiumAmount= 120000, ListofAppointmentsCompleted = 3},
                new MedicalInsurance { CustomerId = 2, PremiumAmount = 140000, ListofAppointmentsCompleted = 3}
            };


            LifeInsurance[] lifeInsure =
            {
                new LifeInsurance { CustomerId= 1, Nominee = "David", MaturityDate = new DateTime(2021/07/27), PremiumAmount = 123000},
                new LifeInsurance { CustomerId= 3, Nominee = "Vinoth", MaturityDate = new DateTime(2021/09/17), PremiumAmount = 141000},
                new LifeInsurance { CustomerId= 4, Nominee = "Sakthi", MaturityDate = new DateTime(2021/10/06), PremiumAmount = 110000}
            };

            var customerList = AddCustomer();
            var insuranceList = AddInsurence();


            // Filter the customer by bloodgroup and age
            var bloodGroupList = customerList.Join(insuranceList, customer => customer.CustomerId, insure => insure.CustomerId, (customer, insure) =>
            new
            {
                customerId = customer.CustomerId,
                customerName = customer.Name,
                bloodGroup = customer.BloodGroup,
                medicalInsureStatus = insure.MedicalInsurance,
                age = customer.Age
            }).Where(blood => blood.bloodGroup == "A+").Where(age => age.age < 60);


            // Filter the customer by medical insurence and list of appoinments
            var result = from customer in bloodGroupList
                         join medical in medicalInsure on customer.customerId equals medical.CustomerId
                         where (medical.ListofAppointmentsCompleted < 3 || customer.medicalInsureStatus == true)
                         select new { customer.customerName };

            foreach (var customer in result)
            {
                Console.WriteLine($"List of customers whose having A+ blood group: \n\t {customer.customerName}");
            }
        }
    }
}

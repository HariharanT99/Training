using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation ValidationObj = new Validation();  //Object for Validaiton

            Console.WriteLine("Enter the Name");          // Name Validation
            string name = Console.ReadLine();
            ValidationObj.Name = name;
            var objName = ValidationObj.Name;

            Console.WriteLine("Enter the Email");          //Email Validation
            string email = Console.ReadLine();
            ValidationObj.Email = email;
            var objEmail = ValidationObj.Email;

            //Console.WriteLine("Enter the Date in the given format [yyyy/MM/dd]");
            //string dueDate = Console.ReadLine();
            //ValidationObj.PremiumDueDate = dueDate;

            Console.WriteLine("Enter the 12 digit Aadhar number");  //Aadhar Number Validaiton
            string aadharNumber = Console.ReadLine();
            ValidationObj.AadharNumber = aadharNumber;
            var objAadharNumber = ValidationObj.AadharNumber;

            Insurance InsuranceObj = new Insurance();  //Insurance Object
            InsuranceObj.PayPremium();                          
            var _dueDate=InsuranceObj.GetDueDays();  //Extension Object
            Console.WriteLine($"Find the details below\n Name: {objName} \n Email: {objEmail} \n AadharNumber: {objAadharNumber} \n {_dueDate.Days} days left for your due");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Validation
    {
        private string _name;
        private string _email;
        private string _aadharNumber;
        //private string _dueDate;

        //Name Validation
        public string Name 
        {
            get { return _name; }
            set
            {
                while (true)
                {
                    Regex NameRegex = new Regex(@"^[A-Za-z]\w{3,20}$");
                    Match match = NameRegex.Match(value);
                    if (match.Success)
                    {
                        this._name = value;
                        break;
                    }
                    Console.WriteLine("Invalid Name");
                    Console.WriteLine("Enter the valid Name");
                    string name = Console.ReadLine();
                    value = name;
                }
            }
        }

        //Email Validation
        public string Email
        {
            get { return _email; }
            set
            {
                while (true)
                {
                    Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = EmailRegex.Match(value);
                    if (match.Success)
                    {
                        this._email = value;
                        break;
                    }
                    Console.WriteLine("Invalid Email");
                    Console.WriteLine("Enter the valid Email");
                    string email = Console.ReadLine();
                    value = email;
                }
            }
        }

        //Aadahr Validation
        public string AadharNumber
        {
            get { return _aadharNumber; }
            set
            {
                while (true)
                {
                    Regex AadharRegex = new Regex(@"[^0]{1}\d{11}");
                    Match match = AadharRegex.Match(value);
                    if (match.Success)
                    {
                        this._aadharNumber = value;
                        break;
                    }
                    Console.WriteLine("Invalid AdharNumberr");
                    Console.WriteLine("Enter the valid AdharNumber");
                    string aadharNumber = Console.ReadLine();
                    value = aadharNumber;
                }
            }
        }


        //public string PremiumDueDate
        //{
        //    get { return _dueDate; }
        //    set
        //    {
        //        while (true)
        //        {
        //            bool validDate = DateTime.TryParse(value,out DateTime result);
        //            if (validDate == true)
        //            {
        //                this._dueDate = Convert.ToString(value);
        //                break;
        //            }
        //            Console.WriteLine("Invalid Date");
        //            Console.WriteLine("Enter the valid Date");
        //            string dueDate = Console.ReadLine();
        //            value = dueDate;
        //        }
        //    }
        //}
    }
}

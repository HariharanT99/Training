using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interfaces
{
    class PanValidation
    {
        private string _panNumber;

        //Pan Validation
        public string Panvalidate
        {
            get { return _panNumber; }
            set
            {
                while (true)
                {
                    Regex PanRegex = new Regex(@"[A-Z]{3}[P|C|H|A|B|G|J|L|F|T]{1}[A-Z]{1}\d{4}[A-Z]{1}");
                    Match match = PanRegex.Match(value);

                    if (match.Success)
                    {
                        this._panNumber = value;
                        break;
                    }

                    Console.WriteLine("Invalid Pan Number");
                    Console.WriteLine("Enter the valid Pan Number");
                    string panNumber = Console.ReadLine();
                    value = panNumber;
                }
            }
        }
    }
}

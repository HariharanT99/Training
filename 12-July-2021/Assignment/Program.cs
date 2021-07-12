using System;
using System.Collections;
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
            
            // For Addition
            Console.WriteLine("Enter the numbers for addition eg(a,b,c...)");
            var AddInput = Console.ReadLine();
            string[] AddList = AddInput.Split(',');
            string Operation = "Add";
            var AddResult = Calculator.Calculation(Operation ,AddList);
            Console.WriteLine($"The addition result is {AddResult}");
            
            //For Multiplication
            Console.WriteLine("Enter the numbers for multiplication eg(a,b,c...)");
            var MInput = Console.ReadLine();
            string[] MList = MInput.Split(',');
            string Operation1 = "Multiple";
            var MResult = Calculator.Calculation(Operation1, MList);
            Console.WriteLine($"The addition result is {MResult}");


            //For Subtraction
            Console.WriteLine("Enter the first number for subtraction");
            var SNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number for subtraction");
            var SNumber2 = int.Parse(Console.ReadLine());
            string Operation2 = "Subtraction";
            var SubResult = Calculator.Calculation(SNumber1, SNumber2, Operation2);
            Console.WriteLine($"The subtraction result is {SubResult}");

            //For Division
            Console.WriteLine("Enter the first number for division");
            var DivNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number for division");
            var DivNumber2 = int.Parse(Console.ReadLine());
            string Operation3 = "Division";
            var DivResult = Calculator.Calculation(DivNumber1, DivNumber2, Operation3);
            Console.WriteLine($"The division result is {DivResult}");

            //Decimal to DMS
            Console.WriteLine("Enter the Decimal number");
            double Value = Convert.ToDouble(Console.ReadLine());
            Dms.Minutes(Value);
        }
    }
}

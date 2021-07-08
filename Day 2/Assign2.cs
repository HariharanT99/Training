using System;

namespace Assign2
{
    class Program
    {
        public static void PrimitiveData()
        {
            sbyte SbValue = -122;
            Console.WriteLine("Sbyte Value = "+ SbValue);

            byte BValue = 245;
            Console.WriteLine("Byte Value = "+ BValue);

            short SValue = 32443;
            Console.WriteLine("short Value = "+ SValue);

            ushort UsValue = 64322;
            Console.WriteLine("Ushort Value = "+ UsValue);

            int IValue = 2123232;
            Console.WriteLine("Int Value = "+ IValue);

            uint UiValue = 245;
            Console.WriteLine("UInt Value = "+ UiValue);

            float FValue = 3.5F;
            Console.WriteLine("Float Value = "+ FValue);

            double DValue = 2.4;
            Console.WriteLine("Double Value = "+ DValue);

            Object OValue = "abc123";
            Console.WriteLine("Object Value = "+ OValue);

            char CValue = 'H';
            Console.WriteLine("Char Value = "+ CValue);

            string String = "Hariharan";
            Console.WriteLine("String Value = "+ String);

            decimal DcValue = 2000;
            Console.WriteLine("Decimal Value = "+ DcValue);

            bool BoValue = true;
            Console.WriteLine("Bool Value = "+ BoValue);

            DateTime DT = DateTime.Now;
            Console.WriteLine("DateTime Value = "+ DT);
        }
        public static void Operations()
        {
            Console.WriteLine("Enter the Int Value");
            int IValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Decimal Value");
            decimal DcValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Float1 Value");
            float F1Value = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Float2 Value");
            float F2Value = float.Parse(Console.ReadLine());

            var SumAns = IValue + DcValue;
            if (IValue == 0)
                Console.WriteLine("Division Not Allowed");
            else
            {
                var DivAns = DcValue/IValue;
                Console.WriteLine("The Division of Decimal Value and Int Value is " + DivAns);
            }
            var MulAns = F1Value * F2Value;

            Console.WriteLine("The sum of Int value and Decimal value is "+ SumAns  
            + "\n The Multiplication of two floats is " + MulAns);
        }
        public static void Details()
        {
            Console.WriteLine("Enter the Id");
            var Id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            var Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Id: " + Id + " Name: " + Name + " Salary: " + Salary);
        }
        public static void Reverse()
        {
            Console.WriteLine("Enter the three letters");
            var Str = Console.ReadLine();
            if (str.Length == 3)
            {
                char LastChar = Str[2];
                char MidChar = Str[1];
                char FirstChar = Str[0];
                Console.WriteLine("Reverse String is " + LastChar + MidChar + FirstChar);
            }
            else
                Console.WriteLine("The String must have only 3 characters");
        }
        public static void Calc()
        {
            Console.WriteLine("Enter the first number");
            var Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            var Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the following number for respective operator /n " + 
            " Add-0 , Sub-1 , Multiply-2 , Division-3");
            var opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 0)
            {
                var Ans = Number1 + Number2;
                Console.WriteLine("The Addision of {0} & {1} is {2}", Number1, Number2, Ans);
            }
            else if (opt == 1)
            {
                var Ans = Number1 - Number2;
                Console.WriteLine("The Subtraction of {0} & {1} is {2}", Number1, Number2, Ans);
            }
            else if (opt == 2)
            {
                var Ans = Number1 / Number2;
                Console.WriteLine("The Division of {0} & {1} is {2}", Number1, Number2, Ans);
            }
            else if (opt == 3)
            {
                var Ans = Number1 * Number2;
                Console.WriteLine("The Multiplication of {0} & {1} is {2}", Number1, Number2, Ans);
            }
        }
        public static void Comp()
        {
            Console.WriteLine("Enter the First String");
            var Str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            var Str2 = Console.ReadLine();
            Console.WriteLine("Enter the First Number");
            var Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            var Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of String Comparison is "+ (Str1 == Str2));
            Console.WriteLine("Result of Number Comparison is "+ (Number1 == Number2));

            if ((Str1 == Str2) && (Number1 == Number2))
                Console.WriteLine("Both Conditions are True");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
           /* Assign2.Program.PrimitiveData();
            Assign2.Program.Operations();
            Assign2.Program.Details();
            Assign2.Program.Reverse();
            Assign2.Program.Calc();
            Assign2.Program.Comp();*/
            string Str = "Res";
            char MidChar = Str[1];
            char FirstChar = Str[0];
            char LastChar = Str[2];

            Console.WriteLine("Reverse String is " + LastChar + MidChar + FirstChar);
        }
    }
}

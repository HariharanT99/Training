using System;

namespace CalculatorTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calcObj = new Calculator();

            Console.WriteLine("Enter '1' for [Addition],'2' for [Subtraction],'3' for [Multiplication],'4' for [Division],");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First Number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            float result;

            switch (option)
            {
                case 1:
                    result = calcObj.Addition(number1, number2);
                    Console.WriteLine($"Result of Addition {result}");
                    break;
                case 2:
                    result = calcObj.Subtraction(number1, number2);
                    Console.WriteLine($"Result of Subtraction {result}");
                    break;
                case 3:
                    result = calcObj.Multiplication(number1, number2);
                    Console.WriteLine($"Result of Multiplacation {result}");
                    break;
                case 4:
                    result = calcObj.Division(number1, number2);
                    Console.WriteLine($"Result of Division {result}");
                    break;
                default:
                    Console.WriteLine("Enter the valid Input");
                    break;
            }
        }
    }
}

using System;

namespace assign
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            var firstName = "Hari";
            var lastName = "Haran";
            float number1 = 4.35F;
            int number2 = 5;
            var myLength = firstName.Length;
            Console.WriteLine(firstName + lastName);
            Console.WriteLine(firstName == lastName);
            Console.WriteLine(myLength);

            if (number2 > number1)
                Console.WriteLine("Success");
            else
                Console.WriteLine("Failed");


        }
    }
}
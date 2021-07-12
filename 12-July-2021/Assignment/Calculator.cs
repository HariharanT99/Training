using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Calculator
    {
        public static int Calculation(String Operation, params string[] MyList)
        {
            if (Operation == "Add")
            {
                int Ans = 0;
                foreach (string i in MyList)
                {
                    Ans += int.Parse(i);
                }
                return Ans;
            }
            else if (Operation == "Multiple")
            {
                int Ans = 1;
                foreach (string i in MyList)
                {
                    Ans *= Convert.ToInt32(i);
                }
                return Ans;
            }
            else
                return 0;
        }

        public static int Calculation(int number1, int number2 , string Operation)
        {
            if (Operation == "Subtraction")
            {
                int Ans = number1 - number2;
                return Ans;
            }
            else if (Operation == "Divide")
            {
                int Ans = number1 / number2;
                return Ans;
            }
            else
                return 0;
        }

        //public static int Calculation(params int[] MyList)
        //{
        //    int MultiplicationAns = 1;
        //    foreach (int i in MyList)
        //    {
        //        MultiplicationAns *= Convert.ToInt32(i);
        //    }
        //    return MultiplicationAns;
        //}
        //public
    }
}

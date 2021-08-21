using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public float _result;
        public float Addition(int number1, int number2)
        {
            _result = number2 + number1;
            return _result;
        }
        public float Subtraction(int number1, int number2)
        {
            _result = number1 - number2;
            return _result;
        }

        public float Multiplication(int number1, int number2)
        {
            _result = number1 * number2;
            return _result;
        }

        public float Division(int number1, int number2)
        {
            try
            {
                _result = number1 / number2;
            }
            catch
            {
                Console.WriteLine("Denominator Should not be null");
            }
            return _result;
        }
    }
}

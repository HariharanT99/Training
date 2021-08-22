using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Logic
    {
        public double ConverToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit-32) * (5.00 / 9);
            return Math.Round(celsius,4);
        }

        public double AreaofTraiangle (float side1, float side2, float side3)
        {

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new("Sides should not contains zero and negative values");
            }
            else
            {
                double semiPerimeter = (side1 + side2 + side3) / 2;

                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
                return area;
            }
        }
    }
}

using System;
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
            Computer ComputerObj = new Computer();
            ComputerObj.Configuration();

            Laptop LaptopObj = new Laptop();
            LaptopObj.Configuration();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Asset
    {
        public abstract void Configuration();

        public void Warranty()
        {
            Console.WriteLine("Warranty in base class");
        }
    }
}

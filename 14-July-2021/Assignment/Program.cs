using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch Object = new StopWatch();
            Object.Start();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Object.Start();
            Object.Stop();
            Object.GetInterval();
        }
    }
}

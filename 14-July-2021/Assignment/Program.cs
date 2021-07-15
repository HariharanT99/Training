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
<<<<<<< HEAD
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Object.Start();
=======
            Thread.Sleep(5000);
>>>>>>> 0adb2741ee3a453acdf8fb19be14a5902a262206
            Object.Stop();
            Object.GetInterval();
        }
    }
}

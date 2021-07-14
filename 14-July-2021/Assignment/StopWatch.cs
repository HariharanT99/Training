using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StopWatch
    {
        private DateTime _atStart;
        private bool _started;
        private TimeSpan _difference;

        public void Start()
        {
            if (_started == false)
            {
                this._atStart = DateTime.Now;
                this._started = true;
            }
        }

        public void Stop()
        {
            this._difference = _atStart - DateTime.Now;
            this._started = false;
        }
        public void GetInterval()
        {
            Console.WriteLine($"Days: {_difference.Days} , Hours: {_difference.Hours} , Minutes: {_difference.Minutes} , Seconds: {_difference.Seconds}");
        }
    }
}

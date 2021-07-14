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
                this._atStart = DateTime.Now; //Set the time
                this._started = true;  //Set the bool value for to check it is already started or not 
            }
        }

        public void Stop()
        {
            this._difference = _atStart - DateTime.Now; // Get the time difference
            this._atStart = new DateTime(); //Reset the Time
            this._started = false; //Reset the bool to 'false' for to menton it's stoped
        }
        public void GetInterval()
        {
            Console.WriteLine($"Days: {_difference.Days} , Hours: {_difference.Hours} , Minutes: {_difference.Minutes} , Seconds: {_difference.Seconds}"); //Print the Time Difference
        }
    }
}

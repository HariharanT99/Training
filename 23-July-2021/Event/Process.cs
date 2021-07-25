using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Process
    {
        public event EventHandler<StringArgs> ManipulateString;

        public void StringProcess()                    //Process Method
        {
            StringArgs assignObj = new StringArgs();       

            assignObj.MyFirstString = "This is my demo string";
            assignObj.MySecondString = "My second demo";
            assignObj.MyChar = 's';
            OnManipulateString(assignObj);
        }

        protected virtual void OnManipulateString(StringArgs myStrArgs) //Method for invoke Event
        {
            ManipulateString?.Invoke(this, myStrArgs);
        }
    }
}

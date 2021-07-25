using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class StringArgs : EventArgs
    {
        //My Arguments
        public string MyFirstString { get; set; }   
        public string MySecondString { get; set; }
        public char MyChar { get; set; }

    }
}

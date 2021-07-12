using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Coordinates
    {
        public int X;
        public int Y;
        public int Z;
        public Coordinates()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Coordinates(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}

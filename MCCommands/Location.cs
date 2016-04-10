using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCommands
{
    public class Location
    {
        public bool Relative;
        public int X;
        public int Y;
        public int Z;

        public Location(bool relative, int x, int y, int z)
        {
            Relative = relative;
            X = x;
            Y = y;
            Z = z;
        }
    }
}

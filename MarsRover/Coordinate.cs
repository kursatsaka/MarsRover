using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void SetX(int x)
        {
            this.X = x;
        }
        public void SetY(int y)
        {
            this.Y = y;
        }
    }
}

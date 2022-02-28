using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        public int xSize { get; set; }
        public int ySize { get; set; }
        public Plateau(int xSize, int ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class WestDirectionState : RoverDirectionState
    {
        public WestDirectionState(Coordinate Coordinates) : base(Coordinates) { }

        public override void Move()
        {
            Coordinates.SetX(Coordinates.X - 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new SouthDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new NorthDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return "W";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class SouthDirectionState : RoverDirectionState
    {
        public SouthDirectionState(Coordinate Coordinates) : base(Coordinates) { }

        public override void Move()
        {
            Coordinates.SetY(Coordinates.Y - 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new EastDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new WestDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return "S";
        }
    }
}

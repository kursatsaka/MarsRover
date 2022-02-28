using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class NorthDirectionState : RoverDirectionState
    {
        public NorthDirectionState(Coordinate Coordinates) : base(Coordinates) { }

        public override void Move()
        {
            Coordinates.SetY(Coordinates.Y + 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new WestDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new EastDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return "N";
        }
    }
}

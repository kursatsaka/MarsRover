using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public abstract class RoverDirectionState
    {
        public Coordinate Coordinates { get; private set; }
        public RoverDirectionState(Coordinate Coordinates)
        {
            this.Coordinates = Coordinates;
        }
        public abstract void Move();
        public abstract RoverDirectionState TurnLeft();
        public abstract RoverDirectionState TurnRight();
    }
}

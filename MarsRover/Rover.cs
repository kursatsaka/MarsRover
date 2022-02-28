using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        private RoverDirectionState RoverState;

        public Rover(Coordinate coordinates, string direction)
        {
            switch (direction)
            {
                case "N":
                    this.RoverState = new NorthDirectionState(new Coordinate(coordinates.X, coordinates.Y));
                    break;
                case "S":
                    this.RoverState = new SouthDirectionState(new Coordinate(coordinates.X, coordinates.Y));
                    break;
                case "E":
                    this.RoverState = new EastDirectionState(new Coordinate(coordinates.X, coordinates.Y));
                    break;
                case "W":
                    this.RoverState = new WestDirectionState(new Coordinate(coordinates.X, coordinates.Y));
                    break;
            }
        }

        public void Move()
        {
            this.RoverState.Move();
        }

        public void TurnLeft()
        {
            this.RoverState = this.RoverState.TurnLeft();
        }

        public void TurnRight()
        {
            this.RoverState = this.RoverState.TurnRight();
        }

        public Coordinate GetCoordinates()
        {
            return this.RoverState.Coordinates;
        }

        public override string ToString()
        {
            return this.GetCoordinates().X + " " + this.GetCoordinates().Y + " " + this.RoverState;
        }
    }
}

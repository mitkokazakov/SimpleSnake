using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest
{
    public class Directions
    {
        private Coordinates[] possibleDirections = new Coordinates[] {
                new Coordinates(0,1), // Right
                new Coordinates(0,-1), // Left
                new Coordinates(1,0), // Down
                new Coordinates(-1,0), //Up
            };

        public Directions(ConsoleKeyInfo button)
        {
            this.Button = button;
        }

        public ConsoleKeyInfo Button { get; }


        public Coordinates GetNextPosition()
        {
            Coordinates nextPosition = null;


            if (this.Button.Key == ConsoleKey.RightArrow)
            {
                nextPosition = possibleDirections[0];
            }
            else if (this.Button.Key == ConsoleKey.LeftArrow)
            {
                nextPosition = possibleDirections[1];
            }
            else if (this.Button.Key == ConsoleKey.DownArrow)
            {
                nextPosition = possibleDirections[2];
            }
            else if (this.Button.Key == ConsoleKey.UpArrow)
            {
                nextPosition = possibleDirections[3];
            }




            return nextPosition;
        }

    }
}

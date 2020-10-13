using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest
{
    public class Coordinates
    {
        public Coordinates()
        {

        }

        public Coordinates(int row, int col) : this()
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; set; }

        public int Col { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest
{
    public class Food : Coordinates
    {
        private Random random;
        private char foodSymbol = '@';

        public Food()
        {
            this.random = new Random();
            this.Row = this.random.Next(1,Console.WindowHeight -1);
            this.Col = this.random.Next(1,Console.WindowWidth - 1);
        }

        public void CreateFood()
        {
            Console.SetCursorPosition(this.Col,this.Row);
            Console.Write(foodSymbol);
        }
    }
}

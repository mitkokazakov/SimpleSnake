using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest
{
    public class Food : Coordinates
    {
        private Random random;
        private char foodSymbol = '@';

        public Food(Frame frame)
        {
            this.Frame = frame;
            this.random = new Random();
            this.Row = this.random.Next(this.Frame.Row + 1, this.Frame.Height - 1); // Console.WindowHeight
            this.Col = this.random.Next(this.Frame.Col, this.Frame.Lenght - 1); // Console.WindowWidth
        }

        public Frame Frame { get; }
        public void CreateFood()
        {
            Console.SetCursorPosition(this.Col,this.Row);
            Console.Write(foodSymbol);
        }
    }
}

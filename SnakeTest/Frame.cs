using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest
{
    public class Frame
    {
        private const int lenght = 30;
        private const int height = 20;

        private int x;
        private int y;

        public Frame(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.x = x;
            this.y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public void DrawTopHorizontalLine()
        {
            Console.SetCursorPosition(this.Y, this.X);

            for (int i = 0; i < lenght; i++)
            {
                Console.Write('^');
            }
        }

        public void DrawBottomHorizontalLine()
        {
            Console.SetCursorPosition(this.Y, this.X + height);

            for (int i = 0; i < lenght; i++)
            {
                Console.Write('^');
            }
        }

        public void DrawLeftVerticalLine()
        {
            Console.SetCursorPosition(this.Y, this.X);

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(this.Y, this.X);
                Console.Write('^');
                this.X++;
            }
        }

        public void DrawRightVerticalLine()
        {
            this.Y = this.y + lenght;
            this.X = this.x;

            Console.SetCursorPosition(this.Y , this.X);

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(this.Y, this.X);
                Console.Write('^');
                this.X++;
            }
        }

        public void DrawFrame()
        {
            this.DrawTopHorizontalLine();
            this.DrawBottomHorizontalLine();
            this.DrawLeftVerticalLine();
            this.DrawRightVerticalLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeTest
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight;
            Queue<Coordinates> snakeElements = new Queue<Coordinates>();


            for (int i = 0; i < 5; i++)
            {
                snakeElements.Enqueue(new Coordinates(0, i));
            }

            foreach (Coordinates element in snakeElements)
            {
                Console.SetCursorPosition(element.Col, element.Row);
                Console.Write('#');
            }

            Food food = new Food();
            food.CreateFood();

            Directions directions = null;
            Coordinates nextDirection = new Coordinates(0,1);

            while (true)
            {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo insertDirection = Console.ReadKey();

                    directions = new Directions(insertDirection);

                    //Determine the next position of the snake's head
                    nextDirection = directions.GetNextPosition();
                }
                Coordinates snakeHead = snakeElements.Last();

                Coordinates snakeNewHead = new Coordinates(snakeHead.Row + nextDirection.Row, snakeHead.Col + nextDirection.Col);
                snakeElements.Enqueue(snakeNewHead);

                //Console.SetCursorPosition(snakeNewHead.Col, snakeNewHead.Row);
                //Console.Write('#');

                //Check if the snakae goes out of boundary
                if (snakeNewHead.Row < 0 || snakeNewHead.Row >= Console.WindowHeight || snakeNewHead.Col < 0 || snakeNewHead.Col >= Console.WindowWidth)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("GAME OVER!!!");
                    return;
                }

                //Check if snake has bitten yourself
                var snakeWhitoutHead = snakeElements.SkipLast(1);
                if (snakeWhitoutHead.Any(e => e.Row == snakeNewHead.Row && e.Col == snakeNewHead.Col))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("GAME OVER!!!");
                    return;
                }

                Console.SetCursorPosition(snakeNewHead.Col, snakeNewHead.Row);
                Console.Write('#');

                //Check if the head of the snake is over the food ---> In this case we have to feed the snake and increase
                //the elements of the snake (We don't Dequeue() from the snakeElements)
                if (snakeNewHead.Row == food.Row && snakeNewHead.Col == food.Col)
                {

                    //If the snake is fed we set new coordinates of the food through the constructor of Food()
                    food = new Food();
                    food.CreateFood();
                }
                else
                {
                    //If the snake is not fed
                    var lastElement = snakeElements.Dequeue();
                    Console.SetCursorPosition(lastElement.Col, lastElement.Row);
                    Console.Write(' ');
                }


                Thread.Sleep(50);
                //Console.Clear();

                //foreach (Coordinates element in snakeElements)
                //{
                //    Console.SetCursorPosition(element.Col, element.Row);
                //    Console.Write('#');
                //}


                //food.CreateFood();


            }

        }
    }
}

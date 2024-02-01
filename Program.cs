using System.Security.Cryptography.X509Certificates;

namespace SnakeTestGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false; 
            Canvas canvas = new Canvas();
            Snake snake = new Snake();
            Food food = new Food();

            Console.WriteLine("\t \t \t \t Press Enter to start the game!");
            Console.Read();

            try
            {
                while (!finished)
                {
                    canvas.drawCanvas();

                    Console.SetCursorPosition(55, 5);
                    Console.WriteLine($"Points: {snake.points}");
                    snake.Input();
                    food.drawFood();
                    snake.drawSnake();
                    snake.moveSnake();
                    snake.snakeGrow(food.FoodLocation(), food);
                    snake.isDead();
                    snake.hitWall(canvas);
                }
            }
            catch (SnakeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);

                Console.WriteLine("Restart: (y/n) ");
                var c = char.Parse(Console.ReadLine());

                switch (c)
                {
                    case 'y':
                        Console.Clear();
                        snake.x = 5;
                        snake.y = 5;
                        snake.points = 0;
                        snake.SnakeBody.RemoveRange(0, snake.SnakeBody.Count - 1);
                        break;

                    case 'n':
                        finished = true;
                        break;
                }
                
            }

        }
    }
}

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

            Console.WriteLine("Press Enter to start the game!");
            Console.Read();

            while (!finished)
            {
                canvas.drawCanvas();
                snake.Input();
                food.drawFood();
                snake.drawSnake();
                snake.moveSnake();
                snake.snakeGrow(food.FoodLocation(), food);
            }
        }
    }
}

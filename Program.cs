namespace SnakeTestGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false; 
            Canvas canvas = new Canvas();
            Snake snake = new Snake();

            while (!finished)
            {
                canvas.drawCanvas();
                snake.Input();
                snake.drawSnake();
                snake.moveSnake();
                
            }
        }
    }
}

namespace SnakeTestGame
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            Snake snake = new Snake();
            
            bool finished = false;

            while (!finished)
            {
                canvas.drawCanvas();
                Console.Read();
                snake.drawSnake();
            }
        }
    }
}

namespace SnakeTestGame;

public class Snake
{
    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
    char key = 'w';

    public int x { get; set; }
    public int y { get; set; }

    public Snake()
    {
        x = 5; 
        y = 5;
    }

    public void drawSnake()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("S");
    }

    public void Input()
    {
        if (Console.KeyAvailable)
        {
            key = keyInfo.KeyChar;
        }
    }
}
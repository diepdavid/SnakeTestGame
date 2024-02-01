namespace SnakeTestGame;

public class Snake
{
    private List<Position> SnakeBody;
    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
    Food food = new Food();

    char key = 'd';
    char dir = 'r';

    public int x { get; set; }
    public int y { get; set; }

    public Snake()
    {
        x = 5; 
        y = 5;

        SnakeBody = new List<Position>();
        SnakeBody.Add(new Position(x, y));
    }

    public void drawSnake()
    {
        foreach (var pos in SnakeBody)
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write("S");
        }

    }

    public void Input()
    {
        if (Console.KeyAvailable)
        {
            key = keyInfo.KeyChar;
            keyInfo = Console.ReadKey(true);
        }
    }

    private void direction()
    {
        if (key == 'w' && dir != 'd')
        {
            dir = 'u';
        }
        else if (key == 's' && dir != 'u')
        {
            dir = 'd';
        }
        else if (key == 'd' && dir != 'l')
        {
            dir = 'r';
        }
        else if (key == 'a' && dir != 'r')
        {
            dir = 'l';
        }
    }

    public void moveSnake()
    {
        direction();

        if (dir == 'u')
        {
            y--;
        }
        else if (dir == 'd')
        {
            y++;
        }
        else if (dir == 'r')
        {
            x++;
        }
        else if (dir == 'l')
        {
            x--;
        }

        SnakeBody.Add(new Position(x, y));
        SnakeBody.RemoveAt(0);
        Thread.Sleep(200);
    }

    public void snakeGrow(Position foodPos, Food f)
    {
        Position head = SnakeBody[SnakeBody.Count - 1];

        
        if (head.x == foodPos.x && head.y == foodPos.y)
        {
            SnakeBody.Add(new Position(x, y));
            f.newFoodLocation();
        }

    }

    public void isDead()
    {
        Position head = SnakeBody[SnakeBody.Count - 1];

        for (int i = 0; i < SnakeBody.Count - 2; i++)
        {
            if (head.x == SnakeBody[i].x && head.y == SnakeBody[i].y)
            {
                throw new SnakeException("You lost");
            }
        }
    }

    public void hitWall(Canvas canvas)
    {
        Position head = SnakeBody[SnakeBody.Count - 1];

        if (head.x >= canvas.Width || head.x < 0 || head.y >= canvas.Height || head.y < 0)
        {
            throw new SnakeException("You lost");
        }
    }
}
namespace SnakeTestGame;

public class Food
{
    public Position foodPos = new Position();

    Canvas canva = new Canvas();
    Random rnd = new Random();

    public Food()
    {
        foodPos.x = rnd.Next(0, canva.Width);
        foodPos.y = rnd.Next(0, canva.Height);
    }

    public void drawFood()
    {
        Console.SetCursorPosition(foodPos.x, foodPos.y);
        Console.WriteLine("P");
    }

    public Position FoodLocation()
    {
        return foodPos;
    }

    public void newFoodLocation()
    {
        foodPos.x = rnd.Next(0, canva.Width);
        foodPos.y = rnd.Next(0, canva.Height);
    }
}
namespace PaintShop;

// 2 - Crie uma classe Room
public class Room
{
    public Wall[] walls { get; }
    public double TotalPaintableArea
    {
        get {
            double sumTotal = 0;
            foreach(var wall in walls)
            {
                sumTotal += wall.PaintableArea;
            }
            return sumTotal;
            }
    }
    public Room(params Wall[] walls)
    {
        this.walls = walls;
    }
}
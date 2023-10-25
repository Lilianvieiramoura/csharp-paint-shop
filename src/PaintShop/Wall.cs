namespace PaintShop;

// 1 - Crie uma classe Wall
public class Wall
{
    double _width;
    double _height;
    public double Width
    {
        get { return _width; }
        set {
            if (value <= 0)
            {
                _width = 1;
            } else
            {
                _width = value;
            }
        }
    }
    public double Height
    {
        get { return _height; }
        set {
            if (value <= 0)
            {
                _height = 1;
            } else
            {
                _height = value;
            }
        }
    }
    public double ExcludedArea { get; set; }
    public double PaintableArea
    {
        get { return (Width * Height) - ExcludedArea; }
    }
    public Wall(double width, double height)
    {
        Width = width;
        Height = height;
    }
}
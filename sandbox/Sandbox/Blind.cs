public class Blind
{
    public double _width;
    public double _height;
    public string _color;

    public Blind()
    {
    }

    public void answers()
    {
    Console.WriteLine($"Your color is {_color}");
    Console.WriteLine($"Your height is {_height}");
    Console.WriteLine($"Your width is {_width}");
    }
    public void answer()
    {
    Console.WriteLine($"The color is {_color}");
    Console.WriteLine($"The height is {_height}");
    Console.WriteLine($"The width is {_width}");   
    }
    public double GetArea()
    {
        return _width * _height;
    }
}
namespace Abstract.Shape;

public class Rectangle : Shape
{
    private double _x;
    private double _y;

    public Rectangle()
    {
        _x = Generate(10, 20);
        _y = Generate(5, 30);
    }

    public override double GetArea()
    {
        return _x * _y;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"x={_x} y={_y}");
    }
}
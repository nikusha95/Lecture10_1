namespace Interfaces.Shape;

public class Square : IShape
{
    private readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double GetArea()
    {
        return Math.Pow(_side, 2);
    }

    public double GetPerimeter()
    {
        return 4 * _side;
    }
}
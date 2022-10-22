using System.Collections;

namespace Interfaces.Shape;

public class Circle : IShape, IInformation
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * _radius;
    }


    public void Print()
    {
        Console.WriteLine($"radius:{_radius}");
    }
}
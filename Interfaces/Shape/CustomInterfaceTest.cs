namespace Interfaces.Shape;

public class CustomInterfaceTest
{
    private IShape _shape;

    public CustomInterfaceTest(IShape shape)
    {
        _shape = shape;
    }

    void Test()
    {
        Console.WriteLine(_shape.GetArea());
    }
}
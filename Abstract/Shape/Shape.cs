namespace Abstract.Shape;

public abstract class Shape
{
    public abstract double GetArea();

    public virtual void PrintInfo()
    {
        Console.WriteLine("This is shape");
    }

    public int Generate(int maxValue, int minValue)
    {
        Random r = new Random();

        return r.Next(maxValue, minValue);
    }
}
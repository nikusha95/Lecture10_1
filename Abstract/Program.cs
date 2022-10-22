// See https://aka.ms/new-console-template for more information

using Abstract.Shape;

Circle c = new Circle(10);
Console.WriteLine($"circle area:{c.GetArea()}");
c.PrintInfo();

Console.WriteLine();

Shape s = new Rectangle();
Console.WriteLine($"rectangle area:{s.GetArea()}");
s.PrintInfo();
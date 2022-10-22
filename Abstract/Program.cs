// See https://aka.ms/new-console-template for more information

using Abstract.Shape;

Circle c1 = new Circle(10);
Circle c2 = new Circle(10);
Console.WriteLine($"circle area:{c1.GetArea()}");
c1.PrintInfo();


Console.WriteLine();

Shape s = new Rectangle();
Console.WriteLine($"rectangle area:{s.GetArea()}");
s.PrintInfo();
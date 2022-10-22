// See https://aka.ms/new-console-template for more information

using Interfaces.Shape;


Circle s = new Circle(5);
Console.WriteLine("area");
Console.WriteLine(s.GetArea());
Console.WriteLine("perimeter");
Console.WriteLine(s.GetPerimeter());
s.Print();

CustomInterfaceTest customInterfaceTest = new CustomInterfaceTest(new Square(10));

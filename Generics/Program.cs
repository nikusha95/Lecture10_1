﻿// See https://aka.ms/new-console-template for more information

using Generics;

int x;
int[] arr;

List<int> list = new List<int>();

// list.Add(10);
// list.Add(20);
// list.AddRange(new List<int> { 10, 20, 40, 50 });


for (int i = 0; i < 10; i++)
{
    Random r = new Random();
    int element = r.Next(0, 5000);
    list.Add(element);
}

if (list.Contains(100))
{
    list.Remove(100);
}

Console.WriteLine($"list size:{list.Count}"); //equivalent as arr.Length
Console.WriteLine();
foreach (var item in list)
{
    Console.WriteLine(item);
}

List<double> dList = new List<double>
{
    11.5, 12, 13
};

Console.WriteLine("Custom Generic");
GenericArray<int> genericArray1 = new GenericArray<int>(10);

genericArray1.AddElement(20,3);
genericArray1.AddElement(12,4);
Console.WriteLine(genericArray1.GetElement(3));
using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listOfShapes = new List<Shape>();

        Square square = new("red", 15);
        Rectangle rectangle = new("blue", 5, 10);
        Circle circle = new("orange", 15);

        listOfShapes.Add(square);
        listOfShapes.Add(rectangle);
        listOfShapes.Add(circle);

        foreach (Shape s in listOfShapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}
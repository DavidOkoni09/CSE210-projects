using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 5);

        Rectangle r1 = new Rectangle("Red", 3, 5);

        Circle c1 = new Circle("brown", 7);

        shapes.Add(new Square("Blue", 5));
        shapes.Add(new Circle("Red", 7));
        shapes.Add(new Rectangle("Brown", 3, 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has area: {shape.GetArea():F2}");
        }
    }
}
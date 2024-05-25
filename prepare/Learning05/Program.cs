using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("orange", 22.3));
        shapes.Add(new Circle("orange", 10.2));
        shapes.Add(new Rectangle("blue", 22.3, 10.5));
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"The color is {color} ");
            Console.WriteLine($"The area is {area} ");
        }
    }
}
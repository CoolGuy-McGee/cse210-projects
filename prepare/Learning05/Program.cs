using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square("Red", 5);
        shapes.Add(s);

        Rectangle r = new Rectangle("Blue", 4, 7);
        shapes.Add(r);

        Circle c = new Circle("Yellow", 8);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            string name = shape.GetName();

            Console.WriteLine($"The {color} {name} has an area of {area} units.");
        }
    }
}
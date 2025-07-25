public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        SetName("Circle");
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}
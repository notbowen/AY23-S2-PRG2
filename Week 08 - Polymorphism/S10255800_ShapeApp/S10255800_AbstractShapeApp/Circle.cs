namespace S10255800_AbstractShapeApp;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
    }

    public Circle(string color, double radius) : base("Circle", color)
    {
        Radius = radius;
    }
    
    public override double FindArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double FindPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return base.ToString() + $"\tRadius: {Radius}";
    }
}

namespace S10255800_MyShapeApp;

public class Circle
{
    public double Radius { get; set; }

    public Circle()
    {
        
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.Pow(Math.PI * Radius, 2);
    }

    public override string ToString()
    {
        return $"Radius: {Radius}\nArea: {CalculateArea():0.00}";
    }
}
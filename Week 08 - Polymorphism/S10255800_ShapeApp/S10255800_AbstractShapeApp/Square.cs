namespace S10255800_AbstractShapeApp;

public class Square : Shape
{
    public double Length { get; set; }
    
    public Square()
    {
    }
    
    public Square(string color, double length) : base("Square", color)
    {
        Length = length;
    }
    
    public override double FindArea()
    {
        return Length * Length;
    }
    
    public override double FindPerimeter()
    {
        return 4 * Length;
    }
    
    public override string ToString()
    {
        return base.ToString() + $"\tLength: {Length}";
    }
}
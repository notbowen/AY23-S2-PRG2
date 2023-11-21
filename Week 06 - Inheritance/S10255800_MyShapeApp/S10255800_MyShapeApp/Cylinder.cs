namespace S10255800_MyShapeApp;

public class Cylinder : Circle
{
    public double Length { get; set; }
    
    public Cylinder()
    {
        
    }

    public Cylinder(double radius, double length) : base(radius)
    {
        Length = length;
    }

    public new double CalculateArea()
    {
        return 2 * Math.PI * Length + base.CalculateArea();
    }

    public double CalculateVolume()
    {
        return base.CalculateArea() * Length;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
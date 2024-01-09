namespace S10255800_Shapes;

public class SquarePyramid
{
    public double a { get; }
    public double h { get; }

    public SquarePyramid()
    {
    }

    public SquarePyramid(double length, double height)
    {
        a = length;
        h = height;
    }

    public double GetVolume()
    {
        return Math.Pow(a, 2) * h / 3;
    }

    public double GetSurfaceArea()
    {
        return a * a + a * Math.Sqrt(Math.Pow(a, 2) + 4 * Math.Pow(h, 2));
    }
}
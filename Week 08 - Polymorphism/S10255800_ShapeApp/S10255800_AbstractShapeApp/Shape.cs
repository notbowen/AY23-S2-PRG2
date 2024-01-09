namespace S10255800_AbstractShapeApp;

public abstract class Shape : IComparable<Shape>
{
    public string Type { get; set; }
    public string Color { get; set; }

    public Shape()
    {
    }

    public Shape(string type, string color)
    {
        Type = type;
        Color = color;
    }

    public abstract double FindArea();
    public abstract double FindPerimeter();
    
    public int CompareTo(Shape other)
    {
        return FindArea().CompareTo(other.FindArea());
    }

    public override string ToString()
    {
        return $"Type: {Type}\tColor: {Color}";
    }
}
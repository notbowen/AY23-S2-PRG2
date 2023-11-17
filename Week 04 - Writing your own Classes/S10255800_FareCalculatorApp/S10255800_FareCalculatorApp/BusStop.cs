namespace S10255800_FareCalculatorApp;

public class BusStop
{
    public double Distance { get; }
    public string Code { get; }
    public string Road { get; }
    public string Description { get; }

    public BusStop(double distance, string code, string road, string description)
    {
        Distance = distance;
        Code = code;
        Road = road;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Distance,-15:0.0} {Code,-15} {Road,-20} {Description}";
    }

    public static bool operator <(BusStop a, BusStop b)
    {
        return a.Distance < b.Distance;
    }

    public static bool operator >(BusStop a, BusStop b)
    {
        return a.Distance > b.Distance;
    }

    public static double operator +(BusStop a, BusStop b)
    {
        return a.Distance + b.Distance;
    }
    
    public static double operator -(BusStop a, BusStop b)
    {
        return a.Distance - b.Distance;
    }
}
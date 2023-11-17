namespace S10255800_FareCalculatorApp;

public class Fare
{
    public double UpToDistance { get; private set; }
    public double Amount { get; private set; }

    public Fare(double upToDistance, int amount)
    {
        UpToDistance = upToDistance;
        Amount = amount / 100.0;
    }

    public override string ToString()
    {
        return $"Up to Distance: {UpToDistance}\nAmount: {Amount:C}";
    }
}
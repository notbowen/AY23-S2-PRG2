namespace S10255800_ShippingApp;

public class ShippingAddr
{
    public string Country { get; }
    public string Street { get; }

    public ShippingAddr()
    {
    }

    public ShippingAddr(string country, string street)
    {
        Country = country;
        Street = street;
    }

    public override string ToString()
    {
        return $"{Country,-15} {Street,-15}";
    }
}
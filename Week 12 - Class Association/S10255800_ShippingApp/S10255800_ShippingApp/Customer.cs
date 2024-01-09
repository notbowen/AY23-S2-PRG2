namespace S10255800_ShippingApp;

public class Customer
{
    public string Name { get; }
    public string Tel { get; }
    public ShippingAddr Addr { get; }

    public Customer()
    {
    }

    public Customer(string name, string tel, ShippingAddr addr)
    {
        Name = name;
        Tel = tel;
        Addr = addr;
    }

    public override string ToString()
    {
        return $"{Name,-15} {Tel,-15} {Addr}";
    }
}
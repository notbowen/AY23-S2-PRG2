namespace S10255800_PosApp;

public class Product
{
    public string Code { get; }
    public string Name { get; }
    public double Price { get; }

    public Product()
    {
    }

    public Product(string code, string name, double price)
    {
        Code = code;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Code: {Code}, Name: {Name}, Price: {Price}";
    }
}
namespace S10255800_PosApp;

public class CartItem : Product
{
    public int Qty { get; set; }

    public CartItem()
    {
    }
    
    public CartItem(string code, string name, double price, int qty) : base(code, name, price)
    {
        Qty = qty;
    }
    
    public override string ToString()
    {
        return base.ToString() + ", Qty: " + Qty;
    }
}
namespace S10255800_Phone;

public class Prepaid : MobilePlan
{
    private double Balance { get; set; }
    private Stack<DateTime> History { get; }

    public Prepaid()
    {
    }

    public Prepaid(string number, double roamingData) : base(number, 0, roamingData)
    {
        Balance = 0;
        History = new Stack<DateTime>();
    }

    public void BuyData(int amount)
    {
        switch (amount, Balance)
        {
            case (10, >= 10):
                Data += 10;
                Balance -= 10;
                break;
            case (20, >= 15):
                Data += 20;
                Balance -= 15;
                break;
            case (30, >= 20):
                Data += 30;
                Balance -= 20;
                break;
            default:
                Console.WriteLine("Invalid amount or insufficient cash!");
                return;
        }

        History.Push(DateTime.Now);
    }

    public void TopUpBalance(double amount)
    {
        Balance += amount;
    }

    public override double RoamingCharges()
    {
        return 0.0;
    }

    public override string ToString()
    {
        return
            $"{Number} has {Balance:C0} and {Data} GB, top-up on {string.Join(", ", History.Select(time => time.ToString("dd MMM yyyy")))}";
    }
}
namespace S10255800_CommonTest_Q3;

public abstract class Card
{
    public string CardNumber { get; }
    public string CardHolderName { get; }
    public double TotalPaid { get; protected set; }

    protected Card()
    {
    }

    protected Card(string cardNumber, string cardHolderName)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
    }

    public abstract bool MakePayment(double amount);

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
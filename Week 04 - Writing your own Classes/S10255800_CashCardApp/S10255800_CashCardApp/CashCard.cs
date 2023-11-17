namespace S10255800_CashCardApp;

public class CashCard
{
    public string Id { get; private set; }
    public double Balance { get; private set; }

    public CashCard() { }

    public CashCard(string id, double balance)
    {
        Id = id;
        Balance = balance;
    }

    public void TopUp(double value)
    {
        Balance += value;
    }

    public bool Deduct(double value)
    {
        if (value > Balance)
            return false;

        Balance -= value;
        return true;
    }

    public override string ToString()
    {
        return "Id: " + Id + "\nBalance: " + Balance;
    }
}
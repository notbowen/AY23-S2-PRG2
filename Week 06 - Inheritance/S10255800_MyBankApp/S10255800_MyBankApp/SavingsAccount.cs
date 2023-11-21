namespace S10255800_MyBankApp;

public class SavingsAccount : BankAccount
{
    public double Rate { get; }

    public SavingsAccount()
    {
    }

    public SavingsAccount(string accNo, string accName, double balance, double rate) : base(accNo, accName, balance)
    {
        Rate = rate;
    }

    public double CalculateInterest()
    {
        return Balance * (Rate / 100);
    }

    public override string ToString()
    {
        return base.ToString() + $" Rate: {Math.Round(Rate, 2)}%";
    }
}
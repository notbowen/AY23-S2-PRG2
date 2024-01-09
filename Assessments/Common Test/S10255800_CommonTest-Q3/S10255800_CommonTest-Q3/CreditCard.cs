namespace S10255800_CommonTest_Q3;

public class CreditCard : Card, IPayable
{
    public int ExpiryMonth { get; }
    public int ExpiryYear { get; }
    public double CreditLimit { get; }
    public double Rebate { get; set; }

    public CreditCard()
    {
    }

    public CreditCard(string cardNumber, string cardHolderName, int expiryMonth, int expiryYear, double creditLimit) :
        base(cardNumber, cardHolderName)
    {
        ExpiryMonth = expiryMonth;
        ExpiryYear = expiryYear;
        CreditLimit = creditLimit;

        TotalPaid = 0;
        Rebate = 0;
    }

    public bool IsExpired()
    {
        DateTime today = DateTime.Now;
        return today.Month >= ExpiryMonth && today.Year >= ExpiryYear;
    }

    public override bool MakePayment(double amount)
    {
        if (amount > CreditLimit || IsExpired())
            return false;
        
        TotalPaid += amount;
        Rebate += 0.015 * amount;
        return true;
    }

    public override string ToString()
    {
        return $"Rebate: {Rebate}";
    }
}
class S10255800_Qn02
{
    static void Main(string[] args)
    {
        // Variables
        double amount, discounted_amt;
        int discount;

        // Prompt user for amount spent
        Console.Write("Enter amount\t($) : ");
        amount = Convert.ToDouble(Console.ReadLine());

        // Calculate discount given using if-else
        if (amount <= 100)
        {
            discount = 0;
        } else if (amount <= 500)
        {
            discount = 5;
        } else if (amount <= 1000)
        {
            discount = 10;
        } else
        {
            discount = 20;
        }

        // Display discount given in percentage
        Console.WriteLine("Discount given\t(%) : " + discount.ToString());

        // Calculate and display discount amount
        discounted_amt = amount * (discount / 100.0);
        Console.WriteLine("Discount amount\t($) : " + discounted_amt.ToString("0.00"));
    }
}
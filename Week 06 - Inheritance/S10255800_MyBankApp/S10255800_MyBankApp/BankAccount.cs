namespace S10255800_MyBankApp;

public class BankAccount
{
     public string AccNo { get; }
     public string AccName { get; }
     public double Balance { get; private set; }

     public BankAccount()
     {
          
     }

     public BankAccount(string accNo, string accName, double balance)
     {
          AccNo = accNo;
          AccName = accName;
          Balance = balance;
     }

     public void Deposit(double amount)
     {
          Balance += amount;
     }

     public bool Withdraw(double amount)
     {
          if (amount > Balance) return false;
          
          Balance -= amount;
          return true;
     }

     public override string ToString()
     {
          return $"Account No: {AccNo} Account Name: {AccName} Balance: {Balance:C}";
     }
}
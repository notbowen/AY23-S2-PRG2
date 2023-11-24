// My Bank App
// Written by: Hu Bowen
// Date: 21 Nov 2023

using S10255800_MyBankApp;

// Question 3a)
List<SavingsAccount> savingsAccCollection = new List<SavingsAccount>();

using (StreamReader sr = File.OpenText("savings_account.csv"))
{
    string? line = sr.ReadLine();
    while ((line = sr.ReadLine()) != null)
    {
        string[] data = line.Split(',');
        savingsAccCollection.Add(new SavingsAccount(data[0], data[1], Convert.ToDouble(data[2]),
            Convert.ToDouble(data[3])));
    }
}

// Question 3b)
void DisplayMenu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("[1] Display all accounts");
    Console.WriteLine("[2] Deposit");
    Console.WriteLine("[3] Withdraw");
    Console.WriteLine("[4] Display details");
    Console.WriteLine("[0] Exit");

    Console.Write("Enter option: ");
}

// Question 3c)
while (true)
{
    DisplayMenu();
    if (!int.TryParse(Console.ReadLine(), out int input))
    {
        Console.WriteLine("Invalid input!\n");
        continue;
    }

    Console.WriteLine();
    switch (input)
    {
        case 1: // Option 1: Display all Accounts
            DisplayAll(savingsAccCollection);
            break;

        case 2: // Option 2: Deposit
            Console.Write("Enter the Account Number: ");
            string accNo = Console.ReadLine();

            SavingsAccount? searchedAcc = Search(savingsAccCollection, accNo);
            if (searchedAcc == null)
            {
                Console.WriteLine("Unable to find account number. Please try again.");
                break;
            }

            Console.Write("Amount to deposit: ");
            double depAmt = Convert.ToDouble(Console.ReadLine());
            searchedAcc.Deposit(depAmt);

            Console.WriteLine($"{depAmt:C} deposited successfully\n{searchedAcc}");
            break;

        case 3: // Option 3: Withdraw
            Console.Write("Enter the Account Number: ");
            accNo = Console.ReadLine();

            searchedAcc = Search(savingsAccCollection, accNo);
            if (searchedAcc == null)
            {
                Console.WriteLine("Unable to find account number. Please try again.");
                break;
            }

            Console.Write("Amount to withdraw: ");
            double withdraw = Convert.ToDouble(Console.ReadLine());

            if (!searchedAcc.Withdraw(withdraw))
            {
                Console.WriteLine("Insufficient funds.");
                break;
            }

            Console.WriteLine($"{withdraw:C} withdrawn successfully\n{searchedAcc}");
            break;

        case 4: // Option 4: Display details
            Console.WriteLine("{0,-10} {1,-15} {2,-10:0.00} {3,-5:0.00} {4,10:0.00}", "Acc No", "Acc Name", "Balance",
                "Rate", "Interest");
            foreach (SavingsAccount savingsAccount in savingsAccCollection)
            {
                Console.WriteLine("{0,-10} {1,-15} {2,-10:0.00} {3,-5:0.00} {4,10:0.00}", savingsAccount.AccNo,
                    savingsAccount.AccName, savingsAccount.Balance, savingsAccount.Rate,
                    savingsAccount.CalculateInterest());
            }

            break;

        case 0:
            Console.WriteLine("---------\r\nGoodbye!\r\n---------");
            return;

        default:
            Console.WriteLine("Invalid input!\n");
            break;
    }

    Console.WriteLine();
}

// Option 2 Helper Function 1
void DisplayAll(List<SavingsAccount> sCollection)
{
    foreach (SavingsAccount savingsAccount in sCollection)
    {
        Console.WriteLine(savingsAccount);
    }
}

// Option 2 Helper Function 2
SavingsAccount? Search(List<SavingsAccount> savingsAccounts, string accNo)
{
    return savingsAccounts.FirstOrDefault(acc => acc.AccNo == accNo);
}
// Cash Card App
// Written By: Hu Bowen, S10255800
// Date: 31 Oct 2023

using S10255800_CashCardApp;

// Part A
List<CashCard> cardList = new List<CashCard>();

// Part B
void InitCardList(List<CashCard> cardList)
{
    CashCard c1 = new CashCard("001", 25);
    CashCard c2 = new CashCard("002", 25);
    CashCard c3 = new CashCard("003", 30);
    CashCard c4 = new CashCard("004", 30);
    CashCard c5 = new CashCard("005", 50);

    cardList.AddRange(new[] { c1, c2, c3, c4, c5 });
}

// Part C
InitCardList(cardList);

// Part D
foreach (CashCard card in cardList)
{
    Console.WriteLine(card + "\n");
}

// Part E
CashCard? Search(List<CashCard> cardList, string id)
{
    return cardList.FirstOrDefault(card => card.Id == id);
}

// Part F
Console.Write("Enter ID to search: ");
string id = Console.ReadLine();

CashCard? searchCard = Search(cardList, id);
if (searchCard == null)
{
    Console.WriteLine("No card with id of " + id + " found!");
    return;
}

Console.WriteLine("Card Balance: {0:C}", searchCard.Balance);
Console.Write("How much would you like to deduct? ($): ");

double amount = Convert.ToDouble(Console.ReadLine());
if (searchCard.Deduct(amount))
{
    Console.WriteLine("Successfully deducted {0:C}", amount);
    Console.WriteLine("Remaining Balance: {0:C}", searchCard.Balance);
}
else
{
    Console.WriteLine("Unable to deduct {0:C}", amount);
    Console.WriteLine("Balance remains at {0:C}", searchCard.Balance);
}

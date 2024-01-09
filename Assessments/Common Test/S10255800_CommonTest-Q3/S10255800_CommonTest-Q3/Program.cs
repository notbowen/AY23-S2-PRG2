using S10255800_CommonTest_Q3;

List<CreditCard> cardList = new List<CreditCard>(
    new []
    {
        new CreditCard("111", "Test", 12, 2024, 2.5),
        new CreditCard("112", "Test", 12, 2024, 3.5),
        new CreditCard("113", "Test", 12, 2024, 4.5),
    });

cardList.ForEach(card => card.Rebate = 0);
Console.WriteLine(string.Join("\n", cardList));
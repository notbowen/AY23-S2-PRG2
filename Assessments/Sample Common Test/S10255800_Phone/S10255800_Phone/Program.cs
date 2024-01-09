using S10255800_Phone;

List<Postpaid> phoneList = new List<Postpaid>( new []
{
    new Postpaid("98787654", 15, 2.4),
    new Postpaid("91231234", 25, 4.1),
    new Postpaid("88877765", 20, 3.5),
} );

Console.WriteLine(phoneList.Max());

// testing
Prepaid prepaid = new Prepaid("9999", 1.0);
prepaid.TopUpBalance(50);
prepaid.BuyData(10);
prepaid.BuyData(10);

Console.WriteLine(prepaid);
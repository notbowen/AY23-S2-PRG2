// PoS App
// Written by: Hu Bowen
// Date: 2 Jan 2024

using S10255800_PosApp;

// Q3a) & Q3b)
Dictionary<string, Product> productDict = new Dictionary<string, Product>(new[]
{
    new KeyValuePair<string, Product>("1001", new Product("1001", "Apple iPhone", 1088.00)),
    new KeyValuePair<string, Product>("1005", new Product("1005", "HTC Sensation", 888.00)),
    new KeyValuePair<string, Product>("1013", new Product("1013", "LG Optimus 2X", 788.00)),
    new KeyValuePair<string, Product>("1022", new Product("1022", "Motorola Atrix", 958.00)),
    new KeyValuePair<string, Product>("1027", new Product("1027", "Samsung Galaxy", 988.00)),
});

// Q3c)
ShoppingCart cart = new ShoppingCart();

// Q3d)
void DisplayMenu()
{
    Console.WriteLine("---------------- M E N U -----------------");
    Console.WriteLine("[1] List all products and prices");
    Console.WriteLine("[2] Add item to cart");
    Console.WriteLine("[3] View cart items");
    Console.WriteLine("[4] Remove item from cart");
    Console.WriteLine("[5] Clear cart items");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("------------------------------------------");
    Console.Write("Enter your option : ");
}

// Q3e)
while (true)
{
    DisplayMenu();
    string option = Console.ReadLine()!;
    Console.WriteLine();

    switch (option)
    {
        case "1":
            Option1();
            break;
        case "2":
            Option2();
            break;
        case "3":
            Option3();
            break;
        case "4":
            Option4();
            break;
        case "5":
            Option5();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Invalid Input!");
            break;
    }

    Console.WriteLine();
}

void Option1()
{
    Console.WriteLine("{0,-8} {1,-15} {2,-10}", "Code", "Name", "Price");
    foreach (Product product in productDict.Values)
    {
        Console.WriteLine("{0,-8} {1,-15} {2,-10:C}", product.Code, product.Name, product.Price);
    }
}

void Option2()
{
    Option1();

    Console.Write("\nEnter product code: ");
    string code = Console.ReadLine()!;

    Console.Write("Enter quantity: ");
    int qty = int.Parse(Console.ReadLine()!);

    CartItem item = new CartItem(code, productDict[code].Name, productDict[code].Price, qty);
    cart.AddItem(item);

    Console.WriteLine("Item added to shopping cart!");
}

void Option3()
{
    if (cart.GetItemList().Count == 0)
    {
        Console.WriteLine("No items in shopping cart!");
        return;
    }

    Console.WriteLine("{0,-8} {1,-15} {2,-10} {3,-10} {4,-10}", "Code", "Name", "Price", "Qty", "Total");
    foreach (CartItem item in cart.GetItemList())
    {
        Console.WriteLine("{0,-8} {1,-15} {2,-10:C} {3,-10} {4,-10:C}", item.Code, item.Name, item.Price, item.Qty,
            item.Price * item.Qty);
    }

    Console.WriteLine("Grand Total: {0:C}", cart.GetItemList().Sum(i => i.Price * i.Qty));
}

void Option4()
{
    Option3();

    Console.Write("\nEnter product code to remove: ");
    int code = int.Parse(Console.ReadLine()!);

    Console.WriteLine(cart.RemoveItem(code) ? "Item removed from shopping cart!" : "Item not found in shopping cart!");
    Console.WriteLine("Removed item from shopping cart!");
}

void Option5()
{
    cart.ClearCart();
    Console.WriteLine("Cart has been cleared!");
}
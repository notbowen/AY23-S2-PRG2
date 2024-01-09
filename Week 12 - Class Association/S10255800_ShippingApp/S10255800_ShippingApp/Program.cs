// Shipping App
// Written by: Hu Bowen
// Date: 2 Jan 2024

using S10255800_ShippingApp;

// Q2a)
List<Customer> customerList = new List<Customer>();

// Q2b)
void InitCustomerList(List<Customer> customers)
{
    customers.AddRange(new[]
    {
        new Customer("John Tan", "98501111", new ShippingAddr("Singapore", "Clementi Rd")),
        new Customer("Amy Lim", "99991111", new ShippingAddr("Hong Kong", "Mong Kok Rd")),
        new Customer("Tony Tay", "91112222", new ShippingAddr("Malaysia", "Malacca Rd")),
    });
}

// Q2c)
InitCustomerList(customerList);

// Q2d)
void ListCustomers(List<Customer> customers)
{
    Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Name", "Tel", "Country", "Street");
    foreach (Customer customer in customers)
    {
        Console.WriteLine(customer);
    }
}

// Q2e)
ListCustomers(customerList);
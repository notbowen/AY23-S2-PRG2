// Phone App
// Written by: Hu Bowen
// Date: 18 Nov 2023

using PhoneApp_S10255800;

// Part A
List<Phone> phones = new List<Phone>();

// Part B
void InitialisePhones()
{
    using (StreamReader sr = File.OpenText("PhoneDetails.csv"))
    {
        string? line = sr.ReadLine();
        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');
            phones.Add(new Phone(data[0], int.Parse(data[1]), data[2]));
        }
    }
}

InitialisePhones();

// Part C
void DisplayOutput()
{
    Console.WriteLine("{0, -10} {1, -10} {2, -10} {3}", "PhoneNo", "Usage", "PlanType", "PhoneCharge($)");
    foreach (Phone phone in phones)
    {
        Console.WriteLine("{0, -10} {1, -10} {2, -10} {3,14:0.00}", phone.PhoneNum, phone.Usage, phone.PlanType,
            Math.Round(phone.CalculateCharge(), 2));
    }
}

DisplayOutput();

// Part D
void UpdateUsage()
{
    Console.WriteLine("\nUpdate Phone Usage");
    Console.WriteLine("----------------");

    Console.Write("Enter phone no: ");
    string phoneNumber = Console.ReadLine();

    Phone? searchedNumber = phones.FirstOrDefault(phone => phone.PhoneNum == phoneNumber);

    if (searchedNumber == null)
    {
        Console.WriteLine("Phone not found!\n");
        return;
    }

    Console.WriteLine("Current Usage: " + searchedNumber.Usage);
    Console.Write("Enter new usage: ");

    searchedNumber.Usage = int.Parse(Console.ReadLine());
    Console.WriteLine("The new usage is updated successfully\n");
}

// Part D + E
while (true)
{
    UpdateUsage();
    DisplayOutput();
}
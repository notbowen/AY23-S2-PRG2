// My Telephone Directory
// Name: Hu Bowen, S10255800
// Date: 17 Oct 2023

// Imports
using System.Text.RegularExpressions;

// Helper functions
string Input(string displayText)
{
    Console.Write(displayText);
    var input = Console.ReadLine();

    if (input == null)
    {
        Environment.Exit(0);
    }

    return input;
} 

// Variables
var toAppend = new Dictionary<string, string>();
var phoneDict = new Dictionary<string, string>();

#region Part A

// Prompt user for names & phone numbers + append
Console.WriteLine("===== My Telephone Directory =====");
while (true)
{
    // Get name and exit if name is "exit"
    var name = Input("Name (type exit to exit): ");

    if (name.ToLower() == "exit")
        break;
    
    // Get phone number & check if it's a valid Singapore number
    var num = Input("Phone number: ");

    if (!Regex.IsMatch(num, @"^(6|8|9)\d{7}$"))
    {
        Console.WriteLine("Invalid phone number!");
        continue;
    }
    
    // Add values to toAppend
    toAppend.Add(name, num);
}

// Write values to .csv file
if (!File.Exists("PhoneDirectory.csv"))
{
    // Create file if it does not exist
    File.WriteAllText("PhoneDirectory.csv", "Name,Phone Number\n");
}
else
{
    // If file exists, check if it ends with \n
    var lastTwoBytes = new byte[2];
    using (var fs = new FileStream("PhoneDirectory.csv", FileMode.Open, FileAccess.Read))
    {
        if (fs.Length > 1)
        {
            fs.Seek(-2, SeekOrigin.End);
            fs.Read(lastTwoBytes, 0, 2);
        }
    }

    if (lastTwoBytes[1] != '\n')
    {
        File.AppendAllText("PhoneDirectory.csv", "\n");
    }
}


// Append data to the file, but filter out any entries with blank keys or values
File.AppendAllLines("PhoneDirectory.csv", toAppend
    .Select(s => s.Key + "," + s.Value));

#endregion

#region Part B

// Read CSV file into phoneDict
using (var reader = new StreamReader("PhoneDirectory.csv"))
{
    while (true)
    {
        // Read line by line till EOF
        var line = reader.ReadLine();
        if (line == null)
            break;

        // Destructure the CSV values into variables
        var values = line.Split(",");
        var name = values[0];
        var num = values[1];
        
        // Skip header
        if (name == "Name" && num == "Phone Number")
            continue;
        
        // Store name & num into dictionary
        phoneDict[name] = num;
    }
}

// Display the contents of dictionary
Console.WriteLine("\n===== Contents of phoneDict =====");
Console.WriteLine(string.Join("\n", phoneDict.Select(x => x.Key + ": " + x.Value)));
Console.WriteLine("=================================");

#endregion

#region Part C

// TODO: Ask cher if I can directly copy from phoneDict since the code will be repeated anyway

// Initialise SortedList with values in the Dictionary
var phoneList = new SortedList<string, string>(phoneDict);

// Display the contents of dictionary
Console.WriteLine("\n===== Contents of phoneList =====");
Console.WriteLine(string.Join("\n", phoneDict.Select(x => x.Key + ": " + x.Value)));
Console.WriteLine("=================================");

#endregion

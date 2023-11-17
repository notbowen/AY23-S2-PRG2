// Library Loan
// Written by: Hu Bowen, S10255800
// Date: 19 Oct 2023

// Function to read from CSV
List<List<string>> ReadCsv(string filePath, bool skipHeader = false)
{
    var result = new List<List<string>>();

    using var sr = new StreamReader(filePath);
    while (!sr.EndOfStream)
    {
        // Read a line and check for null
        var line = sr.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) continue;
        
        // Skip header if toggled
        if (skipHeader)
        {
            skipHeader = false;
            continue;
        }
            
        // Split data into a list of strings and append
        var columns = line.Split(',').ToList();
        result.Add(columns);
    }

    return result;
} 

// Read and append headers
var data = ReadCsv("loaninfo.csv");
data[0].AddRange(new List<string> { "Days Loan", "Days Overdue", "Fine" });

// Loop and calculate overdue dates
for (var i = 1; i < data.Count; i++)
{
    // Extract dates from data
    var dateBorrowed = DateTime.Parse(data[i][2]);
    var dateReturned = DateTime.Parse(data[i][3]);

    // Calculate difference in dates
    var difference = dateReturned - dateBorrowed;
    
    // Extract the days loaned and fines (if any)
    var daysLoan = difference.Days;
    var daysOverdue = daysLoan - 14;
    var fine = daysOverdue * 0.5;
    
    // Append the data to the list
    data[i].Add(daysLoan.ToString());
    data[i].Add(daysOverdue > 0 ? daysOverdue.ToString() : "");
    data[i].Add(daysOverdue > 0 ? $"{fine:N2}" : "");
}

// Display data
foreach (var row in data)
{
    foreach (var cell in row)
    {
        Console.Write(cell.PadRight(18));
    }

    Console.WriteLine();
}

// Open the file & create it if it doesn't exist
var fs = !File.Exists("overdueinfo.csv") ? new FileStream("overdueinfo.csv", FileMode.Create, FileAccess.Write) : new FileStream("overdueinfo.csv", FileMode.Open, FileAccess.Write);

// Write data to file
using var sw = new StreamWriter(fs);
foreach (var row in data)
{
    sw.WriteLine(string.Join(',', row).TrimEnd(','));
}
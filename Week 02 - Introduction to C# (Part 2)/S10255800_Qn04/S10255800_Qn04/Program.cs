// Distance-Based Fares
// Written By: Hu Bowen, S10255800
// Date: 20 Oct 2023

// Helper Functions
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

int GetInt(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var success = int.TryParse(Console.ReadLine(), out var input);

        if (success)
        {
            return input;
        }
        
        Console.WriteLine("Invalid Input!");
    }
}

string GetStop(string prompt, IReadOnlyDictionary<string, double> busDistance)
{
    while (true)
    {
        var input = GetInt(prompt).ToString();
        if (busDistance.ContainsKey(input))
            return input;
        Console.WriteLine("Invalid bus stop number!");
    }
}

// Load bus stops & distance fare
var busStops = ReadCsv("bus_174.csv");
var distanceFare = ReadCsv("distance-based-fare.csv", true);

// Load bus stop distance & fare into a SortedList
var busDistance = new SortedList<string, double>();
for (var i = 1; i < busStops.Count; i++)
{
    busDistance[busStops[i][1]] = Convert.ToDouble(busStops[i][0]);
}

// Print out the bus stop data
foreach (var row in busStops)
{
    foreach (var cell in row)
    {
        Console.Write(cell.PadRight(23));
    }

    Console.WriteLine();
}

// Ask for boarding & alighting stops (Uses GetInt for input validation)
var boarding = GetStop("\nEnter boarding bus stop: ", busDistance);
var alighting = GetStop("Enter alighting bus stop: ", busDistance);

// Calculate distance
var distance = busDistance[alighting] - busDistance[boarding];

// Calculate fare based on distance
var fare = 2.01; // Set default to 201 as that is the case the for loop does not cover
foreach (var row in distanceFare)
{
    var dist = Convert.ToDouble(row[0]);
    if (dist >= distance)
    {
        fare = Convert.ToDouble(row[1]) / 100;
        break;
    }
}

// Display data
Console.WriteLine("Distance travelled: {0}km", Math.Round(distance, 2));
Console.WriteLine("Fare to pay: {0:C}", fare);
Console.WriteLine("Estimated duration: {0}mins", Math.Ceiling(distance * 4));
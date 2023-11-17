// Fare Calculator App
// Written By: Hu Bowen, S10255800
// Date: 31 Oct 2023

// Imports
using S10255800_FareCalculatorApp;

// Variables
BusStopDict busStops = new BusStopDict();  // Custom class to search
List<Fare> fares = new List<Fare>();  // Uses a List for ease of use

// Parse CSV into BusStop and Fare classes
using (StreamReader sr = File.OpenText("bus_174.csv"))
{
    string? line = sr.ReadLine();
    while ((line = sr.ReadLine()) != null)
    {
        string[] data = line.Split(',');
        BusStop busStop = new BusStop(Convert.ToDouble(data[0]), data[1], data[2], data[3]);
        busStops.Add(data[1], busStop);
    }
}

using (StreamReader sr = File.OpenText("distance-based-fare.csv"))
{
    string? line = sr.ReadLine();
    while ((line = sr.ReadLine()) != null)
    {
        string[] data = line.Split(',');
        Fare fare = new Fare(Convert.ToDouble(data[0]), int.Parse(data[1]));
        fares.Add(fare);
    }
}

// Print out bus stops
Console.WriteLine("{0,-15} {1,-15} {2,-20} {3}", "Distance (km)", "Bus Stop Code", "Road", "Bus Stop Description");
foreach (KeyValuePair<string, BusStop> busStop in busStops)
{
    Console.WriteLine(busStop.Value);
}
Console.WriteLine();

// Get bus stops from user
BusStop boarding = busStops.GetStopFromInput("Enter boarding bus stop: ");
BusStop arrival = busStops.GetStopFromInput("Enter arrival bus stop: ");

// Check if arrival stop is before boarding stop
// Swap if it is
if (boarding > arrival)
{
    Console.WriteLine("The boarding stop is after the destination stop!");
    Console.WriteLine("Swapping stops...");

    (boarding, arrival) = (arrival, boarding);
}

// Get the distance between the stops
double distance = arrival - boarding;

// Calculate price based on distance
Fare fareToPay = fares.Last();
foreach (Fare fare in fares)
{
    if (fare.UpToDistance >= distance)
    {
        fareToPay = fare;
        break;
    }
}

// Display distance travelled + price
Console.WriteLine("Distance travelled: {0:0.0}km", distance);
Console.WriteLine("Fare to pay: {0:C}", fareToPay.Amount);

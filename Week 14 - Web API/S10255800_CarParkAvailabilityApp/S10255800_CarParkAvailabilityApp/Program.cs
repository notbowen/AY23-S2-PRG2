// Carpark Availability App
// Author: Hu Bowen
// Date: 20 Jan 2024

// Libraries
using System.Text.Json;
using S10255800_CarParkAvailabilityApp;

// Main Program
using HttpClient client = new();
const string url = "https://api.data.gov.sg/v1/transport/carpark-availability";

var response = await ProcessDataAsync<Data.RootObject>(client, url);
var data = response.items[0];

Console.WriteLine("{0,15} {1,15} {2,15} {3,15}", "carpark_number", "total_lots", "lot_type", "lots_available");
foreach (var carpark in data.carpark_data)
{
    var info = carpark.carpark_info[0];
    Console.WriteLine("{0,15} {1,15} {2,15} {3,15}", carpark.carpark_number, info.total_lots, info.lot_type,
        info.lots_available);
}


// Async data processor
static async Task<T> ProcessDataAsync<T>(HttpClient client, string url)
{
    await using var stream = await client.GetStreamAsync(url);
    var obj = await JsonSerializer.DeserializeAsync<T>(stream);
    return obj;
}
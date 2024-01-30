// WebAPIClient
// Written by: Hu Bowen
// Date: 20 Jan 2024

// Libraries
using System.Text.Json;
using S10255800_WebAPIClient;

// Main Program
using HttpClient client = new();
const string url = "https://api.data.gov.sg/v1/environment/24-hour-weather-forecast";

var forecast = await ProcessDataAsync<Data.RootObject>(client, url);
var data = forecast.items[0];

Console.WriteLine($"Weather forecast from {data.valid_period.start} to {data.valid_period.end}");
Console.WriteLine($"{data.general.forecast}");

foreach (var period in data.periods)
{
    Console.WriteLine($"{period.time.start:h:mm tt} - {period.time.end:h:mm tt}");
    Console.WriteLine($"west: {period.regions.west}");
    Console.WriteLine($"east: {period.regions.east}");
    Console.WriteLine($"central: {period.regions.central}");
    Console.WriteLine($"south: {period.regions.south}");
    Console.WriteLine($"north: {period.regions.north}");
}

// Async data processing
static async Task<T> ProcessDataAsync<T>(HttpClient client, string url)
{
    await using var stream = await client.GetStreamAsync(url);
    var obj = await JsonSerializer.DeserializeAsync<T>(stream);
    return obj;
}
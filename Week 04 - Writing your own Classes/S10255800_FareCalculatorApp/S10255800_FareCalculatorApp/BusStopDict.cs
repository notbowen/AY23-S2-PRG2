namespace S10255800_FareCalculatorApp;

public class BusStopDict : Dictionary<string, BusStop>
{
    BusStop? GetBusStop(string code)
    {
        if (ContainsKey(code))
            return this[code];
        return null;
    }

    public BusStop GetStopFromInput(string prompt)
    {
        BusStop stop;
        while (true)
        {
            Console.Write(prompt);
            if ((stop = GetBusStop(Console.ReadLine())) != null)
                return stop;
            Console.WriteLine("Invalid stop code entered!");
        }
    }
}
namespace S10255800_HospitalApp;

public class Room
{
    public string Location { get; }
    public string WardClass { get; }

    public Room()
    {
    }
    
    public Room(string location, string wardClass)
    {
        Location = location;
        WardClass = wardClass;
    }

    public override string ToString()
    {
        return $"{Location,-10} {WardClass,-10}";
    }
}
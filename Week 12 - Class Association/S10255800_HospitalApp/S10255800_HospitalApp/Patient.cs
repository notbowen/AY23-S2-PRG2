namespace S10255800_HospitalApp;

public class Patient : Person
{
    public Room WardedAt { get; }
    
    public Patient()
    {
    }
    
    public Patient(string nric, string name, Room wardedAt) : base(nric, name)
    {
        WardedAt = wardedAt;
    }
    
    public override string ToString()
    {
        return base.ToString() + " " + WardedAt.Location;
    }
}
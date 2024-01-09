namespace S10255800_HospitalApp;

public class Person
{
    public string Nric { get; }
    public string Name { get; }

    public Person()
    {
    }
    
    public Person(string nric, string name)
    {
        Nric = nric;
        Name = name;
    }
    
    public override string ToString()
    {
        return $"{Nric,-13} {Name,-15}";
    }
}
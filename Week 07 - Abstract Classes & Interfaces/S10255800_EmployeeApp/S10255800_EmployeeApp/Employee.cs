namespace S10255800_EmployeeApp;

public abstract class Employee : IComparable<Employee>
{
    public int Id { get; }
    public string Name { get; }

    public Employee()
    {
    }
    
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract double CalculatePay();
    
    public int CompareTo(Employee other)
    {
        // Compare string and ignore the case
        return String.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }
    
    public override string ToString()
    {
        return $"Id: {Id}\tName: {Name}";
    }
}
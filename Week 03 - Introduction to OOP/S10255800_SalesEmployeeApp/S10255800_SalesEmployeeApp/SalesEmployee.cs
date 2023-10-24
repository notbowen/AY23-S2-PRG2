namespace S10255800_SalesEmployeeApp;

public class SalesEmployee
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public double BasicSalary { get; private set; }
    public double Sales { get; private set; }

    public SalesEmployee(int id, string name, double basicSalary, double sales)
    {
        Id = id;
        Name = name;
        BasicSalary = basicSalary;
        Sales = sales;
    }
}
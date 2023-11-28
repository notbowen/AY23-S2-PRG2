namespace S10255800_EmployeeApp;

public class PartTimeEmployee : Employee
{
    public double DailyRate { get; }
    public int DaysWorked { get; }
    
    public PartTimeEmployee()
    {
    }
    
    public PartTimeEmployee(int id, string name, double dailyRate, int daysWorked) : base(id, name)
    {
        DailyRate = dailyRate;
        DaysWorked = daysWorked;
    }
    
    public override double CalculatePay()
    {
        return DaysWorked * DailyRate;
    }
    
    public override string ToString()
    {
        return base.ToString() + $"\tDaily Rate: {DailyRate}\tDays Worked: {DaysWorked}";
    }
}
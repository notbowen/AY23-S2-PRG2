namespace S10255800_CommonTest_Q1;

public class Employee
{
    public string EmpId { get; }
    public int Hours { get; }
    public double Rate { get; }

    public Employee()
    {
    }

    public Employee(string empId, int hours)
    {
        EmpId = empId;
        Hours = hours;
        Rate = 7.5;
    }

    public double CalculatePay()
    {
        int bonus = Math.Max(Hours - 4, 0);
        return Hours * Rate + 10 * bonus;
    }

    public override string ToString()
    {
        return $"Payment due to Employee #{EmpId}: {CalculatePay():C}.";
    }
}
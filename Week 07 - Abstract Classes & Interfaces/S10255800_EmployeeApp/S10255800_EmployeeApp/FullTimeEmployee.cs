namespace S10255800_EmployeeApp;

public class FullTimeEmployee : Employee
{
    public double BasicPay { get; }
    public double Allowance { get; }

    public FullTimeEmployee()
    {
    }
    
    public FullTimeEmployee(int id, string name, double basicPay, double allowance) : base(id, name)
    {
        BasicPay = basicPay;
        Allowance = allowance;
    }
    
    public override double CalculatePay()
    {
        return BasicPay + Allowance;
    }

    public override string ToString()
    {
        return base.ToString() + $"\tBasic Pay: {BasicPay}\tAllowance: {Allowance}";
    }
}
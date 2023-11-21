namespace PhoneApp_S10255800;

public class Phone
{
    public string PhoneNum { get; }
    public int Usage { get; set; }
    public string PlanType { get; }

    public Phone()
    {
    }

    public Phone(string phoneNum, int usage, string planType)
    {
        PhoneNum = phoneNum;
        Usage = usage;
        PlanType = planType;
    }

    public double CalculateCharge()
    {
        int threshold = 0;
        double connRate = 0.5;

        switch (PlanType)
        {
            case "B":
                threshold = 1000;
                connRate = 0.2;
                break;
            case "C":
                threshold = 5000;
                connRate = 0.1;
                break;
        }

        int finalUsage = Math.Max(Usage - threshold, 0);
        return (finalUsage * connRate) / 100;
    }

    public override string ToString()
    {
        return $"{PhoneNum,-10} {Usage,-10} {PlanType,-10}";
    }
}
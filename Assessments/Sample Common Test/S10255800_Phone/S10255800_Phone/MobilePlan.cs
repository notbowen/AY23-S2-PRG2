namespace S10255800_Phone;

public abstract class MobilePlan
{
    protected string Number { get; init; }
    protected int Data { get; set;  }
    protected double RoamingData { get; init; }

    protected MobilePlan()
    {
    }

    protected MobilePlan(string number, int data, double roamingData)
    {
        Number = number;
        Data = data;
        RoamingData = roamingData;
    }

    public abstract double RoamingCharges();

    public override string ToString()
    {
        return $"{Number} has {Data} GB";
    }
}
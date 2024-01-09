namespace S10255800_Phone;

public class Postpaid : MobilePlan, IComparable<Postpaid>
{
    public Postpaid()
    {
    }

    public Postpaid(string number, int data, double roamingData)
    {
        Number = number;
        Data = data;
        RoamingData = roamingData;
    }

    public override double RoamingCharges()
    {
        double remaining = Math.Max(RoamingData - 1, 0);
        return remaining * 8;
    }

    public int CompareTo(Postpaid other)
    {
        return RoamingData.CompareTo(other.RoamingData);
    }

    public override string ToString()
    {
        return $"Number: {Number}\tData: {Data}\tRoamingData: {RoamingData:F1}\tRoamingCharge: {RoamingCharges():F2}";
    }
}
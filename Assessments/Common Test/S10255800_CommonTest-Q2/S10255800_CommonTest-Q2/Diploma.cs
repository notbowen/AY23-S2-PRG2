namespace S10255800_CommonTest_Q2;

public class Diploma
{
    public string Title { get; }
    public int EnrolYear { get; }
    public int MaxEnrolment { get; }

    public Diploma()
    {
    }

    public Diploma(string title, int enrolYear, int maxEnrolment)
    {
        Title = title;
        EnrolYear = enrolYear;
        MaxEnrolment = maxEnrolment;
    }

    public override string ToString()
    {
        return EnrolYear + " " + Title;
    }
}
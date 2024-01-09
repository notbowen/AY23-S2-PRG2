namespace S10255800_CommonTest_Q2;

public class Cohort : Diploma
{
    public Queue<string> StudentQueue { get; }

    public Cohort() : base()
    {
    }

    public Cohort(string title, int enrolYear, int maxEnrolment) : base(title, enrolYear, maxEnrolment)
    {
        StudentQueue = new Queue<string>();
    }

    public void EnrolStudent(string student)
    {
        if (StudentQueue.Count >= MaxEnrolment)
        {
            Console.WriteLine("Max number of students reached.");
            return;
        }
        
        StudentQueue.Enqueue(student);
    }

    public override string ToString()
    {
        return $"Students enrolled in {base.ToString()} are: \n" + string.Join("\n", StudentQueue);
    }
}
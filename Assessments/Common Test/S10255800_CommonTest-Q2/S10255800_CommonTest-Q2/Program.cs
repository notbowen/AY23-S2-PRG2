// Imports
using S10255800_CommonTest_Q2;

// Prompt user for cohort information
Console.Write("Enter the course title: ");
string title = Console.ReadLine()!;

Console.Write("Enter the enrolment year: ");
int year = int.Parse(Console.ReadLine()!);

Console.Write("Enter the max enrolment: ");
int maxEnrolment = int.Parse(Console.ReadLine()!);

// Create the cohort and notify user
Cohort cohort = new Cohort(title, year, maxEnrolment);
Console.WriteLine($"The course {cohort.Title} with max enrolment " + 
                  $"{cohort.MaxEnrolment} students has been created.\n");

// Loop and add 10 new students to the cohort
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i+1}. Enter name: ");
    cohort.EnrolStudent(Console.ReadLine()!);
}
Console.WriteLine();

// Display cohort information
Console.WriteLine(cohort);
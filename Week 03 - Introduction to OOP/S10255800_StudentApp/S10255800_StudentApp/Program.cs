// Student App
// Written By: Hu Bowen, S10255800
// Date: 24 Oct 2023

using S10255800_StudentApp;

#region Part A

// Create 5 student objects
DateTime dob1 = new DateTime(2000, 10, 13);
Student s1 = new Student(1, "John Tan", "88552211", dob1);

DateTime dob2 = new DateTime(2001, 11, 1);
Student s2 = new Student(2, "Peter Lim", "85678141", dob2);

DateTime dob3 = new DateTime(2000, 1, 3);
Student s3 = new Student(3, "David Chan", "88555461", dob3);

DateTime dob4 = new DateTime(2000, 7, 5);
Student s4 = new Student(4, "Muhammed Faizal", "98762211", dob4);

DateTime dob5 = new DateTime(2000, 8, 9);
Student s5 = new Student(5, "Esther Eng", "83352245", dob5);

#endregion

#region Part B

// Print out information for each student
Console.WriteLine("===== Part B =====");

const int padding = 18;
Console.WriteLine("ID".PadRight(padding - 10) + "Name".PadRight(padding) + "Tel".PadRight(padding - 5) + "Date of Birth".PadRight(padding));
Console.WriteLine(s1.Id.ToString().PadRight(padding - 10) + s1.Name.PadRight(padding) + s1.Tel.PadRight(padding - 5) + s1.DateOfBirth.ToString("dd/MM/yyyy").PadRight(padding));
Console.WriteLine(s2.Id.ToString().PadRight(padding - 10) + s2.Name.PadRight(padding) + s2.Tel.PadRight(padding - 5) + s2.DateOfBirth.ToString("dd/MM/yyyy").PadRight(padding));
Console.WriteLine(s3.Id.ToString().PadRight(padding - 10) + s3.Name.PadRight(padding) + s3.Tel.PadRight(padding - 5) + s3.DateOfBirth.ToString("dd/MM/yyyy").PadRight(padding));
Console.WriteLine(s4.Id.ToString().PadRight(padding - 10) + s4.Name.PadRight(padding) + s4.Tel.PadRight(padding - 5) + s4.DateOfBirth.ToString("dd/MM/yyyy").PadRight(padding));
Console.WriteLine(s5.Id.ToString().PadRight(padding - 10) + s5.Name.PadRight(padding) + s5.Tel.PadRight(padding - 5) + s5.DateOfBirth.ToString("dd/MM/yyyy").PadRight(padding));

Console.WriteLine("==================\n");

#endregion

#region Part C

List<Student> studentList = new List<Student> { s1, s2, s3, s4, s5 };

#endregion

#region Part D

void DisplayOutput(List<Student> sList)
{
    // Print header    
    Console.WriteLine("ID".PadRight(padding - 10) + "Name".PadRight(padding) + "Tel".PadRight(padding - 5) + "Date of Birth".PadRight(padding));
    
    // Loop through list and print values
    foreach (var student in sList)
    {
        Console.Write(student.Id.ToString().PadRight(padding - 10));
        Console.Write(student.Name.PadRight(padding));
        Console.Write(student.Tel.PadRight(padding - 5));
        Console.Write(student.DateOfBirth.ToString("dd/MM/yyyy").PadRight(padding));
        Console.WriteLine();
    }
}

Console.WriteLine("===== Part D =====");
DisplayOutput(studentList);
Console.WriteLine("==================\n");

#endregion

#region Part E
Console.WriteLine("===== Part E =====");

// Function that returns a Student object from the user
Student GetStudent()
{
    // Prompt the user for ID, name, phone & DoB
    int id;
    while (true)
    {
        Console.Write("Enter student ID: ");
        if (int.TryParse(Console.ReadLine(), out id))
            break;
        
        Console.WriteLine("ID must be a number!");
    }
    
    Console.Write("Enter student's name: ");
    var name = Console.ReadLine();
    
    Console.Write("Enter student's phone number: ");
    var tel = Console.ReadLine();

    DateTime dob;
    while (true)
    {
        Console.Write("Enter student's date of birth: ");

        if (DateTime.TryParse(Console.ReadLine(), out dob))
            break;
        
        Console.WriteLine("Invalid date of birth!");
    }
    
    // Initialise & return Student object
    var newStudent = new Student(id, name, tel, dob);
    return newStudent;
}

// Create new student & add to list
var newStudent = GetStudent();
studentList.Add(newStudent);

// Display updated studentList
Console.WriteLine();
DisplayOutput(studentList);

Console.WriteLine("==================\n");
#endregion

#region Part F
Console.WriteLine("===== Part F =====");

// Initialise studentList2
var studentList2 = new List<Student>();

// Read CSV file & create Student objects
var sr = new StreamReader("Students.csv");
sr.ReadLine();  // Skip the header

while (sr.ReadLine() is { } line)
{
    var data = line.Split(",");
    studentList2.Add(new Student(int.Parse(data[0]), data[1], data[2], DateTime.Parse(data[3])));
}

// Display newly added students
DisplayOutput(studentList2);

Console.WriteLine("==================");
#endregion
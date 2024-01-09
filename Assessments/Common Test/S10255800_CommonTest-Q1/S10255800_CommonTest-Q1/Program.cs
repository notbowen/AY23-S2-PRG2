// Imports
using S10255800_CommonTest_Q1;

// Prompt user for employee values
Console.Write("Enter Employee ID: ");
string id = Console.ReadLine()!;  // ! to suppress IDE warning

Console.Write("Enter the hours worked: ");
int hours = int.Parse(Console.ReadLine()!);

// Initialise employee with values and print out data
Employee employee = new Employee(id, hours);
Console.WriteLine(employee);

// employee.ToString() handles the output. Alternative way:
Console.WriteLine($"Payment due to Employee #{employee.EmpId}:" + 
                  $" {employee.CalculatePay():C}.");
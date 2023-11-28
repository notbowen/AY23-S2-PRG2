// Employee App
// Written by: Hu Bowen
// Date: 28 Nov 2023

using S10255800_EmployeeApp;

// Q6a)
SortedList<int, Employee> employees = new SortedList<int, Employee>
{
    { 103, new FullTimeEmployee(103, "John", 1500, 100) },
    { 101, new PartTimeEmployee(101, "Mary", 50, 10) },
    { 102, new PartTimeEmployee(102, "Bob", 55, 20) }
};

// Q6b)
Console.WriteLine("===== SortedList of Employees =====");
foreach(KeyValuePair<int, Employee> employee in employees)
{
    Console.WriteLine(employee.Value);
}
Console.WriteLine();

// Q6c)
List<Employee> employeesList = new List<Employee>(employees.Values);

// Q6d)
employeesList.Sort();

// Q6e)
Console.WriteLine("===== List of Employees =====");
foreach(Employee employee in employeesList)
{
    Console.WriteLine(employee);
}
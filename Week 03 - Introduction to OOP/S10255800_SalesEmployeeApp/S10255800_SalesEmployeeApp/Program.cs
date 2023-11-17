// Sales Employee App
// Written By: Hu Bowen, S10255800
// Date: 24 Oct 2023

using S10255800_SalesEmployeeApp;

// Part A: Create 5 employees according to the table
var angie = new SalesEmployee(101, "Angie", 1200, 15000);
var cindy = new SalesEmployee(105, "Cindy", 1000, 12000);
var david = new SalesEmployee(108, "David", 1500, 20000);
var jason = new SalesEmployee(112, "Jason", 3000, 30000);
var vivian = new SalesEmployee(127, "Vivian", 2000, 25000);

// Part B: Create a dict and store employee data there
var employeeDict = new Dictionary<int, SalesEmployee>
{
    { angie.Id, angie },
    { cindy.Id, cindy },
    { david.Id, david },
    { jason.Id, jason },
    { vivian.Id, vivian }
};

// Part C: Display the contents of employeeDict
foreach (var employee in employeeDict)
{
    Console.WriteLine("ID: " + employee.Key);
    Console.WriteLine("Name: " + employee.Value.Name);
    Console.WriteLine("Basic Salary: " + employee.Value.BasicSalary);
    Console.WriteLine("Sales : " + employee.Value.Sales);
    Console.WriteLine();
}
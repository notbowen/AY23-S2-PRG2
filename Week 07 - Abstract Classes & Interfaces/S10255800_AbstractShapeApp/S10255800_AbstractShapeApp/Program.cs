// Abstract Shape App
// Written by: Hu Bowen
// Date: 28 Nov 2023

using S10255800_AbstractShapeApp;

// Q2a)
List<Circle> circleList = new List<Circle>();

// Q2b)
void InitCircleList(List<Circle> cList)
{
    // i)
    Circle circle1 = new Circle("Red", 20.0);
    Circle circle2 = new Circle("Green", 10.0);
    Circle circle3 = new Circle("Blue", 30.0);

    // ii)
    cList.AddRange(new[] { circle1, circle2, circle3 });
}

// Q3c)
InitCircleList(circleList);

// Q3d)
while (true)
{
    Display();
    if (!int.TryParse(Console.ReadLine(), out int option))
    {
        Console.WriteLine("Invalid option!");
        continue;
    }
    
    if (!circleList.Any() && option != 5)
    {
        Console.WriteLine("No circles in the list!");
        continue;
    }
    
    if (option == 0)
    {
        break;
    }
    
    switch (option)
    {
        case 1:
            Option1();
            break;
        case 2:
            Option2();
            break;
        case 3:
            Option3();
            break;
        case 4:
            Option4();
            break;
        case 5:
            Option5();
            break;
        case 6:
            Option6();
            break;
        case 7:
            Option7();
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }
    
    Console.WriteLine();
}

// Helper Functions
void Display()
{
    Console.WriteLine("---------------- M E N U --------------------");
    Console.WriteLine("[1] List all the circles");
    Console.WriteLine("[2] Display the areas of the circles");
    Console.WriteLine("[3] Display the perimeters of the circles");
    Console.WriteLine("[4] Change the size of a circle");
    Console.WriteLine("[5] Add a new circle");
    Console.WriteLine("[6] Delete a circle");
    Console.WriteLine("[7] Display circles sorted by area");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("---------------------------------------------");

    Console.Write("Enter your option: ");
}

void Option1()
{
    foreach (Circle circle in circleList)
    {
        Console.WriteLine(circle);
    }
}

void Option2()
{
    foreach (Circle circle in circleList)
    {
        Console.WriteLine(circle + $" Area: {circle.FindArea():F2}");
    }
}

void Option3()
{
    foreach (Circle circle in circleList)
    {
        Console.WriteLine(circle + $" Perimeter: {circle.FindPerimeter():F2}");
    }
}

void Option4()
{
    Option1();
    
    Console.Write("Enter circle number: ");
    if (!int.TryParse(Console.ReadLine(), out int circleNum))
    {
        Console.WriteLine("Invalid circle number!");
        return;
    }
    
    if (circleNum < 1 || circleNum > circleList.Count)
    {
        Console.WriteLine("Invalid circle number!");
        return;
    }
    
    Console.Write("Enter new radius: ");
    if (!double.TryParse(Console.ReadLine(), out double newRadius))
    {
        Console.WriteLine("Invalid radius!");
        return;
    }
    
    circleList[circleNum - 1].Radius = newRadius;
    Console.WriteLine("Radius successfully changed.");
}

void Option5()
{
    Console.Write("Circle color: ");
    string color = Console.ReadLine();
    
    Console.Write("Circle radius: ");
    if (!double.TryParse(Console.ReadLine(), out double radius))
    {
        Console.WriteLine("Invalid radius!");
        return;
    }
    
    circleList.Add(new Circle(color, radius));
    Console.WriteLine($"New {color} circle with radius {radius}cm added.");
}

void Option6()
{
    Option1();
    
    Console.Write("Enter circle number: ");
    if (!int.TryParse(Console.ReadLine(), out int circleNum))
    {
        Console.WriteLine("Invalid circle number!");
        return;
    }
    
    if (circleNum < 1 || circleNum > circleList.Count)
    {
        Console.WriteLine("Invalid circle number!");
        return;
    }
    
    circleList.RemoveAt(circleNum - 1);
    Console.WriteLine("Circle removed.");
}

void Option7()
{
    circleList.Sort();
    Option2();
}
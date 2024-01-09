// Shape App
// Written by: Hu Bowen
// Date: 5 Dec 2023

using S10255800_AbstractShapeApp;

// Q3a)
List<Shape> shapeList = new List<Shape>();

// Q3b)
void InitShapeList(List<Shape> cList)
{
    // i) to vi)
    Shape shape1 = new Circle("Red", 20.0);
    Shape shape2 = new Square("Red", 10.0);
    Shape shape3 = new Circle("Green", 10.0);
    Shape shape4 = new Square("Green", 20.0);
    Shape shape5 = new Circle("Blue", 30.0);
    Shape shape6 = new Square("Blue", 30.0);

    // vii)
    cList.AddRange(new[] { shape1, shape2, shape3, shape4, shape5, shape6 });
}

// Q3c)
InitShapeList(shapeList);

// Q3d)
while (true)
{
    Display();
    if (!int.TryParse(Console.ReadLine(), out int option))
    {
        Console.WriteLine("Invalid option!");
        continue;
    }
    
    if (!shapeList.Any() && option != 5)
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
    Console.WriteLine("[1] List all the shapes");
    Console.WriteLine("[2] Display the areas of the shapes");
    Console.WriteLine("[3] Display the perimeters of the shapes");
    Console.WriteLine("[4] Change the sizes of the shapes");
    Console.WriteLine("[5] Add a new circle");
    Console.WriteLine("[6] Delete a circle");
    Console.WriteLine("[7] Display shapes sorted by area");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("---------------------------------------------");

    Console.Write("Enter your option: ");
}

void Option1()
{
    foreach (Shape shape in shapeList)
    {
        Console.WriteLine(shape);
    }
}

void Option2()
{
    foreach (Shape shape in shapeList)
    {
        Console.WriteLine(shape + $" Area: {shape.FindArea():F2}");
    }
}

void Option3()
{
    foreach (Shape shape in shapeList)
    {
        Console.WriteLine(shape + $" Perimeter: {shape.FindPerimeter():F2}");
    }
}

void Option4()
{
    foreach (Shape shape in shapeList)
    {
        switch (shape)
        {
            case Square s:
                s.Length += 5;
                break;
            case Circle c:
                c.Radius += 5;
                break;
        }
    }
    
    Option1();
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
    
    shapeList.Add(new Circle(color, radius));
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
    
    if (circleNum < 1 || circleNum > shapeList.Count)
    {
        Console.WriteLine("Invalid circle number!");
        return;
    }
    
    shapeList.RemoveAt(circleNum - 1);
    Console.WriteLine("Circle removed.");
}

void Option7()
{
    shapeList.Sort();
    Option2();
}
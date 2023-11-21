// My Shape App
// Written by: Hu Bowen
// Date: 21 Nov 2023

using S10255800_MyShapeApp;

// Part 4a)
Circle circle1 = new Circle(5.0);
Cylinder cylinder1 = new Cylinder(5.0, 10.0);

// Part 4b)
while (true)
{
    // Display title
    Console.Write("---------------- M E N U -----------------\r\n[1] Change the radius of circle\r\n[2] Change the radius of cylinder\r\n[3] Change the length of cylinder\r\n[4] Display the area of circle\r\n[5] Display the surface area of cylinder\r\n[6] Display the volume of cylinder\r\n[0] Exit\r\n------------------------------------------\r\nEnter your option: ");
    
    // Get user input
    if (!int.TryParse(Console.ReadLine(), out int input))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    switch (input)
    {
        case 1: // Change radius of circle
            Console.WriteLine("Current radius of circle: " + circle1.Radius);
            Console.Write("Please enter new radius: ");
            circle1.Radius = Convert.ToDouble(Console.ReadLine());
            break;

        case 2: // Change radius of cylinder
            Console.WriteLine("Current radius of cylinder: " + cylinder1.Radius);
            Console.Write("Please enter new radius: ");
            cylinder1.Radius = Convert.ToDouble(Console.ReadLine());
            break;

        case 3: // Change length of cylinder
            Console.WriteLine("Current length of cylinder: " + cylinder1.Length);
            Console.Write("Please enter new length: ");
            cylinder1.Length = Convert.ToDouble(Console.ReadLine());
            break;

        case 4: // Display the area of circle
            Console.WriteLine("Area of circle: " + Math.Round(circle1.CalculateArea(), 2));
            break;

        case 5: // Display the surface area of cylinder
            Console.WriteLine("Surface area of cylinder: " + Math.Round(cylinder1.CalculateArea(), 2));
            break;

        case 6: // Display the volume of cylinder
            Console.WriteLine("Volume of cylinder: " + Math.Round(cylinder1.CalculateVolume(), 2));
            break;

        case 0:
            return;

        default:
            Console.WriteLine("Invalid input!");
            break;
    }
    
    Console.WriteLine();
}

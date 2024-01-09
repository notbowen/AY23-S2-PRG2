using S10255800_Shapes;

// Get length and height from user
Console.Write("Enter the length (a) Square Pyramid in metre: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter the height (h) of Square Pyramid in metre: ");
double height = double.Parse(Console.ReadLine());

// Initialise SquarePyramid class
SquarePyramid squarePyramid = new SquarePyramid(length, height);

// Use methods to display volume and surface area
Console.WriteLine($"Volume of Square Pyramid : {squarePyramid.GetVolume():F2} cubic metre.");
Console.WriteLine($"Surface Area of Square Pyramid : {squarePyramid.GetSurfaceArea():F2} square metre.");
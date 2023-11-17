class S10255800_Qn01
{
    static void Main(string[] args)
    {
        // Variables
        double weight, height;
        double bmi;
        
        // Prompt user for weight & height
        Console.Write("Enter your weight (kg): ");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your height (m): ");
        height = Convert.ToDouble(Console.ReadLine());
        
        // Calculate and print BMI
        bmi = weight / (height * height);
        Console.WriteLine("Your body mass index is " + bmi.ToString());
        
        // Display health category
        Console.Write("You are ");
        switch(bmi)
        {
            case < 18.5:
                Console.WriteLine("Under weight.");
                break;
            case >= 18.5 and < 23:
                Console.WriteLine("Normal weight.");
                break;
            case >= 23 and < 27.5:
                Console.WriteLine("Over weight.");
                break;
            default:
                Console.WriteLine("Obese.");
                break;
        }
    }
}


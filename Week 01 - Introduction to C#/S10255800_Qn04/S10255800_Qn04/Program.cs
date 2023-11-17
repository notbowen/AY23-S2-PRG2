class S10255800_Qn04
{
    public void Option_1()
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
        switch (bmi)
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

    public void Option_2()
    {
        // Variables
        double amount, discounted_amt;
        int discount;

        // Prompt user for amount spent
        Console.Write("Enter amount\t($) : ");
        amount = Convert.ToDouble(Console.ReadLine());

        // Calculate discount given using if-else
        if (amount <= 100)
        {
            discount = 0;
        }
        else if (amount <= 500)
        {
            discount = 5;
        }
        else if (amount <= 1000)
        {
            discount = 10;
        }
        else
        {
            discount = 20;
        }

        // Display discount given in percentage
        Console.WriteLine("Discount given\t(%) : " + discount.ToString());

        // Calculate and display discount amount
        discounted_amt = amount * (discount / 100.0);
        Console.WriteLine("Discount amount\t($) : " + discounted_amt.ToString("0.00"));
    }

    public void Option_3()
    {
        // Variables
        int num;

        // Ask user for starting number
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // Print out multiplication table of number
        // from 1 to 12
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i:D}\t{i * num:D}");
        }
    }

    static void Main(string[] args)
    {
        // Variables
        int input;
        S10255800_Qn04 s = new S10255800_Qn04();

        // Repeatedly ask user for input and handle accordingly
        while (true)
        {
            // Print menu
            Console.WriteLine("------------- MENU --------------");
            Console.WriteLine("[1] Calculate Body Mass Index");
            Console.WriteLine("[2] Calculate Discount");
            Console.WriteLine("[3] Display Multiplication Table");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------------");

            // Get user input
            Console.Write("Enter your option: ");
            bool success = int.TryParse(Console.ReadLine(), out input);

            // Reject input if invalid
            if (!success)
            {
                Console.WriteLine("Invalid option! Please try again.\n");
                continue;
            }

            if (input < 0 || input > 3)
            {
                Console.WriteLine("Invalid option! Please try again.\n");
                continue;
            }

            // Abit of padding before selecting the option
            Console.WriteLine();

            // Handle respective inputs
            if (input == 0)
            {
                Console.WriteLine("Bye");
                break;
            } else if (input == 1)
            {
                Console.WriteLine("BMI Calculation");
                s.Option_1();
            } else if (input == 2)
            {
                Console.WriteLine("Discount Calculation");
                s.Option_2();
            } else
            {
                Console.WriteLine("Multiplication Table");
                s.Option_3();
            }

            // Write newline as padding
            Console.WriteLine();
        }
    }
}
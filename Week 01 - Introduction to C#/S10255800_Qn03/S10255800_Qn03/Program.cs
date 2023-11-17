class S10255800_Qn03
{
    static void Main(string[] args)
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
}
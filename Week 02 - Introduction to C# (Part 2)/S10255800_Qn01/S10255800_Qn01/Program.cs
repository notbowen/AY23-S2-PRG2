// My Generic Collections
// Written by: Hu Bowen, S10255800
// Date: 17 Oct 2023

/* Part A */
#region Part A

using System.Collections;

Console.WriteLine("===== Part A =====");

var arr = new int[5];

for (var i = 0; i < 5; i++)
{
    // Prompt user for input
    Console.Write("Please enter an integer to add: ");
    var success = int.TryParse(Console.ReadLine(), out var input);

    // Reject invalid user input
    if (!success)
    {
        Console.WriteLine("Invalid input!");
        i--; continue;
    }
    
    // Add input to list
    arr[i] = input;
}

// Display values in `arr`
Console.Write("Values in arr: ");
foreach (var i in arr)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n==================");
#endregion

/* Part B */
#region Part B
Console.WriteLine("\n===== Part B =====");

// Copy contents of array to list
List<int> list = new List<int>(arr);

// Prompt for more integers and add to list
// till -1 is entered
while (true)
{
    Console.Write("Please enter an integer to add: ");
    var success = int.TryParse(Console.ReadLine(), out var input);

    // Reject invalid inputs
    if (!success)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    
    // Break if input is -1
    if (input == -1)
        break;
    
    // Add input to list
    list.Add(input);
}

// Display contents of list
Console.Write("Contents of list: ");
foreach (var i in list)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n==================");
#endregion

/* Part C */
#region Part C
Console.WriteLine("\n===== Part C =====");

// Initialise stack & Push values
Stack<int> stack = new Stack<int>(list);
stack.Push(56);
stack.Push(72);

// Pop stack & Display contents
Console.Write("The stack contains: ");
while (stack.Count > 0)
{
    Console.Write(stack.Pop() + " ");
}

Console.WriteLine("\n==================");
#endregion

/* Part D */
#region Part D
Console.WriteLine("\n===== Part D =====");

// Initialise queue with contents of list
// & enqueue values
Queue<int> queue = new Queue<int>(list);
queue.Enqueue(23);
queue.Enqueue(45);

// Display the contents of the enqueued queue
Console.Write("Content of queue after enqueuing: ");
foreach (var i in queue)
{
    Console.Write(i + " ");
}

// Dequeue the queue & display
queue.Dequeue();

Console.Write("\nContent of queue after dequeuing: ");
foreach (var i in queue)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n==================");
#endregion

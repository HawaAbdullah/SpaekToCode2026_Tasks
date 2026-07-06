namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer

        // Ask the user to enter the starting number
        Console.Write("Enter the starting number: ");
        int startNumber = int.Parse(Console.ReadLine());

        // Count down from the starting number to 1
        for (int i = startNumber; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Print the final message after the countdown ends
        Console.WriteLine("Liftoff!");
        
    }
}
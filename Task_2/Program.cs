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
        
        //Task 2 - Sum of Numbers from 1 to N

        
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        
        int sum = 0;

        //Add every number from 1 to N
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        // Display the final sum
        Console.WriteLine("Sum = " + sum);
        
        //Task 3 - Multiplication Table

        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Print the multiplication table from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
        
    }
}
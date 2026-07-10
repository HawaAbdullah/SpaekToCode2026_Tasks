namespace Task4;

class Program
{
    static void PrintWelcome(string name)
    {
        Console.WriteLine("Welcome " + name + " to C# Programming!");
    }
    // Function that calculates the square of a number
    // It takes an integer parameter and returns an integer value
    static int Square(int number)
    {
        return number * number;
    }
    static void Main(string[] args)
    {
        // Ask the user for their name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Call the function and pass the user's name
        PrintWelcome(userName);
        
        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());

        // Call the function and store the returned result
        int result = Square(userNumber);

        // Print the result in Main
        Console.WriteLine("Square = " + result);
        
    }
}
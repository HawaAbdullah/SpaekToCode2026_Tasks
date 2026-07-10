namespace Task4;

class Program
{
    static void PrintWelcome(string name)
    {
        Console.WriteLine("Welcome " + name + " to C# Programming!");
    }
    static void Main(string[] args)
    {
        // Ask the user for their name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Call the function and pass the user's name
        PrintWelcome(userName);
        
        
    }
}
namespace MiniProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Spark Bank ");
        bool exit = false;
        
        while (!exit)
        {
            
            Console.WriteLine("1. Add new account");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Withdraw money");
            Console.WriteLine("4. Show balance");
            Console.WriteLine("5. Transfer amount");
            Console.WriteLine("6. List all accounts");
            Console.WriteLine("7. Close account");
            Console.WriteLine("8. Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 8)
            {
                exit = true;
                Console.WriteLine("Thank you for using Spark Bank");
            }
        }
    }
}
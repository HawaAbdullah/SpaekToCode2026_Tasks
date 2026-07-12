namespace MiniProject;

class Program
{
    static List<string> accountsNames = new List<string>();
    static List<int> accountNumbers = new List<int>();
    static List<double> accountBalances = new List<double>();
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter your account number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        if (accountNumbers.Contains(accountNumber))
        {
            Console.WriteLine("Your account number already exists");
            return;
        }

        Console.WriteLine("Enter initial deposit amount: ");
        double balance = double.Parse(Console.ReadLine());
        if (balance < 0)
        {
            Console.WriteLine("Error: Negative balance");
            return;
        }
        accountsNames.Add(name);
        accountNumbers.Add(accountNumber);
        accountBalances.Add(balance);
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
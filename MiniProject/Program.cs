namespace MiniProject;

class Program
{
    static List<string> accountsNames = new List<string>();
    static List<int> accountNumbers = new List<int>();
    static List<double> accountBalances = new List<double>();
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
            switch (choice)
            {
                case 1:
                    AddAccount();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    ShowBalance();
                    break;
                case 5:
                    TransferAmount();
                    break;
                case 6:
// TODO: call your first custom service function here
                    break;
                case 7:
// TODO: call your second custom service function here
                    break;
                case 8:
                    exit = true;
                    Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                    break;
                default:
                    break;
            }

            
        }
    }
    static void AddAccount()
    {
        Console.WriteLine("Enter customer name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter customer account number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        //MAKE SURE EVERY ONE HAS UNQUE NUMBER
        if (accountNumbers.Contains(accountNumber))
        {
            Console.WriteLine("Your account number already exists");
        }
        //TO MACK SURE IT IS POSITIVE BALANCS
        Console.WriteLine("Enter initial deposit amount: ");
        double balance = double.Parse(Console.ReadLine());
        if (balance < 0)
        {
            Console.WriteLine("Error: Negative balance");
        }
        
        accountsNames.Add(name);
        accountNumbers.Add(accountNumber);
        accountBalances.Add(balance);

        Console.WriteLine("Account created successfully");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }

    static void DepositMoney()
    {

    }

    static void WithdrawMoney()
    {

    }

    static void ShowBalance()
    {

    }

    static void TransferAmount()
    {

    }

    static void ListAccounts()
    {

    }

    static void CloseAccount()
    {

    }
}
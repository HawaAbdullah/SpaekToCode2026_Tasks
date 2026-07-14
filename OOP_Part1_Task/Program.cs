namespace OOP_Part1_Task;

public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        
    }

    public double CheckBalance()
    {
        return Balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine("Account number: "+AccountNumber);
        Console.WriteLine("Holder name: "+HolderName);
    }

    private void SendEmail()
    {
        
    } 
    
}
public class Student
{
    
    public int Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string email { get; set; } 
    int age {  get; set; } 
    
    public void Register(string Email)
    {
        email = Email;

        SendEmail();
    }

    private void SendEmail()
    {
       
    }
}

public class Product
{
    public string ProductName { get; set; }

    public double Price { get; set; }

    public int StockQuantity { get; set; }
    
    public void Sell(int quantity)
    {
        if (quantity <= StockQuantity)
        {
            StockQuantity -= quantity;
            Console.WriteLine("Product sold successfully.");
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }

        LogTransaction();
    }
    
    public void Restock(int quantity)
    {
        StockQuantity += quantity;

        Console.WriteLine("Product restocked successfully.");

        LogTransaction();
    }


    
    public double GetInventoryValue()
    {
        PrintDetails();

        return Price * StockQuantity;
    }


    
    private void PrintDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock Quantity: " + StockQuantity);
    }
    
    private void LogTransaction()
    {
        Console.WriteLine("Transaction has been logged.");
    }
}











class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 =new BankAccount();
        BankAccount account2 = new BankAccount();

        Student student1 = new Student();
        Student student2 = new Student();

        Product product1 = new Product();
        Product product2 = new Product();

        bool exit = false;

        while (!exit)
        {
            
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3. Make a Deposit");
            Console.WriteLine("4. Make a Withdrawal");
            Console.WriteLine("5. View Product Details");
            Console.WriteLine("6. Register Student");
            Console.WriteLine("7. Compare Account Balances");
            Console.WriteLine("8. Restock Product");
            Console.WriteLine("9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale");
            Console.WriteLine("14. Scholarship Eligibility");
            Console.WriteLine("15. Full Balance Top-Up");
            Console.WriteLine("16. Quick Account Opening");
            Console.WriteLine("17. Total Students Counter");
            Console.WriteLine("18. Overdrawn Account Check");
            Console.WriteLine("19. Set Student Security PIN");
            Console.WriteLine("20. Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    exit = true;
                    Console.WriteLine("Thank you , have a good day!");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }


    }
}
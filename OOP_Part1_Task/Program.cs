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


    }
}
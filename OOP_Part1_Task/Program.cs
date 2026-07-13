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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
    }
}
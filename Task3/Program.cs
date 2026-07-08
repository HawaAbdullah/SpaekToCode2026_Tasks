namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        //Ask user to enter first number
        Console.Write("Enter The First Number: ");
        double FirstNumber = double.Parse(Console.ReadLine());
        
        //Ask user to enter the secound number
        Console.Write("Enter the Second Numver: ");
        double SecondNumber = double.Parse(Console.ReadLine());
        
        //make calculation (subtract ) 
        double diff = FirstNumber - SecondNumber;
        Console.WriteLine($"The difference is : {diff}");
        
        //To make the ruslt always Positive.
        double result = Math.Abs(diff);
        Console.WriteLine($"The Absolute difftent is: {result}");
        
        //Task 2
        
        
        
    }
}
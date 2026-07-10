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
        Console.Write("Enter a number: ");
        double num = double.Parse(Console.ReadLine());

        double sq = Math.Sqrt(num);
        Console.WriteLine($"The sqrt is :{sq}");

        double pow = Math.Pow(num,2);
        Console.WriteLine($"The Power or the number is {pow}");
        
        //Task 3 
        // Ask user to enter full name
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        //Conver the name to upper and lower case
        string fullName1 = fullName.ToLower();
        string fullName2 = fullName.ToUpper();
        Console.WriteLine($"Lower {fullName} is {fullName1}");
        Console.WriteLine($"Upper {fullName} is {fullName2}");
        
        //Count number of characters
        int length = fullName.Length;
        Console.WriteLine($"The length is {length}");
        
        //Task 4
        //Ask the user to enter the free trial period in days
        Console.Write("Enter the number of free trial days: ");
        int trialDays = int.Parse(Console.ReadLine());

        //Get today's date
        DateTime startDate = DateTime.Today;
        
        //Calculate the subscription end date
        DateTime endDate = startDate.AddDays(trialDays); 
        //Display the end date in yyyy-MM-dd format
        Console.WriteLine("Subscription End Date: " + endDate.ToString("yyyy-MM-dd"));

        //Task 5
        //Ask the user to enter the exam score
        Console.WriteLine("Enter your exam scor: ");
        double score = double.Parse(Console.ReadLine());
        
        double roundedScore = Math.Round(score);
       
        Console.WriteLine($"Your score is {roundedScore}");

        if (roundedScore >= 67)
        {
            Console.WriteLine("Student :Pass");
        }
        else
        {
            Console.WriteLine("Student :Fail");
        }
        
        //Task 6
        
        // Ask the user to enter a password
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Check if the password has at least 8 characters
        bool hasValidLength = password.Length >= 8;

        // Check if the password contains the forbidden word
        bool containsForbiddenWord = password.ToLower().Contains("password");

        // Check if the password is strong
        if (hasValidLength && !containsForbiddenWord)
        {
            Console.WriteLine("Strong Password");
        }
        else
        {
            Console.WriteLine("Weak Password");

            if (!hasValidLength)
            {
                Console.WriteLine("Reason: Password must be at least 8 characters long.");
            }

            if (containsForbiddenWord)
            {
                Console.WriteLine("Reason: Password must not contain the word 'password'.");
            }






    }
}
namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer

        // Ask the user to enter the starting number
        Console.Write("Enter the starting number: ");
        int startNumber = int.Parse(Console.ReadLine());

        // Count down from the starting number to 1
        for (int i = startNumber; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Print the final message after the countdown ends
        Console.WriteLine("Liftoff!");
        
        //Task 2 - Sum of Numbers from 1 to N

        
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        
        int sum = 0;

        //Add every number from 1 to N
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        // Display the final sum
        Console.WriteLine("Sum = " + sum);
        
        //Task 3 - Multiplication Table

        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Print the multiplication table from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
        //Task 4 - Password Retry

        // Store the correct password
        string correctPassword = "Spark2026";

        // Variable to store user input
        string userPassword = "";

        // Keep asking until the correct password is entered
        while (userPassword != correctPassword)
        {
            Console.Write("Enter password: ");
            userPassword = Console.ReadLine();

            // Check if the password is correct
            if (userPassword == correctPassword)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Incorrect password, try again");
            }
        }
        // Task 5 - Number Guessing Game

        // Fixed secret number
        int secretNumber = 42;

        // Store user's guess
        int guess;

        // Count number of attempts
        int attempts = 0;


        do
        {
            // Ask user for a guess
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            // Increase attempts after each try
            attempts++;

            // Compare the guess with the secret number
            if (guess > secretNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Attempts: " + attempts);
            }

        } while (guess != secretNumber);
        
        // Task 6 - Safe Division Calculator

        try
        {
            // Get numbers from user
            Console.Write("Enter first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = double.Parse(Console.ReadLine());


            // Division operation
            double result = number1 / number2;


            // Display result
            Console.WriteLine("Result = " + result);
        }


        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }


        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers");
        }
        
        // Task 7 - Repeating Menu with Exit Option

        // Variable to store user choice
        int choice = 0;


        // Keep showing menu until user chooses Exit
        while (choice != 3)
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1) Say Hello");
            Console.WriteLine("2) Show Greeting");
            Console.WriteLine("3) Exit");
            Console.Write("Choose an option: ");


            try
            {
                // Convert user input to integer
                choice = int.Parse(Console.ReadLine());


                // Handle menu options
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;


                    case 2:
                        Console.WriteLine("Good morning, have a nice day!");
                        break;


                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;


                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }


            catch (FormatException)
            {
                Console.WriteLine("Please enter a number only");
            }


            Console.WriteLine();
        }
        
        
    }
}
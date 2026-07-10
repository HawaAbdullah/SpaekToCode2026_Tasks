namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Create an array with fixed size of 5 integers to store grades
        int[] grades = new int[5];


        // Use for loop to get grades from user
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("Enter grade " + (i + 1) + ": ");
            grades[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("\nStudent Grades:");


        // Use foreach loop to print all grades
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        
        // Create a List to store to-do tasks
        List<string> tasks = new List<string>();


        // Ask the user to enter 5 tasks and add them to the list
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter task " + (i + 1) + ": ");
            string task = Console.ReadLine();

            tasks.Add(task);
        }


        Console.WriteLine("\nYour To-Do List:");

            
        // Print all tasks using foreach loop
        foreach (string task in tasks)
        {
            Console.WriteLine("- " + task);
        }
        // Create a Stack to store browser history
        Stack<string> history = new Stack<string>();


        // Ask the user to enter 3 website URLs
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter website URL " + (i + 1) + ": ");
            string url = Console.ReadLine();

            // Add website to the stack
            history.Push(url);
        }


        Console.WriteLine("\nBrowser History:");

        // Display current history
        foreach (string page in history)
        {
            Console.WriteLine(page);
        }


        // Simulate pressing the Back button
        string currentPage = history.Pop();


        Console.WriteLine("\nBack button pressed...");
        Console.WriteLine("You returned from: " + currentPage);


        Console.WriteLine("You are now on: " + history.Peek());
        
        // Create a Queue to store customer names
        Queue<string> customers = new Queue<string>();


        // Ask the user to enter 3 customer names
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter customer name " + (i + 1) + ": ");
            string name = Console.ReadLine();

            // Add customer to the queue
            customers.Enqueue(name);
        }


        Console.WriteLine("\nCustomers Waiting:");

        // Display customers in the queue
        foreach (string customer in customers)
        {
            Console.WriteLine(customer);
        }


        // Serve the first customer
        string servedCustomer = customers.Dequeue();


        Console.WriteLine("\nCustomer Served:");
        Console.WriteLine(servedCustomer);


        Console.WriteLine("\nRemaining Customers:");

        foreach (string customer in customers)
        {
            Console.WriteLine(customer);
        }

    }
}
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
    }
}
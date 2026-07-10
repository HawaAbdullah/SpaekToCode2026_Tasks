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
    }
}
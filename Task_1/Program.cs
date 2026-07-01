// Task 1 - (Personal Info Card)

using System.Diagnostics;

string name= "Sara";
int age =20;
double height =1.65;
bool isStudent=true;
//display the output 
Console.WriteLine("Name: "+name);
Console.WriteLine("Age: "+age);
Console.WriteLine("Height: "+height);
Console.WriteLine("IsStudent: "+isStudent); 

//Task 2 - Rectangle Calculator
Console.WriteLine("Enter length");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter width");
double width = Convert.ToDouble(Console.ReadLine());
//calcalit and print the result 
double area = length * width;
double Perimeter = 2 * (length + width);
Console.WriteLine("Area: "+area);
Console.WriteLine("Perimeter: "+Perimeter);

//Task 3 - Even or Odd Checker
Console.WriteLine("Enter Number: ");
int number = Convert.ToInt32(Console.ReadLine());


//checking if it is ever or odd using if statment 
if (number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd!");
}

//Task 4 - Voting Eligibility

Console.WriteLine("Enter Age: ");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Do you have ID? (yes,no): ");
string id = Console.ReadLine();
bool hasID = false;
//cheking
if (id == "yse")
{
    hasID = true;
}

if (age2 >= 18 && hasID)
{
    Console.WriteLine("eligible to vote!");
}
else
{
    Console.WriteLine("not eligible to vote!");
}

//Task 5 - Grade Letter Lookup

Console.Write("Enter Your grade(A/B/C/D/F): ");
char grade = Convert.ToChar(Console.ReadLine());
switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent");
        break;
    case 'B':
        Console.WriteLine("Very Good");
        break;
    case 'C':
        Console.WriteLine("Good");
        break;
    case 'D' :
        Console.WriteLine("Pass");
        break;
    case 'F' :
        Console.WriteLine("Fail");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;
}

//Task 6 - Temperature Converter
Console.Write("Enter Celsius: ");
double cel = Convert.ToDouble(Console.ReadLine());
double F =(cel * 9 / 5) + 32;
Console.WriteLine("Fahrenheit: " + F);
if (cel < 10)
{
    Console.WriteLine("Cold");
}
else if (cel <= 30)
{
    Console.WriteLine("Mild");
}
else
{
    Console.WriteLine("Hot");
}

//Task 7 - Movie Ticket Pricing

Console.Write("Enter age: ");
int mAge = Convert.ToInt32(Console.ReadLine());

if (mAge <= 12)
{
    Console.WriteLine("Child: 2 OMR");
}
else if (mAge <= 59)
{
    Console.WriteLine("Adult: 5 OMR");
}
else
{
    Console.WriteLine("Senior: 3 OMR");
}

//Task 8 - Restaurant Bill with Membership Discount

Console.Write("Enter bill: ");
double bill = Convert.ToDouble(Console.ReadLine());

Console.Write("Are you member? (yes/no): ");
string mem = Console.ReadLine();
bool isMember = false;

if (mem == "yes")
{
    isMember = true;
}

double discount = 0;
if (bill > 20 && isMember)
{
    discount = bill * 0.15;
}
double finalBill = bill - discount;

Console.WriteLine("Original Bill: " + bill);
Console.WriteLine("Discount: " + discount);
Console.WriteLine("Final Bill: " + finalBill);

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
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine("Holder name: " + HolderName);
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
        int age { get; set; }

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
        static BankAccount account1 = new BankAccount{AccountNumber=1163, HolderName="karim", Balance=120};
        static BankAccount account2 = new BankAccount{AccountNumber =15203, HolderName= "Ali", Balance= 63};

        static Student student1 = new Student{Name ="Ali", Address ="Muscat", Grade= 65};
        static Student student2 = new Student{Name ="Ahmed", Address= "Muscat", Grade =70};

        static Product product1 = new Product{ProductName ="Wireless Mouse", Price= 5.500, StockQuantity= 50};
        static Product product2 = new Product{ProductName ="Mechanical Keyboard", Price =15.750, StockQuantity =20};

        static void ViewAccountDetails()
        {
            Console.WriteLine("Choose account 1 or 2: ");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                double result = account1.CheckBalance();
                Console.WriteLine("Your Balance is " + result);
            }
            else if (i == 2)
            {
                double result = account2.CheckBalance();
                Console.WriteLine("Your Balance is " + result);
            }
            else
            {
                Console.WriteLine("Enter valid account number");
            }
        }

        static void UpdateStudentAddress()
        {
            
        }

        static void MakeDeposit()
        {
            
            
        }

        static void MakeWithdrawal()
        {
            
        }

        static void ViewProductDetails()
        {
            
        }

        static void RegisterStudent()
        {
            
        }

        static void CompareTowAccountBalances()
        {
            
        }

        static void RestockProduct()
        {
            
        }

        static void TransferBetweenAccounts()
        {
            
        }

        static void UpdateStudentGrade()
        {
            
        }

        static void StudentReportCard()
        {
            
        }

        static void AccountHealthStatus()
        {
            
        }

        static void BulkSale()
        {
            
        }

        static void ScholarshipEligibility()
        {
            
        }

        static void FullBalance()
        {
            
        }

        static void QuickAccountOpening()
        {
            
        }

        static void TotalStudents()
        {
            
        }

        static void OverdrawnAccountCheck()
        {
            
        }

        static void SetStudentSecurityPIN()
        {
            
        }
        
        static void Main(string[] args)
        {
            

            bool exit = false;

            while (exit == false)
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
                        ViewAccountDetails();
                        break;
                    case 2:
                        UpdateStudentAddress();
                        break;
                    case 3:
                        MakeDeposit();
                        break;
                    case 4:
                        MakeWithdrawal();
                        break;
                    case 5:
                        ViewProductDetails();
                        break;
                    case 6:
                        RegisterStudent();
                        break;
                    case 7:
                        CompareTowAccountBalances();
                        break;
                    case 8:
                        RestockProduct();
                        break;
                    case 9:
                        TransferBetweenAccounts();
                        break;
                    case 10:
                        UpdateStudentGrade();
                        break;
                    case 11:
                        StudentReportCard();
                        break;
                    case 12:
                        AccountHealthStatus();
                        break;
                    case 13:
                        BulkSale();
                        break;
                    case 14:
                        ScholarshipEligibility();
                        break;
                    case 15:
                        FullBalance();
                        break;
                    case 16:
                        QuickAccountOpening();
                        break;
                    case 17:
                        TotalStudents();
                        break;
                    case 18:
                        OverdrawnAccountCheck();
                        break;
                    case 19:
                        SetStudentSecurityPIN();
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

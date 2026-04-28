using System.Diagnostics;

namespace SimpleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple ATM! ");
            
            Console.Write("Enter your Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Welcome, " + userName );

            double balance = 0;
            while (true)
            {
                Console.Write("Enter balance: R");
                string input = Console.ReadLine();
                if (double.TryParse(input, out balance) && balance >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a valid balance.");

            }
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("----ATM Menu---");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Current Balance: R" + balance);
                        break;
                    case "2":
                        balance = HandleDeposit(balance);
                        break;
                    case "3":
                        balance = HandleWithdrawal(balance);
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Simple ATM. Goodbye!");
                        running = false;
                        break;
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("Session ended at: " + DateTime.Now);
        }
        static double HandleDeposit(double balance)
        {
            Console.Write("Enter amount to deposit: R");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposit successful. New Balance: R" + balance);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }         
            return balance;
        }
        static double HandleWithdrawal(double balance)
        {
            Console.Write("Enter amount to withdraw: R");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful. New Balance: R" + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Current Balance: R" + balance);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }
            return balance;
        }
    }
}

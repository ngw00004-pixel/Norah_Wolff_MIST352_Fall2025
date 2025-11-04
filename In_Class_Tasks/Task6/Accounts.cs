using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Account
    {
        private int accountNumber;
        private string ownerName;
        private double balance;

        // Default constructor
        public Account()
        {
            this.accountNumber = 0;
            this.ownerName = "Unknown";
            this.balance = 0.0;
        }

        // Constructor with account number and owner
        public Account(int accountNumber, string owner)
        {
            this.accountNumber = accountNumber;
            this.ownerName = owner;
            this.balance = 0.0;
        }

        // Constructor with all parameters
        public Account(int accountNumber, string owner, double balance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = owner;
            this.balance = balance;
        }

        // Getters and setters
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount:F2}. New balance: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew ${amount:F2}. New balance: ${balance:F2}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Cannot overdraft.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        // Display account info
        public void DisplayInfo()
        {
            Console.WriteLine($"Account #{accountNumber}");
            Console.WriteLine($"Owner: {ownerName}");
            Console.WriteLine($"Balance: ${balance:F2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_GPT
{
    public class Account
    {
        // Private fields
        private int accountNumber;
        private String ownerName;
        private double balance;

        // Default constructor
        public Account()
        {
            this.accountNumber = 0;
            this.ownerName = "Unknown";
            this.balance = 0.0;
        }

        // Constructor with account number and owner
        public Account(int accountNumber, String ownerName)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.balance = 0.0;
        }

        // Constructor with all fields
        public Account(int accountNumber, String ownerName, double balance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.balance = balance;
        }

        // Getters and setters
        public int getAccountNumber() { return accountNumber; }
        public void setAccountNumber(int accountNumber) { this.accountNumber = accountNumber; }

        public String getOwnerName() { return ownerName; }
        public void setOwnerName(String ownerName) { this.ownerName = ownerName; }

        public double getBalance() { return balance; }
        public void setBalance(double balance) { this.balance = balance; }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited $" + amount + " into account " + accountNumber);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrew $" + amount + " from account " + accountNumber);
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }

        // Display method
        public void DisplayInfo()
        {
            Console.WriteLine("Account Info:");
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Owner: " + ownerName);
            Console.WriteLine("Balance: $" + balance.ToString("F2"));
            Console.WriteLine();
        }
    }

}

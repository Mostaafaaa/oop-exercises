using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*Exercise 4: Create a BankAccount class with attributes account_number and balance.
     * Add methods deposit(amount), withdraw(amount), and check_balance().*/
    internal class BankAccountClass
    {
        public string account_number;
        public double balance;

        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


        public void withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount.");
            }
        }
        public void check_balance()
        {
            Console.WriteLine($"Account Number: {account_number}, Balance: {balance}");
        }


    }
}
   
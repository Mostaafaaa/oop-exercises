using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    /*Exercise 4: Create a BankAccount class with attributes account_number and balance. 
     * Add methods deposit(amount), withdraw(amount), and check_balance(). */
    internal class BankAccount
    {
        public string AccountNumber { get; protected set; }
        public double Balance { get; protected set; }
        public BankAccount(string account_number, double balance)
        {
            AccountNumber = account_number;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance = Balance + amount;
            Console.WriteLine($"Deposited {amount:$}. New balance: {Balance:$}");
        }
        public void withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            Balance = (Balance - amount);
            Console.WriteLine($"Withdrew {amount:$}. New balance: {Balance:$}");
        }
        public void check_balance()
        {
            Console.WriteLine($"Current balance: {Balance}");
        }
    }
}

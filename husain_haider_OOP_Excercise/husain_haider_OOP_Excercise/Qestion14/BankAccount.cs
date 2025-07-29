using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Question14
{
    /*
          Exercise 4: Create a BankAccount class with attributes account_number and balance. 
          Add methods deposit(amount), withdraw(amount), and check_balance().
    */
    internal class BankAccount
    {
        public long account_number {  get; set; }
        public long balance {  get; set; }

        public BankAccount(long Account_number,long Balance)
        {
            account_number = Account_number;   
            balance = Balance;
            bank_accounts.Add(this);
        }
        private static List<BankAccount> bank_accounts = new List<BankAccount>();



        public void deposit()
        {
            Console.WriteLine("enter the number you want to deposit:");
            long deposit_amount = Convert.ToInt64(Console.ReadLine());
            balance += deposit_amount; 
        }

        public void withdraw()
        {
            Console.WriteLine("enter the number you want to withdraw:");
            long withdraw_amount = Convert.ToInt64(Console.ReadLine());
            balance -= withdraw_amount;
        }


        public void checheck_balanceck()
        {
            Console.WriteLine($"account_number\t\t\t\t{account_number}\n");
            Console.WriteLine($"balance\t\t\t\t{balance}\n");

        }



    }
}

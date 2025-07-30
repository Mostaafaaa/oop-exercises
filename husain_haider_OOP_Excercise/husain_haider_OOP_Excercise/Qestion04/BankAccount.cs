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
        public double account_number {  get; set; }
        public double balance {  get; set; }

        public BankAccount(double Account_number,double Balance)
        {
            account_number = Account_number;   
            balance = Balance;
            bank_accounts.Add(this);
        }
        private static List<BankAccount> bank_accounts = new List<BankAccount>();



        public void deposit()
        {
            Console.Write("enter the number you want to deposit: $");
            double deposit_amount = Convert.ToDouble(Console.ReadLine());
            balance += deposit_amount; 
        }

        public void withdraw()
        {
            Console.Write("enter the number you want to withdraw: $");
            double withdraw_amount = Convert.ToDouble(Console.ReadLine());
            balance -= withdraw_amount;
        }


        public void checheck_balanceck()
        {
            Console.Write($"""
                 _______________________________________________________
                |                                                       |
                |  account number  :                              {account_number} |    
                |                                                       |
                | -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- |
                |                                                       |
                |  balance :                                      ${balance} |
                |                                                       |
                |_______________________________________________________|
                """);
       
        }



    }
}

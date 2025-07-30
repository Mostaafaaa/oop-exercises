using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    // Exercise 14: Create a Bank class that stores multiple BankAccount objects.
    // Add methods create_account(account) and show_all_accounts().

    internal class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        public void CreateAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public void ShowAllAccounts()
        {
            foreach (var account in accounts)
            {
                account.CheckBalance();
            }
        }
    }
}

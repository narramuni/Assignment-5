using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLogicLayer
{
    public class Bank
    {
        private readonly Dictionary<long, float> accountBalances;

        public Bank()
        {
            accountBalances = new Dictionary<long, float>();
        }

        public void AddAccount(long AccountNo, float initialBalance)
        {

            if (!accountBalances.ContainsKey(AccountNo))
            {

                accountBalances[AccountNo] = initialBalance;
            }
            else
            {
                Console.WriteLine($"Account {AccountNo} already exists.");
            }
        }

        public void Deposit(float amt, DateTime depositDate, string branchname, long AccountNo)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
                return;
            }

            if (!accountBalances.ContainsKey(AccountNo))
            {
                Console.WriteLine("Account not found. Deposit failed.");
                return;
            }
            accountBalances[AccountNo] += amt;

            Console.WriteLine($"Deposited {amt:C} on {depositDate} to Account {AccountNo} at {branchname}. New balance: {accountBalances[AccountNo]:C}");
        }

        public void Withdraw(float amt, DateTime withdrawDate, string branchname, long AccountNo)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than 0.");
                return;
            }

            if (!accountBalances.ContainsKey(AccountNo))
            {
                Console.WriteLine("Account not found. Withdrawal failed.");
                return;
            }

            // Check if sufficient balance is available for withdrawal
            if (accountBalances[AccountNo] < amt)
            {
                Console.WriteLine("Insufficient balance. Withdrawal failed.");
                return;
            }
            accountBalances[AccountNo] -= amt;

            Console.WriteLine($"Withdrawn {amt:C} on {withdrawDate} from Account {AccountNo} at {branchname}. New balance: {accountBalances[AccountNo]:C}");
        }

        public float GetAccountBalance(long AccountNo)
        {
            if (accountBalances.ContainsKey(AccountNo))
            {

                return accountBalances[AccountNo];
            }
            else
            {
                Console.WriteLine("Account not found.");
                return 0.0f; // You can return a default value or handle this case as needed
            }
        }

    }
}

using BankBusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            //bank.AddAccount(123456789, 1000);
            //bank.AddAccount(987654321, 500);

            Console.WriteLine("Enter bank account number:");
            long accountNumber = Convert.ToInt64(Console.ReadLine());

            if (bank.GetAccountBalance(accountNumber) == -1) // Check if the balance is greater than or equal to zero
            {
                Console.WriteLine($"Account {accountNumber} already exists.");
            }
            else
            {
                bank.AddAccount(accountNumber, 0);
            }




            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter deposit amount:");
                    float depositAmount = Convert.ToSingle(Console.ReadLine());
                    bank.Deposit(depositAmount, DateTime.Now, "Main Branch", accountNumber);
                    break;
                case 2:
                    Console.WriteLine("Enter withdrawal amount:");
                    float withdrawalAmount = Convert.ToSingle(Console.ReadLine());
                    bank.Withdraw(withdrawalAmount, DateTime.Now, "Main Branch", accountNumber);
                    break;
                case 3:
                    float balance = bank.GetAccountBalance(accountNumber);
                    Console.WriteLine($"Account {accountNumber} balance: {balance:C}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }



                //long account1 = 123456789;
                //long account2 = 987654321;

                //// Perform deposits and withdrawals
                //bank.Deposit(1000, DateTime.Now, "Main Branch", account1);
                //bank.Deposit(500, DateTime.Now, "Downtown Branch", account2);
                //bank.Withdraw(200, DateTime.Now, "Main Branch", account1);
                //bank.Withdraw(800, DateTime.Now, "Downtown Branch", account2);

                //Console.WriteLine($"Account {account1} balance: {bank.GetAccountBalance(account1):C}");
                //Console.WriteLine($"Account {account2} balance: {bank.GetAccountBalance(account2):C}");


                Console.ReadLine();
        }
    }
}

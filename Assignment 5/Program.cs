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

            bank.AccountNo = 24652458642;
            bank.BranchName = "India";
            bank.DepositAmount = 200000;
            bank.DepositDate = new DateTime(2022, 06, 12);
            bank.WithdrawAmount = 1000;
            bank.WithdrawDate = new DateTime(2023, 06, 12);
            bank.Deposit(bank.DepositAmount, bank.DepositDate, bank.BranchName, bank.AccountNo);
            bank.Withdraw(bank.WithdrawAmount, bank.WithdrawDate, bank.BranchName, bank.AccountNo);



            Console.ReadLine();
        }
    }
}

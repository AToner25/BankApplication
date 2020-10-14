using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    abstract class Account : IAccount
    {
        public double startingBalance;
        public double balance;
        public double totalDeposit;
        public int countDeposit = 0;
        public double totalWithdraw;
        public int countWithdraw = 0;
        public double annualInterestRate;
        public double serviceCharge;
        public enum accountStatus{ Active, Inactive };

        public Account(double balance, double annualInterestRate)
        {
            this.balance = balance;
            this.annualInterestRate = 0.10;
        }
        
        
        
        public void CalculateInterest()
        {
            double monthlyInterestRate;

            monthlyInterestRate = (annualInterestRate / 12);
            monthlyInterestRate = balance * monthlyInterestRate;
            balance += monthlyInterestRate;
        }

        public void CloseAndReport()
        {
            
        }

        public void MakeDeposit(double amount)
        {
            balance += amount;
            countDeposit++;
        }

        public void MakeWithdrawl(double amount)
        {
            balance -= amount;
            countWithdraw++;
        }

        
    }
}

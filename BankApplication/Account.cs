using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    abstract class Account : IAccount
    {
        double startingBalance;
        double balance;
        double totalDeposit;
        int countDeposit = 0;
        double totalWithdraw;
        int countWithdraw = 0;
        double annualInterestRate;
        double serviceCharge;
        enum accountStatus{ Active, Inactive };

        public Account(double balance, double annualInterestRate) {}
        public void CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public string CloseAndReport()
        {
            throw new NotImplementedException();
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

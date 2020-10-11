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
        int countDeposit;
        double totalWithdraw;
        int countWithdraw;
        double annualInterestRate;
        double serviceCharge;
        enum accountStatus{ Active, Inactive };


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
            throw new NotImplementedException();
        }

        public void MakeWithdrawl(double amount)
        {
            throw new NotImplementedException();
        }
    }
}

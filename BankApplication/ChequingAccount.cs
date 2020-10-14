using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class ChequingAccount : Account, IAccount
    {
        public ChequingAccount(double balance, double annualInterestRate): base(balance, annualInterestRate)
        {

        }
        public void makeWithdraw(double amount)
        {
            if (balance > 0)
            {
                serviceCharge += 15;
                balance -= serviceCharge;
            }
            else
                balance -= amount;

            base.MakeWithdrawl(amount);
        }
        public void CloseAndReport()
        {
            serviceCharge += 5.00 + countWithdraw * 0.10;
        }
        public void makeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }
    }
}

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

        }
        public void CloseAndReport()
        {

        }
        public void makeDeposit(double amount)
        {
            
        }
    }
}

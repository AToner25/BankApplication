using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class GlobalSavingsAccount : SavingsAccount, IExchangeable
    {
        public GlobalSavingsAccount(double balance, double interestRate) : base(balance, interestRate)
        {

        }

        public double USValue(double rate)
        {
            throw new NotImplementedException();
        }
    }
}

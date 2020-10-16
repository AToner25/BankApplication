using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            rate = 0.76;

            return balance * rate;

            
        }
    }
}

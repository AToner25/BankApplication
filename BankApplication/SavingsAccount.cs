using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class SavingsAccount : Account, IAccount
    {
        accountStatus status;
        public SavingsAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {
            if (balance < 25)
            {
                 status = accountStatus.Inactive;
            }
            else
            {
                status = accountStatus.Active;
            }
        }


        public void MakeWithdraw(double amount) 
        {
            accountStatus accountStatus = accountStatus.Inactive;

            if(accountStatus == accountStatus.Inactive)
            {
                base.MakeWithdrawl(amount);
            }
            
        }

        public void MakeDeposit(double amount) 
        {
            accountStatus accountStatus = accountStatus.Inactive;
            
            while (accountStatus == accountStatus.Inactive)
            {
                if(amount > 25)
                {
                    base.MakeDeposit(amount);
                    accountStatus = accountStatus.Active;
                }
                else
                {
                    accountStatus = accountStatus.Inactive;
                }
                    
            }
        }

        public void CloseAndReport()
        {
            accountStatus accountStatus = accountStatus.Active;
            if(countWithdraw > 4)
            {
                serviceCharge += countWithdraw * 1.00 ;
                 
            }
            else
                serviceCharge -= 4.00;
            base.CloseAndReport();
            if(balance < 25)
            {
                accountStatus = accountStatus.Inactive;
            }
            else
            {
                accountStatus = accountStatus.Active;
            }
        }

        





    }

}
    



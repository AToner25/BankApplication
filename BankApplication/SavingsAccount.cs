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
       
        public SavingsAccount(double balance, double interestRate) : base (balance, interestRate)
        {

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
            


            if (accountStatus == accountStatus.Inactive )
            {
                if(amount < 25)
                {
                    base.MakeDeposit(amount);
                    accountStatus = accountStatus.Active;
                }
             
            }
        }

        public void CloseAndReport()
        {

        }





    }

}
    



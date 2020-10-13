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

       private void MakeWithdraw()
        {
            accountStatus accountStatus = accountStatus.Inactive;

            if(accountStatus == accountStatus.Inactive)
            { 
                base.MakeWithdrawl();
            }
            
        }

        private void MakeDeposit()
        {
            accountStatus accountStatus = accountStatus.Inactive;

            if (accountStatus == accountStatus.Inactive )
            {
                if(MakeDeposit < 25)
                {

                }
             
            }
        }





    }

}
    



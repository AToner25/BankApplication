using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String Option;
            String Option1;
            String Option2;
            String Option3;

            Account savingsAccount = new SavingsAccount(5.00, .10);
            Account chequingAccount = new ChequingAccount(5.00, .15);
            Account GlobalSavingsAccount = new GlobalSavingsAccount(5.00, .15);

            try
            {
                
                Console.WriteLine("Bank Menu");
                Console.WriteLine("A:Savings");
                Console.WriteLine("B:Checking");
                Console.WriteLine("C:GlobalSavings");
                Console.WriteLine("Q:Exit");
                Option = Console.ReadLine();



                switch (Option.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Saving Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("R:Return to Bank Menu");
                        
                        break;

                    case "B":
                        Console.WriteLine("Chequing Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("R:Return to Bank Menu");
                       
                        break;

                    case "C":
                        Console.WriteLine("Global Savings Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("D:Report Balance in USD");
                        Console.WriteLine("R:Return to Bank Menu");
                        
                        break;

                    case "Q":
                        Environment.Exit(0);
                        break;

                }
                Option1 = Console.ReadLine();
                
                switch (Option1.ToUpper())
                {
                    case "A":
                        Console.WriteLine("How much would you like to deposit?");
                        
                        break;

                    case "B":
                        Console.WriteLine("How much would you like to withdraw?");
                        Console.WriteLine("");
                        break;

                    case "C":
                        Console.WriteLine("Close + Report");
                        Console.WriteLine("");
                        break;

                    case "R":
                        Console.WriteLine("Bank Menu");
                        Console.WriteLine("A:Savings");
                        Console.WriteLine("B:Checking");
                        Console.WriteLine("C:GlobalSavings");
                        Console.WriteLine("Q:Exit");
                        
                        break;
                }
                Option = Console.ReadLine();
                Option2 = Console.ReadLine();
                switch (Option2.ToUpper())
                {
                    case "A":
                        Console.WriteLine("How much would you like to deposit?");
                        Console.WriteLine("");
                        break;

                    case "B":
                        Console.WriteLine("How much would you like to withdraw?");
                        Console.WriteLine("");
                        break;

                    case "C":
                        Console.WriteLine("Close + Report");
                        Console.WriteLine("");
                        break;

                    case "R":
                        Console.WriteLine("Bank Menu");
                        Console.WriteLine("A:Savings");
                        Console.WriteLine("B:Checking");
                        Console.WriteLine("C:GlobalSavings");
                        Console.WriteLine("Q:Exit");
                        Option = Console.ReadLine();
                        break;

                }

                Option3 = Console.ReadLine();
                switch (Option3.ToUpper())
                {
                    case "A":
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;

                    case "B":
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;

                    case "C":
                        Console.WriteLine("Close + Report");
                        Console.WriteLine("");
                        break;

                    case "D":
                        Console.WriteLine("Report Balanace in USD");
                        Console.WriteLine("");
                        break;

                    case "R":
                        Console.WriteLine("Bank Menu");
                        Console.WriteLine("A:Savings");
                        Console.WriteLine("B:Checking");
                        Console.WriteLine("C:GlobalSavings");
                        Console.WriteLine("Q:Exit");
                        Option = Console.ReadLine();
                        break;

                }
            }
            catch
            {

            }
           

        }

    }
}

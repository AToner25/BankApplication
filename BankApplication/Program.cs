using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String Option;
            String Option2;
            String Option3;
            String Option4;
            String Option5;

            SavingsAccount savingsAccount = new SavingsAccount(5.00, .10);
            ChequingAccount chequingAccount = new ChequingAccount(5.00, .15);
            GlobalSavingsAccount GlobalSavingsAccount = new GlobalSavingsAccount(5.00, .15);
            

            var valid = true;
            while (valid)
            {

                try
                {

                    string bankMenu()
                    {
                        Console.WriteLine("Bank Menu");
                        Console.WriteLine("A:Savings");
                        Console.WriteLine("B:Checking");
                        Console.WriteLine("C:GlobalSavings");
                        Console.WriteLine("Q:Exit");
                        Option = Console.ReadLine();

                        return Option;
                    }
                    string savingAccount()
                    {
                        Console.WriteLine("Saving Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("R:Return to Bank Menu");
                        Option2 = Console.ReadLine();
                        return Option2;
                    }

                    string chequingsAccount()
                    {
                        Console.WriteLine("Chequing Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("R:Return to Bank Menu");
                        Option3 = Console.ReadLine();
                        return Option3;
                    }

                    string gloabalSavingsAccount()
                    {
                        Console.WriteLine("Global Savings Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("D:Report Balance in USD");
                        Console.WriteLine("R:Return to Bank Menu");
                        Option4 = Console.ReadLine();
                        return Option4;
                    }

                    string savingAccountOptions()
                    {

                    }








                    //var valid1 = false;
                    //while (!valid1)
                    //{

                    Console.WriteLine(bankMenu());



                    switch (Option.ToUpper())
                    {
                        case "A":
                            //valid1 = true;
                            Console.WriteLine(savingAccount());

                            break;

                        case "B":
                            //valid1 = true;
                            Console.WriteLine(chequingsAccount());

                            break;

                        case "C":
                            Console.WriteLine(gloabalSavingsAccount());

                            break;

                        case "Q":
                            Environment.Exit(0);

                            break;

                        default:
                            //valid1 = false;
                            Console.WriteLine("That is not an option, try again.");

                            break;


                    }
                   
                    Option5 = Console.ReadLine();
               
                switch (Option5.ToUpper())
                {
                            case "A":

                            break;
                }



                }
                catch
                {

                }
            }

        }

    }
}

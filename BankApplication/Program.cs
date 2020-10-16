using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BankApplication
{
    class Program
    {
        
        private static string amount;
        private static string option;
        private static ChequingAccount chequingAccount = new ChequingAccount(5.00,.15);
        private static GlobalSavingsAccount globalSavingsAccount = new GlobalSavingsAccount(5.00,.10);
        private static readonly SavingsAccount savingsAccount = new SavingsAccount(5.00,.10);
       
        

        private static void Main(string[] args)
        {
            try
            {
                BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                GlobalSavingsMenu();
                SavingsMenu();
                ChequingMenu();
            }
            catch (StackOverflowException se)
            {
                Console.WriteLine("Problem Found in source code, check program!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Found!");
            }
        }
       

        private static void BankMenu(SavingsAccount savings, ChequingAccount chequing, GlobalSavingsAccount globalSavingsAccount)
        {
            Console.WriteLine("Select the type of Account");
            Console.WriteLine("A: Savings \n" + "B: Chequing \n" + "C: GobalSavings \n" + "Q: Exit \n");
            option = Console.ReadLine();
            option = option.ToUpper();
        
            switch (option.ToUpper())
            {
                case "A":
                    SavingsMenu();
                    break;

                case "B":
                    ChequingMenu();
                    break;

                case "C":
                    GlobalSavingsMenu();
                    break;

                case "Q":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("That is NOT an option, try again.");
                    BankMenu(savings, chequing, globalSavingsAccount);
                    break;
            }
         }

        private static void GlobalSavingsMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("A: Deposit \n" + "B: Withdrawal \n" + "C: Close + Report \n" + "D: Report Balance in USD \n" + "R: Return to Bank Menu \n");
            option = Console.ReadLine();
            option = option.ToUpper();

            switch (option.ToUpper())
            {
                case "A":
                    Console.WriteLine("How much would you like to deposit?");
                    amount = Console.ReadLine();
                    globalSavingsAccount.MakeDeposit(Convert.ToDouble(amount));
                    Console.WriteLine("Your current balance is: ${0}", globalSavingsAccount.balance);
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "B":
                    Console.WriteLine("How much would you like to withdrawal?");
                    amount = Console.ReadLine();
                    globalSavingsAccount.MakeWithdrawl(Convert.ToDouble(amount));
                    Console.WriteLine("Your current balance is: ${0}", globalSavingsAccount.balance);
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "C":
                    Console.WriteLine("Close + Report:");
                    Console.WriteLine(globalSavingsAccount.CloseAndReport());
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "D":
                    Console.WriteLine("Report Balance in USD");
                    Console.WriteLine("Convertion in US: ${0}",globalSavingsAccount.USValue(0.76));
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "R":
                    BankMenu(savingsAccount,chequingAccount,globalSavingsAccount);
                    break;

                default:
                    Console.WriteLine("That is NOT an option, try again.");
                    GlobalSavingsMenu();
                    break;
            }
        }

        private static void ChequingMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("A: Deposit \n" + "B: Withdrawal \n" + "C: Close + Report \n" + "R: Return to Bank Menu \n");
            option = Console.ReadLine();
            option = option.ToUpper();

            switch (option.ToUpper())
            {
                case "A":
                    Console.WriteLine("How much would you like to deposit?");
                    amount = Console.ReadLine();
                    chequingAccount.MakeDeposit(Convert.ToDouble(amount));
                    Console.WriteLine("Your current balance is: ${0}", chequingAccount.balance);
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "B":
                    Console.WriteLine("How much would you like to withdrawal?");
                    amount = Console.ReadLine();
                    chequingAccount.MakeWithdrawl(Convert.ToDouble(amount));
                    Console.WriteLine("Your current balance is: ${0}", chequingAccount.balance);
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "C":
                    Console.WriteLine("Close + Report:");
                    chequingAccount.CloseAndReport();
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    Console.ReadLine();
                    break;

                case "R":
                    BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                    break;

                default:
                    Console.WriteLine("That is NOT an option, try again.");
                    ChequingMenu();
                    break;
            }
        }

        private static void SavingsMenu()
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("A: Deposit \n" + "B: Withdrawal \n" + "C: Close + Report \n" + "R: Return to Bank Menu \n");
                option = Console.ReadLine();
                option = option.ToUpper();

                switch (option.ToUpper())
                {
                    case "A":
                        Console.WriteLine("How much would you like to deposit?");
                        amount = Console.ReadLine();
                        savingsAccount.MakeDeposit(Convert.ToDouble(amount));
                        Console.WriteLine("Your current balance is: ${0}", savingsAccount.balance);
                        BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                        Console.ReadLine();
                    break;

                    case "B":
                        Console.WriteLine("How much would you like to withdrawal?");
                        amount = Console.ReadLine();
                        savingsAccount.MakeWithdrawl(Convert.ToDouble(amount));
                        Console.WriteLine("Your current balance is: ${0}", savingsAccount.balance);
                        BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                        Console.ReadLine();
                    break;

                    case "C":
                        Console.WriteLine("Close + Report:");
                        chequingAccount.CloseAndReport();
                        BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                        Console.ReadLine();
                    break;

                    case "R":
                        BankMenu(savingsAccount, chequingAccount, globalSavingsAccount);
                        break;

                    default:
                        Console.WriteLine("That is NOT an option, try again.");
                        SavingsMenu();
                        break;
                }
            
        }
    } 
    }

        

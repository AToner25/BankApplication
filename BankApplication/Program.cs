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
        private static string option;
        private static ChequingAccount chequingAccount;
        private static GlobalSavingsAccount globalSavingsAccount;
        private static readonly SavingsAccount savings;

        private static void Main(string[] args)
        {
            BankMenu(savings, chequingAccount, globalSavingsAccount);
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
                    
                    break;

                case "B":
                    Console.WriteLine("How much would you like to withdrawal?");
                    break;

                case "C":
                    Console.WriteLine("Close + Report:");
                    break;

                case "D":
                    Console.WriteLine("Report Balance in USD:");
                    break;

                case "R":
                    BankMenu(savings,chequingAccount,globalSavingsAccount);
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
                    
                    break;

                case "B":
                    Console.WriteLine("How much would you like to withdrawal?");
                    break;

                case "C":
                    Console.WriteLine("Close + Report:");
                    break;

                case "R":
                    BankMenu(savings, chequingAccount, globalSavingsAccount);
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
                    break;

                case "B":
                    Console.WriteLine("How much would you like to withdrawal?");
                    break;

                case "C":
                    Console.WriteLine("Close + Report:");
                    break;

                case "R":
                    BankMenu(savings, chequingAccount, globalSavingsAccount);
                    break;

                default:
                    Console.WriteLine("That is NOT an option, try again.");
                    SavingsMenu();
                    break;
            }
        }
    } 
    }

        

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
        private static void Main(string[] args)
        {

            BankMenu(savings, chequingAccount, globalSavingsAccount);


        }
        private static void BankMenu(SavingsAccount savings, ChequingAccount chequing, GlobalSavingsAccount globalSavingsAccount)
        {
            Console.WriteLine("Select the type of Account");
            Console.WriteLine("A: savings \n" + "B: chequing \n" + "C: gobalSavings \n" + "Q: Exit \n");
            option = Console.ReadLine();

            switch ()
            }

        } }

        

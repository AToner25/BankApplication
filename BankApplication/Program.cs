using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                Console.WriteLine("Bank Menu");
                Console.WriteLine("A:Savings");
                Console.WriteLine("B:Checking");
                Console.WriteLine("C:GlobalSavings");
                Console.WriteLine("D:Savings");

                Option = Console.ReadLine();



                switch (Option.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Saving Menu");
                        Console.WriteLine("A:Deposit");
                        Console.WriteLine("B:Withdrawal");
                        Console.WriteLine("C:Close + Report");
                        Console.WriteLine("R:Return to Bank Menu");
                        Option1 = Console.ReadLine();
                        break;

                }
            }
            catch
            {

            }
           

        }
    }
}

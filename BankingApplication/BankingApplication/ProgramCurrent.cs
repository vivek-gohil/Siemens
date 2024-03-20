using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class ProgramCurrent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProgramCurrent Main start");

            Current current = new Current(101, "Test", 10000, 50000);

            Console.WriteLine("withdraw = 5000");
            bool result = current.withdraw(5000);
            Console.WriteLine(result);
            Console.WriteLine("Main Balance = " + current.Balance);
            Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);

            Console.WriteLine();

            Console.WriteLine("withdraw = 12000");
            result = current.withdraw(12000);
            Console.WriteLine(result);
            Console.WriteLine("Main Balance = " + current.Balance);
            Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);

            Console.WriteLine();

            Console.WriteLine("withdraw = 5000");
            result = current.withdraw(5000);
            Console.WriteLine(result);
            Console.WriteLine("Main Balance = " + current.Balance);
            Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);


            Console.WriteLine();

            Console.WriteLine("deposit = 3000");
            result = current.deposit(3000);
            Console.WriteLine(result);
            Console.WriteLine("Main Balance = " + current.Balance);
            Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);

            Console.WriteLine();

            Console.WriteLine("deposit = 10000");
            result = current.deposit(10000);
            Console.WriteLine(result);
            Console.WriteLine("Main Balance = " + current.Balance);
            Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);


            Console.WriteLine();

            Console.WriteLine("deposit = 5000");
            result = current.deposit(5000);
            Console.WriteLine(result);
            Console.WriteLine("Main Balance = " + current.Balance);
            Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);

            Console.WriteLine("ProgramCurrent Main end");

        }
    }
}

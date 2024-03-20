using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Current : Account
    {
        private double overdraftBalance;
        private double initialOverdraftBalance;

        public Current() {
            Console.WriteLine("Default Constructor of Current");
        }

        public Current(int accountNumber , string name, double balance,double overdraftBalance) 
            :base(accountNumber, name, balance) 
        {
            Console.WriteLine("Overloaded Constructor of Current");
            OverdraftBalance = overdraftBalance;
            initialOverdraftBalance = overdraftBalance; 
        }
        public double OverdraftBalance { get { return overdraftBalance; } set { overdraftBalance = value; } }   
   
        public bool withdraw(double amount)
        {
            if(amount >0 && amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            if(amount > 0 && amount > Balance && amount <= Balance + OverdraftBalance)
            {
                amount = amount - Balance;
                Balance = 0;
                overdraftBalance = overdraftBalance - amount;
                return true;
            }

            return false;
        }

        public bool deposit(double amount)
        {
            if (amount > 0 && initialOverdraftBalance > overdraftBalance)
            {
                if (amount > (initialOverdraftBalance - overdraftBalance))
                {
                    amount = amount - (initialOverdraftBalance - overdraftBalance);
                    overdraftBalance = overdraftBalance + (initialOverdraftBalance - overdraftBalance);
                    Balance = Balance + amount;
                    return true;
                }
                else
                {
                    overdraftBalance += amount;
                    return true;
                }
            }
            else
            {
                if (amount > 0)
                {
                    Balance += amount;
                    return true;
                }
                else { return false; }
            }
        }
    }
}

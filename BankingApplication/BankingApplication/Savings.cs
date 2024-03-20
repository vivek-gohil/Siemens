using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Savings : Account
    {
        private bool isSalary;

        public Savings() {
            Console.WriteLine("Default constructor of Savings");
        }    

        public Savings(int accountNumber,string name,double balance,bool isSalary) 
                                                : base(accountNumber,name,balance) 
        {
            Console.WriteLine("Overloaded constructor of Savings");
            IsSalary = isSalary;
        }
        public bool IsSalary { get { return isSalary; }  set { isSalary = value; } }

        public bool deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool withdraw(double amount)
        {
            if(isSalary)
            {
                if(amount > 0 && amount <= Balance)
                {
                    Balance = Balance - amount;
                    return true;
                }
            }
            else
            {
                if(amount > 0 && Balance - amount >= 500)
                {
                    Balance = Balance - amount;
                    return true;
                }
            }
            return false;
        }   
    }
}



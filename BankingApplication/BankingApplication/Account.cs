using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Account
    {
        private int accountNumber;
        private string name;
        private double balance;

        public int AccountNumber {  
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance 
        {  
            get { return balance; } 
            set { balance = value; } 
        }

        public bool withdraw(double amount)
        {
            if(amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                return true;
            }else
            {
                return false;
            } 
        }

        public bool deposit(double amount)
        {
            if(amount > 0)
            {
                balance  = balance + amount;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

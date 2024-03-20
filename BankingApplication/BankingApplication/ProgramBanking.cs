using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class ProgramBanking
    {
        static void Main(String[] args)
        {
            int accountNumber;
            string name;
            double balance;
            bool isSalary;
            double overdraftBalance;
            int accountChoice, transactionChoice;
            string continueChoice;

            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");
            Console.WriteLine("Enter your choice");
            accountChoice = Convert.ToInt32(Console.ReadLine());
            switch (accountChoice)
            {
                case 1:
                    Console.WriteLine("Enter account number");
                    accountNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter name");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter balance");
                    balance = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Do you want to open Salary Account true-false");
                    isSalary = Convert.ToBoolean(Console.ReadLine());

                    Savings savings = new Savings(accountNumber, name, balance, isSalary);

                    do
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Withdraw");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Check Balance");
                        Console.WriteLine("Enter your choice");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("You have selected withdraw");
                                Console.WriteLine("Enter amount");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                bool result = savings.withdraw(amount);
                                if (result)
                                {
                                    Console.WriteLine("Transaction Successfull");
                                    Console.WriteLine("Balance = " + savings.Balance);
                                }
                                else
                                {
                                    Console.WriteLine("Transaction Failed");
                                    Console.WriteLine("Balance = " + savings.Balance);
                                }
                                break;
                            case 2:
                                Console.WriteLine("You have selected deposit");
                                Console.WriteLine("Enter amount");
                                amount = Convert.ToDouble(Console.ReadLine());
                                result = savings.deposit(amount);
                                if (result)
                                {
                                    Console.WriteLine("Transaction Successfull");
                                    Console.WriteLine("Balance = " + savings.Balance);
                                }
                                else
                                {
                                    Console.WriteLine("Transaction Failed");
                                    Console.WriteLine("Balance = " + savings.Balance);
                                }
                                break;
                            case 3:
                                Console.WriteLine("Balance = " + savings.Balance);
                                break;
                        }
                        Console.WriteLine("Do you want to continue ? ");
                        continueChoice = Console.ReadLine();
                    }
                    while (continueChoice == "Yes");
                    break;
                case 2:
                    Console.WriteLine("Enter account number");
                    accountNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter name");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter balance");
                    balance = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Overdraft Balance");
                    overdraftBalance = Convert.ToDouble(Console.ReadLine());

                    Current current = new Current(accountNumber, name, balance, overdraftBalance);

                    do
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Withdraw");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Check Balance");
                        Console.WriteLine("Enter your choice");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("You have selected withdraw");
                                Console.WriteLine("Enter amount");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                bool result = current.withdraw(amount);
                                if (result)
                                {
                                    Console.WriteLine("Transaction Successfull");
                                    Console.WriteLine("Balance = " + current.Balance);
                                    Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);
                                }
                                else
                                {
                                    Console.WriteLine("Transaction Failed");
                                    Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);
                                }
                                break;
                            case 2:
                                Console.WriteLine("You have selected deposit");
                                Console.WriteLine("Enter amount");
                                amount = Convert.ToDouble(Console.ReadLine());
                                result = current.deposit(amount);
                                if (result)
                                {
                                    Console.WriteLine("Transaction Successfull");
                                    Console.WriteLine("Balance = " + current.Balance);
                                    Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);
                                }
                                else
                                {
                                    Console.WriteLine("Transaction Failed");
                                    Console.WriteLine("Balance = " + current.Balance);
                                    Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);
                                }
                                break;
                            case 3:
                                Console.WriteLine("Balance = " + current.Balance);
                                Console.WriteLine("Overdraft Balance = " + current.OverdraftBalance);
                                break;
                        }
                        Console.WriteLine("Do you want to continue ? ");
                        continueChoice = Console.ReadLine();
                    }
                    while (continueChoice == "Yes");

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        
    }
}

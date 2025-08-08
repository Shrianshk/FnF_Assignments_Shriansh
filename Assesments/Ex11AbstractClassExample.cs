using banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    abstract class Account
    {
        static int accountNoSeed = 1000;
        public int AccountNo { get; set; }
        public string AccountHolder { get; set; }
        public Account()
        {
            AccountNo = ++accountNoSeed;
        }
        public double Balance { get; set; }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Desposit amount to continue ");
            }
            Balance += amount;
            Console.WriteLine($"Deposited amount is{amount} and balance is {Balance}");
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance is {Balance}.");
        }
        public abstract void CalculateInterest();

    }
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } = .025;
        public SavingsAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
        }
        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interst earned on savings account is {interest}");
        }
    }
    class RecurringAccount : Account
    {
        public double InterestRate { get; set; } = 0.05;
        public double MonthlyDeposit { get; set; }
        public int Months { get; set; }
        public RecurringAccount(string accountHolder, double monthlyDeposit, int months)
        {
            AccountHolder = accountHolder;
            MonthlyDeposit = monthlyDeposit;
            Months = months;
        }
        public override void CalculateInterest()
        {
            // Formula for Recurring Deposit Interest:
            // Interest = P * n(n+1) * r / (2*12*100)
            // P = MonthlyDeposit, n = Months, r = annual interest rate (assume 5%)
            double r = 5.0;
            double interest = (MonthlyDeposit * Months * (Months + 1) * r) / (2 * 12 * 100);
            Deposit(interest); // Adding interest to the balance
            Console.WriteLine($"Interest earned on Recurring Deposit Account: {interest}");
        }
    }
    class FixedDeposit : Account
    {
        public double InterestRate { get; set; } = 0.75;
        public double FdDeposit { get; set; }
        public int Years { get; set; }
        public FixedDeposit(string accountholder, double monthlyDeposit, int years)
        {
            AccountHolder = accountholder;
            FdDeposit = monthlyDeposit;
            Years = years;
        }
        public override void CalculateInterest()
        {
            Deposit(FdDeposit);
            double interest = (FdDeposit * InterestRate * Years) / 100;
            Deposit(interest);
            Console.WriteLine($"Interest on FdDeposit is {interest}");
        }
    }
}

namespace ConsoleApp1
{
    internal class Ex11AbstractClassExample
    {
        static void Main(string[] args)
        {
            Account fd = new FixedDeposit("Shri",40000,5);
            fd.Deposit(10000);

            fd.CalculateInterest();
            
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExemploThreding
{
    class BankAcct
    {
        private Object accLock = new object();
        double Balance { set; get; }

        public BankAcct(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry {Balance} in Account");
                return Balance;
            }

            lock (accLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine($"Removed {Balance} and { Balance - amt } left in Account");
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWithdraw(int value)
        {
            Withdraw(value);
        }
    }
}

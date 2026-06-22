using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Example.Banking
{
     internal class SavingsAccount : BankAccount
    {
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Savings deposit successful.");
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < 1000)
            {
                Console.WriteLine("Minimum balance rule violated. Withdrawal denied.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Savings withdrawal successful.");
            }
        }
    }

}

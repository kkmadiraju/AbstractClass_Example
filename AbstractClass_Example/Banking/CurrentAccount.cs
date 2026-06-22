using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Example.Banking
{
    internal class CurrentAccount : BankAccount
    {
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Current account deposit successful.");
        }

        public override void Withdraw(decimal amount)
        {
            // Current accounts allow overdraft
            Balance -= amount;
            Console.WriteLine("Current account withdrawal (with overdraft) successful.");
        }
    }

}

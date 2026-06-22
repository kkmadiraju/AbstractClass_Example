using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Example.Banking
{
    // RBI says: "Every account MUST implement Withdraw and Deposit properly."
    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; protected set; }

        // Abstract methods – every account type must define its own rules
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        // Concrete method – common for all accounts
        public void PrintStatement()
        {
            Console.WriteLine($"Statement for {CustomerName} - Balance: {Balance}");
        }
    }

}

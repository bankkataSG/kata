using System.Collections.Generic;

namespace BankAccount
{
    using System;

    public class Account
    {
        public Account()
        {
            History = new List<Transaction>();
            Id = Guid.NewGuid();
            Balance = 0;
        }

        public Guid Id { get; }

        public int Balance { get; private set; }

        public void Substract(Account payee, int amount)
        {
            Balance -= amount;
            payee.Balance += amount;
            History.Add(new Transaction());
        }

        public List<Transaction> History { get; }
    }
}
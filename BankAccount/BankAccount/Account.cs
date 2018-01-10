using System.Collections.Generic;

namespace BankAccount
{
    using System;

    public class Account
    {
        public Account()
        {
            History = new List<object>();
            Id = Guid.NewGuid();
            Balance = 0;
        }

        public Guid Id { get; }

        public int Balance { get; private set; }

        public void Substract(Account payee, int amount)
        {
            Balance -= amount;
            payee.Balance += amount;
        }

        public List<object> History { get; }
    }
}
namespace BankAccount
{
    using System;

    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
            Balance = 0;
        }

        public Guid Id { get; }

        public int Balance { get; private set; }

        public void Transfer(Account payee, int amount)
        {
            Balance -= amount;
        }
    }
}
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

        public int Balance { get; }
    }
}
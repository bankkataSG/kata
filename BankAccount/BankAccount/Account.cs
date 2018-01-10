namespace BankAccount
{
    using System;

    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
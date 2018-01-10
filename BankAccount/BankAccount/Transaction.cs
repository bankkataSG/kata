namespace BankAccount
{
    using System;

    public class Transaction
    {
        public Transaction(Guid payee, Guid payer, int amount)
        {
            Payee = payee;
            Payer = payer;
            Amount = amount;
        }

        public Guid Payer { get; }

        public Guid Payee { get; }

        public int Amount { get; }
    }
}
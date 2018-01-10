using System.Linq;

namespace BankAccount
{
    using System;
    using System.Collections.Generic;

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

        public void Send(Account payee, int amount)
        {
            var transaction = new Transaction(payee.Id, Id, amount);

            Balance -= amount;
            payee.Receive(transaction);

            History.Add(transaction);
        }

        public List<Transaction> History { get; }

        public void Receive(Transaction transaction)
        {
            Balance += transaction.Amount;
            History.Add(transaction);
        }

        public List<Transaction> GetAllTransactionsFor(Account account)
        {
            return TransactionsFrom(account.Id).Union(TransActionsTo(account.Id)).ToList();
        }

        private IEnumerable<Transaction> TransActionsTo(Guid accountId)
        {
            return History.Where(h => h.Payee == accountId);
        }

        private IEnumerable<Transaction> TransactionsFrom(Guid accountId)
        {
            return History.Where(h => h.Payer == accountId);
        }
    }
}
namespace BankAccountTests
{
    using System;
    using BankAccount;
    using FluentAssertions;
    using Xunit;

    public class TransactionTests
    {
        [Fact]
        public void CtorInitialisesTransaction()
        {
            var payeeGuid = Guid.NewGuid();
            var payerGuid = Guid.NewGuid();

            var transaction = new Transaction(payeeGuid, payerGuid, 1001);
            transaction.Payer.Should().Be(payerGuid);
            transaction.Payee.Should().Be(payeeGuid);
            transaction.Amount.Should().Be(1001);
        }
    }
}
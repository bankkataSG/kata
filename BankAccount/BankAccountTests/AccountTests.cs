namespace BankAccountTests
{
    using System.Linq;
    using BankAccount;
    using FluentAssertions;
    using Xunit;

    public class AccountTests
    {
        private Account payer;
        private Account payee;

        public AccountTests()
        {
            payer = new Account();
            payee = new Account();
        }

        [Fact]
        public void GivenNewAccount_ThenAccountId_ShouldBeSet()
        {
            new Account().Id.Should().NotBeEmpty();
        }

        [Fact]
        public void GivenNewAccount_ThenBalance_ShouldBeZero()
        {
            new Account().Balance.Should().Be(0);
        }

        [Fact]
        public void NewAccount_HasEmptyHistory()
        {
            new Account().History.Should().BeEmpty();
        }

        [Fact]
        public void GivenTwoAccounts_WhenMoneyIsTransferred_ThenPayerBalanceIsLower()
        {
            var initialBalance = payer.Balance;

            payer.Send(payee, 100);

            payer.Balance.Should().Be(initialBalance - 100);
        }

        [Fact]
        public void GivenTwoAccounts_WhenMoneyIsSend_ThenPayeeBalanceIsHigher()
        {
            var initialBalance = payee.Balance;

            payer.Send(payee, 100);

            payee.Balance.Should().Be(initialBalance + 100);
        }

        [Fact]
        public void WhenMoneyIsSend_ThenEntryInTransactionHistoryIsWritten()
        {
            payer.History.Clear();

            payer.Send(payee, 133);

            payer.History.Count.Should().Be(1);
        }

        [Fact]
        public void WhenMoneyIsSend_ThenTransactionHasPayer()
        {
            payer.History.Clear();

            payer.Send(payee, 1044);

            payer.History.First().Payer.Should().Be(payer.Id);
        }

        [Fact]
        public void WhenMoneyIsSend_ThenTransactionHasPayee()
        {
            payer.History.Clear();

            payer.Send(payee, 4344);

            payer.History.First().Payee.Should().Be(payee.Id);
        }

        [Fact]
        public void WhenMoneyIsSend_ThenTransactionHasAmount()
        {
            payer.History.Clear();

            payer.Send(payee, 4344);

            payer.History.First().Amount.Should().Be(4344);
        }

        [Fact]
        public void WhenMoneyIsReceived_ThenTransactionMatches()
        {
            payer.History.Clear();
            var transaction = new Transaction(payee.Id, payer.Id, 100);

            payer.Receive(transaction);

            payer.History.First().Should().Be(transaction);
        }
    }
}

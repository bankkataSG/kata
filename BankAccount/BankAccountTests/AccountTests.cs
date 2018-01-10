namespace BankAccountTests
{
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

            payer.Substract(payee, 100);

            payer.Balance.Should().Be(initialBalance - 100);
        }

        [Fact]
        public void GivenTwoAccounts_WhenMoneyIsTransfered_ThenPayeeBalanceIsHigher()
        {
            var initialBalance = payee.Balance;

            payer.Substract(payee, 100);

            payee.Balance.Should().Be(initialBalance + 100);
        }

        //[Fact]
        //public void WhenMoneyIsSubstracted_ThenEntryInTransactionHistoryIsWritten()
        //{
        //    //payer.Substract(payee, 110);
        //    //payer
        //}
    }
}

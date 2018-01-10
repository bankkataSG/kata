namespace BankAccountTests
{
    using BankAccount;
    using FluentAssertions;
    using Xunit;

    public class AccountTests
    {
        private readonly Account account;

        public AccountTests()
        {
            account = new Account();
        }

        [Fact]
        public void GivenNewAccount_ThenAccountId_ShouldBeSet()
        {
            account.Id.Should().NotBeEmpty();
        }

        [Fact]
        public void GivenNewAccount_ThenBalance_ShouldBeZero()
        {
            account.Balance.Should().Be(0);
        }

        [Fact]
        public void GivenTwoAccounts_WhenMoneyIsTransferred_ThenPayerBalanceIsLower()
        {
            var payer = new Account();
            var initialBalance = payer.Balance;

            var payee = new Account();
            payer.Transfer(payee, 100);
            payer.Balance.Should().Be(initialBalance - 100);
        }

        [Fact]
        public void GivenTwoAccounts_WhenMoneyIsTransfered_ThenPayeeBalanceIsHigher()
        {
            var payer = new Account();
            var payee = new Account();

            var initialBalance = payee.Balance;

            payer.Transfer(payee, 100);

            payee.Balance.Should().Be(initialBalance + 100);
        }
    }
}

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
    }
}

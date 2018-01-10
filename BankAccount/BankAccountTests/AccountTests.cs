using FluentAssertions;

namespace BankAccountTests
{
    using BankAccount;
    using Xunit;

    public class AccountTests
    {
        [Fact]
        public void GivenNewAccount_ThenAccountId_ShouldBeSet()
        {
            var bankAccount = new Account();
            bankAccount.Id.Should().NotBeEmpty();
        }
    }
}

using Xunit;

namespace BankAccountTests
{
    public class Tests
    {
        [Fact]
        public void CanCreateAccount()
        {
            var bankAccount = new Account();
        }
    }
}



using Banking.Domain;

namespace BankingUnitTests.BankAccount
{
    public class WithdrawGuards
    {
        [Fact]
        public void OverdraftNotAllowed()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdrawal(openingBalance + .01M);

            Assert.Equal(openingBalance, account.GetBalance());
        }

        [Fact]
        public void OverdraftThrowsException()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdrawal(openingBalance + .01M);

            Assert.Throws<OverdraftException>(
            () => account.Withdrawal(openingBalance + .01M));
        }
    }
}



namespace BankingUnitTests.BankAccount
{
    public class WithdrawGuards
    {
        [Fact]
        public void OverdraftNotAllowed()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdrawal(openingBalance);

            Assert.Equal(0, account.GetBalance());
        }
    }
}

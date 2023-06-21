
namespace BankingUnitTests.BankAccount
{
    public class MakingDeposit
    {
        [Fact]
        public void DepositIncreasesBalance()
        {
            Account account = new Account();

            decimal openingBalance = account.GetBalance();
            decimal amountToDeposit = 100M;


            account.Deposit(amountToDeposit);


            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
            
        
        }
    }
}

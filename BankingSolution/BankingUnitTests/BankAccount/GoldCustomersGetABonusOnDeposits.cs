

namespace BankingUnitTests.BankAccount;
public class GoldCustomersGetABonusOnDeposits
{
    [Fact]
    public void BonusIsApplied()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        account.AccountType = LoyaltyLevel.Gold;
        var amountToDeposit =  100M;
        var expectedNewBalance = openingBalance + amountToDeposit;

        account.Deposit(amountToDeposit);
        Assert.Equal(expectedNewBalance, account.GetBalance());
    }
}


namespace BankingUnitTests.BankAccount;
public class AccountBonusCalculations
{
    [Fact]
    public void DepositUsesTheBonusCalculator()
    {
        var account = new Account(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();
        account.Deposit(100);
        Assert.Equal(openingBalance + 100M + 42M, account.GetBalance());
    }
}

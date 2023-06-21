public class MakingWithdrawals
{
    [Fact]
    public void MakingAWithdrawalDecreasesTheBalance()
    {
        Account account = new Account();
        decimal closingBalance = account.GetBalance();
        decimal amountToWithdraw = 100M;
        account.Withdrawal(amountToWithdraw);

        Assert.Equal(closingBalance - amountToWithdraw, account.GetBalance());
    }
}
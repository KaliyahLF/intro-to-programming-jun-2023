
namespace BankingUnitTests.TestDoubles;
public class StubbedBonusCalculator : ICanCalculateBonuses
{
    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountOfDeposit)
    {
        return (balance == 5000M && amountOfDeposit == 112M) ? 42 : 0;
    }
}

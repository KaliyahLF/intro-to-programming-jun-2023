
namespace BankingUnitTests.TestDoubles;
public class DummyBonusCalculator : ICanCalculateBonuses
{
    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountOfDeposit)
    {
        return 0;
    }
}

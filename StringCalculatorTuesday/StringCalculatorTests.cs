
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    //Test #1
    [InlineData("", 0)]
    //Test #2
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("108", 108)]
    [InlineData("9003949", 9003949)]
    //Test #3
    [InlineData("1,2", 3)]
    [InlineData("2,3", 5)]
    [InlineData("10,11", 21)]
    //Test #4
    [InlineData("1,2;\n3", 6)]
    [InlineData("2\n3,;,,\n4,5,9", 23)]
    [InlineData("10,11,12,0,0,1", 34)]
    //Test #5
    [InlineData("-1", 0)]

    public void StringCalculator(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }


}

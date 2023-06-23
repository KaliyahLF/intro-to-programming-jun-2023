
using System.Xml.Linq;

namespace Greeter.UnitTest;
public class GreetingTest
{
    [Theory]
    [InlineData("Windom", "Hello, Windom!")]
    [InlineData("Cooper", "Hello, Cooper!")]
    [InlineData("Kaliyah", "Hello, Kaliyah!")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData("", "Hello, Captain!")]
    public void EmptyName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData("WINDOM", "HELLO, WINDOM!")]
    [InlineData("COOPER", "HELLO, COOPER!")]
    [InlineData("KALIYAH", "HELLO, KALIYAH!")]
    public void ShoutName(string name, string expected)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }




    [Theory]
    [InlineData("Bob", "Mary", "Hello, Bob and Mary!")]
    [InlineData("Jalen", "Kaliyah", "Hello, Jalen and Kaliyah!")]
    [InlineData("Anakin", "Kenobi", "Hello, Anakin and Kenobi!")]
    public void MultipleNames(string name1, string name2, string expected)
    {
        var greeter = new GreetingMaker();
        string greeting = greeter.Greet(name1, name2);

        Assert.Equal(expected, greeting);

    }
}

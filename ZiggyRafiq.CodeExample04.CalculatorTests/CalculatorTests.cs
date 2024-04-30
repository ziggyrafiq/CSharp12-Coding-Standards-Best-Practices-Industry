using ZiggyRafiq.CodeExample04.Calculator;

namespace ZiggyRafiq.CodeExample04.CalculatorTests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        CalculatorExample calculator = new CalculatorExample();
        int result = calculator.Add(3, 5);
        Assert.Equals(8, result);
    }



}
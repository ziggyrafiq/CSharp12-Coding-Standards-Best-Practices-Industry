// Example of xUnit.net test fixture
namespace ZiggyRafiq.CodeExample06.CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(3, 5);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
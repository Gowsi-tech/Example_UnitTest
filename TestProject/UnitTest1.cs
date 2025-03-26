using Example_UnitTest;
using Xunit;

namespace TestProject
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 5, 5)]
        public void Add_ShouldReturnCorrectSum_WithMultipleInputs(int a, int b, int expected)
        {
            var calculator = new Calculator();
            int result = calculator.Add(a, b);
            Assert.Equal(expected, result);
        }
    }
}
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

        [Fact]
        public void Sub_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.sub(2, 3);

            // Assert
            Assert.Equal(-1, result);
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

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 5, -5)]
        public void Sub_ShouldReturnCorrectSum_WithMultipleInputs(int a, int b, int expected)
        {
            var calculator = new Calculator();
            int result = calculator.sub(a, b);
            Assert.Equal(expected, result);
        }
    }
}
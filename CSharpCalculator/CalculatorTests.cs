using Xunit;

namespace CSharpCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 5;
            int num2 = 10;

            // Act
            var result = calculator.Add(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsDifference()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 10;
            int num2 = 5;

            // Act
            var result = calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 5;
            int num2 = 10;

            // Act
            var result = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsQuotient()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 10;
            int num2 = 2;

            // Act
            var result = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 10;
            int num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(num1, num2));
        }
    }
}